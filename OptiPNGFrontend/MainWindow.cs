using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading;

namespace OptipngFrontend
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
        }

        #region Execute Handler Functions and Variables

        int completed = 0;
        int total = 0;
        int errors = 0;

        private bool ErrorCheck()
        {
            if (string.IsNullOrWhiteSpace(optipngPath.Text) || !File.Exists(optipngPath.Text))
            {
                MessageBox.Show("No OptiPNG executable selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (useDir.Checked && string.IsNullOrWhiteSpace(dirPath.Text))
            {
                MessageBox.Show("No output directory selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (useLog.Checked && string.IsNullOrWhiteSpace(logPath.Text))
            {
                MessageBox.Show("No log file specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private string CompositeArguments()
        {
            string lirArgs = nx.Checked ? "-nx" : string.Format("{0} {1} {2}", nb.Checked ? "-nb" : "", nc.Checked ? "-nc" : "", np.Checked ? "-np" : "");
            return string.Format("-o{0} {1} {2} {3} {4} {5} {6} {7} {8}",
                optimisationLevel.SelectedIndex, // set up so that the index corresponds 1:1 with the available levels
                verbose.Checked ? "-v" : "",
                preserve.Checked ? "-preserve" : "",
                interlaceType.SelectedIndex > 0 ? string.Format("-i{0}", interlaceType.SelectedIndex - 1) : "",
                nz.Checked ? "-nz" : "",
                lirArgs,
                full.Checked ? "-full" : "",
                fix.Checked ? "-fix" : "",
                simulate.Checked ? "-simulate" : ""
                );
        }

        private void ResetValues()
        {
            progress.Maximum = total = selection.Items.Count;
            progress.Value = completed = errors = 0;
        }

        private ThreadDataBundle ProduceDataBundle(int id, ListViewItem item)
        {
            string outDir = useDir.Checked ? dirPath.Text : Path.GetDirectoryName(item.Text);
            string outputPath = Path.Combine(outDir, Path.ChangeExtension(Path.GetFileName(item.Text), ".png"));
            string tmpOutName = string.Format("tmp\\tmp{0}{1}", id, (Path.GetExtension(item.Text) == ".png") ? "" : ".png");
            string tempFileName = string.Format("tmp\\tmp{0}", id);
            return new ThreadDataBundle(item.Text, outputPath, id, item, tempFileName, tmpOutName);
        }

        private bool ExecuteOptiPNG(string execPath, string args, ThreadDataBundle bundle)
        {
            // ready the temp file
            File.Copy(bundle.InputPath, bundle.TempFileName, true);

            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = execPath,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = string.Format("{1} {0}", bundle.TempFileName, args), 
                    UseShellExecute = false, // allows for stdout and stderr redirection
                    CreateNoWindow = true // this stops console windows appearing and grabbing focus
                },
            };

            proc.Start();

            bundle.SetStandardOutput(proc.StandardOutput.ReadToEnd().Replace(bundle.TempOutputFileName, bundle.OutputPath).Replace(bundle.TempFileName, bundle.InputPath));
            bundle.SetStandardError(proc.StandardError.ReadToEnd().Replace(bundle.TempOutputFileName, bundle.OutputPath).Replace(bundle.TempFileName, bundle.InputPath));

            proc.WaitForExit();

            if (proc.ExitCode == 2) // examining the optipng source lead me to believe this errorcode is given when an error occurs; may be wrong however
                return false;

            return true;
        }

        private void NotificationHandler(ThreadDataBundle bundle)
        {
            lock (_notifyLock)
            {
                progress.BeginInvoke(new Action(() => progress.Increment(1)));

                notification.BeginInvoke(new Action(() =>
                {
                    completed++;
                    if (completed != total)
                        notification.Text = string.Format("{0}/{1} files processed", completed, total);
                    else
                        notification.Text = "All files processed; operation completed";

                    if (errors > 0)
                    {
                        if(errors == 1)
                            notification.Text = string.Format("{0} (An error have occurred, see log for details)", notification.Text);
                        else
                            notification.Text = string.Format("{0} ({1} errors have occurred, see log for details)", notification.Text, errors);
                    }
                }));

                selection.BeginInvoke(new Action(() => selection.Items.Remove(bundle.AssociatedListItem)));
            }
        }

        private void TidyFiles(ThreadDataBundle bundle)
        {
            File.Copy(bundle.TempOutputFileName, bundle.OutputPath, true);

            if (bundle.TempOutputFileName != bundle.TempFileName) // prevents us trying to delete files that do not exist
                File.Delete(bundle.TempOutputFileName);

            File.Delete(bundle.TempFileName);
        }

        private void ProcessLog(ThreadDataBundle bundle)
        {
            lock (_fileLock)
            {
                logBox.BeginInvoke(new Action(() =>
                {
                    if (useLog.Checked)
                    {
                        File.AppendAllText(logPath.Text, bundle.ExecutionStandardOutput);
                        File.AppendAllText(logPath.Text, bundle.ExecutionStandardError);
                    }

                    logBox.AppendText(bundle.ExecutionStandardOutput);
                    logBox.AppendText(bundle.ExecutionStandardError);
                }));
            }
        }

        private void OnExecuteButtonClick(object sender, EventArgs e)
        {
            if (!ErrorCheck())
                return;

            ResetValues();

            semaphore = new Semaphore((int)workerThreads.Value, (int)workerThreads.Value);

            int maxThreadPoolThreads = 0, maxIoThreads = 0;
            ThreadPool.GetMaxThreads(out maxThreadPoolThreads, out maxIoThreads);

            if (workerThreads.Value > maxThreadPoolThreads)
                ThreadPool.SetMaxThreads((int)workerThreads.Value, maxIoThreads);

            string args = CompositeArguments();
            string optiPath = optipngPath.Text;

            // make temp directory
            Directory.CreateDirectory("tmp");

            for(int i = 0; i < selection.Items.Count; i++)
            {
                ThreadPool.QueueUserWorkItem((obj) =>
                {
                    semaphore.WaitOne();

                    var threadBundle = (ThreadDataBundle)obj;

                    if (!ExecuteOptiPNG(optiPath, args, threadBundle))
                        errors++;

                    ProcessLog(threadBundle);

                    TidyFiles(threadBundle);

                    NotificationHandler(threadBundle);

                    semaphore.Release();
                }, ProduceDataBundle(i, selection.Items[i]));
            }
        }

        static Semaphore semaphore;
        static object _fileLock = new object();
        static object _notifyLock = new object();

        #endregion

        #region UI Event Handlers

        private void OnFormLoad(object sender, EventArgs e)
        {
            optimisationLevel.SelectedIndex = 2;
            interlaceType.SelectedIndex = 0;
        }

        private void DisableAllLIR_CheckedChanged(object sender, EventArgs e)
        {
            np.Checked = nc.Checked = nb.Checked = nx.Checked;
            np.Enabled = nc.Enabled = nb.Enabled = !nx.Checked;
        }

        private void UseLogFile_CheckedChanged(object sender, EventArgs e)
        {
            if (!useLog.Checked) verbose.Checked = full.Checked = full.Enabled = verbose.Enabled = logSelect.Enabled = logPath.Enabled = false;
            else verbose.Enabled = full.Enabled = logSelect.Enabled = logPath.Enabled = true;
        }

        private void UseOutputDirectory_CheckedChanged(object sender, EventArgs e)
        {
            dirPath.Enabled = dirSelect.Enabled = useDir.Checked;
        }

        private void OpenOutputDirectorySelectionDialog(object sender, EventArgs e)
        {
            folderSelector = new FolderBrowserDialog();
            folderSelector.ShowDialog();

            dirPath.Text = folderSelector.SelectedPath;
        }

        private void OpenLogFileSelectionDialog(object sender, EventArgs e)
        {
            fileSelector = new OpenFileDialog()
            {
                CheckFileExists = false,
                Filter = "Log Files|*.log",
                Title = "Select log file..."
            };

            fileSelector.ShowDialog();

            logPath.Text = fileSelector.FileName;

        }

        private void OpenOptiPNGSelectorDialog(object sender, EventArgs e)
        {
            fileSelector = new OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = "OptiPNG|optipng.exe",
                Title = "Select OptiPNG executable..."
            };

            fileSelector.ShowDialog();

            optipngPath.Text = fileSelector.FileName;
        }

        void OnApplicationExit(object sender, EventArgs e)
        {
            if (Directory.Exists("tmp"))
                Directory.Delete("tmp", true);
        }

        private void addFiles_Click(object sender, EventArgs e)
        {
            fileSelector = new OpenFileDialog()
            {
                CheckPathExists = true,
                Multiselect = true,
                Filter = "Image files|*.png;*.gif;*.bmp;*.pnm;*.tiff",
                Title = "Select Image Files..."
            };

            fileSelector.ShowDialog();

            foreach (string filename in fileSelector.FileNames)
                selection.Items.Add(filename);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void removeSel_Click(object sender, EventArgs e)
        {
            if (completed == total)
            {
                while (selection.SelectedItems.Count > 0)
                    selection.Items.Remove(selection.SelectedItems[0]);
            }
        }

        #endregion

    }
}
