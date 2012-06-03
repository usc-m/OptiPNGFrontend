namespace OptipngFrontend
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit = new System.Windows.Forms.Button();
            this.exec = new System.Windows.Forms.Button();
            this.selection = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addFiles = new System.Windows.Forms.Button();
            this.removeSel = new System.Windows.Forms.Button();
            this.fileSelector = new System.Windows.Forms.OpenFileDialog();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.nb = new System.Windows.Forms.CheckBox();
            this.np = new System.Windows.Forms.CheckBox();
            this.nc = new System.Windows.Forms.CheckBox();
            this.nx = new System.Windows.Forms.CheckBox();
            this.preserve = new System.Windows.Forms.CheckBox();
            this.fix = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optimisationLevel = new System.Windows.Forms.ComboBox();
            this.interlaceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.full = new System.Windows.Forms.CheckBox();
            this.simulate = new System.Windows.Forms.CheckBox();
            this.logPath = new System.Windows.Forms.TextBox();
            this.logSelect = new System.Windows.Forms.Button();
            this.useLog = new System.Windows.Forms.CheckBox();
            this.verbose = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.dirPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dirSelect = new System.Windows.Forms.Button();
            this.useDir = new System.Windows.Forms.CheckBox();
            this.nz = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.workerThreads = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.notification = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.optipngSelector = new System.Windows.Forms.Button();
            this.optipngPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerThreads)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(570, 368);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // exec
            // 
            this.exec.Location = new System.Drawing.Point(489, 368);
            this.exec.Name = "exec";
            this.exec.Size = new System.Drawing.Size(75, 23);
            this.exec.TabIndex = 3;
            this.exec.Text = "Execute";
            this.exec.UseVisualStyleBackColor = true;
            this.exec.Click += new System.EventHandler(this.OnExecuteButtonClick);
            // 
            // selection
            // 
            this.selection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.selection.Location = new System.Drawing.Point(6, 6);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(617, 245);
            this.selection.TabIndex = 4;
            this.selection.UseCompatibleStateImageBehavior = false;
            this.selection.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            this.columnHeader1.Width = 613;
            // 
            // addFiles
            // 
            this.addFiles.Location = new System.Drawing.Point(429, 257);
            this.addFiles.Name = "addFiles";
            this.addFiles.Size = new System.Drawing.Size(75, 23);
            this.addFiles.TabIndex = 5;
            this.addFiles.Text = "Add Files";
            this.addFiles.UseVisualStyleBackColor = true;
            this.addFiles.Click += new System.EventHandler(this.addFiles_Click);
            // 
            // removeSel
            // 
            this.removeSel.Location = new System.Drawing.Point(510, 257);
            this.removeSel.Name = "removeSel";
            this.removeSel.Size = new System.Drawing.Size(113, 23);
            this.removeSel.TabIndex = 6;
            this.removeSel.Text = "Remove Selected";
            this.removeSel.UseVisualStyleBackColor = true;
            this.removeSel.Click += new System.EventHandler(this.removeSel_Click);
            // 
            // fileSelector
            // 
            this.fileSelector.Title = "Select...";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 339);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(633, 23);
            this.progress.TabIndex = 7;
            // 
            // nb
            // 
            this.nb.AutoSize = true;
            this.nb.Location = new System.Drawing.Point(6, 19);
            this.nb.Name = "nb";
            this.nb.Size = new System.Drawing.Size(139, 17);
            this.nb.TabIndex = 8;
            this.nb.Text = "No Bit Depth Reduction";
            this.nb.UseVisualStyleBackColor = true;
            // 
            // np
            // 
            this.np.AutoSize = true;
            this.np.Location = new System.Drawing.Point(303, 19);
            this.np.Name = "np";
            this.np.Size = new System.Drawing.Size(128, 17);
            this.np.TabIndex = 9;
            this.np.Text = "No Palette Reduction";
            this.np.UseVisualStyleBackColor = true;
            // 
            // nc
            // 
            this.nc.AutoSize = true;
            this.nc.Location = new System.Drawing.Point(151, 19);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(152, 17);
            this.nc.TabIndex = 10;
            this.nc.Text = "No Colour Type Reduction";
            this.nc.UseVisualStyleBackColor = true;
            // 
            // nx
            // 
            this.nx.AutoSize = true;
            this.nx.BackColor = System.Drawing.Color.Transparent;
            this.nx.Location = new System.Drawing.Point(436, 19);
            this.nx.Name = "nx";
            this.nx.Size = new System.Drawing.Size(75, 17);
            this.nx.TabIndex = 11;
            this.nx.Text = "Disable All";
            this.nx.UseVisualStyleBackColor = false;
            this.nx.CheckedChanged += new System.EventHandler(this.DisableAllLIR_CheckedChanged);
            // 
            // preserve
            // 
            this.preserve.AutoSize = true;
            this.preserve.Location = new System.Drawing.Point(6, 261);
            this.preserve.Name = "preserve";
            this.preserve.Size = new System.Drawing.Size(116, 17);
            this.preserve.TabIndex = 12;
            this.preserve.Text = "Preserve Metadata";
            this.preserve.UseVisualStyleBackColor = true;
            // 
            // fix
            // 
            this.fix.AutoSize = true;
            this.fix.Location = new System.Drawing.Point(128, 261);
            this.fix.Name = "fix";
            this.fix.Size = new System.Drawing.Size(133, 17);
            this.fix.TabIndex = 13;
            this.fix.Text = "Enable Error Recovery";
            this.fix.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nb);
            this.groupBox1.Controls.Add(this.nc);
            this.groupBox1.Controls.Add(this.nx);
            this.groupBox1.Controls.Add(this.np);
            this.groupBox1.Location = new System.Drawing.Point(6, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 45);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lossless Image Reduction";
            // 
            // optimisationLevel
            // 
            this.optimisationLevel.DisplayMember = "2";
            this.optimisationLevel.FormattingEnabled = true;
            this.optimisationLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.optimisationLevel.Location = new System.Drawing.Point(99, 37);
            this.optimisationLevel.Name = "optimisationLevel";
            this.optimisationLevel.Size = new System.Drawing.Size(37, 21);
            this.optimisationLevel.TabIndex = 15;
            // 
            // interlaceType
            // 
            this.interlaceType.FormattingEnabled = true;
            this.interlaceType.Items.AddRange(new object[] {
            "Input Type",
            "No Interlacing",
            "Interlacing"});
            this.interlaceType.Location = new System.Drawing.Point(234, 37);
            this.interlaceType.Name = "interlaceType";
            this.interlaceType.Size = new System.Drawing.Size(88, 21);
            this.interlaceType.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Optimisation Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Interlacing Type:\r\n";
            // 
            // full
            // 
            this.full.AutoSize = true;
            this.full.Enabled = false;
            this.full.Location = new System.Drawing.Point(203, 6);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(105, 17);
            this.full.TabIndex = 19;
            this.full.Text = "Full IDAT Report";
            this.full.UseVisualStyleBackColor = true;
            // 
            // simulate
            // 
            this.simulate.AutoSize = true;
            this.simulate.Location = new System.Drawing.Point(333, 39);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(104, 17);
            this.simulate.TabIndex = 20;
            this.simulate.Text = "Simulation Mode";
            this.simulate.UseVisualStyleBackColor = true;
            // 
            // logPath
            // 
            this.logPath.Enabled = false;
            this.logPath.Location = new System.Drawing.Point(51, 33);
            this.logPath.Name = "logPath";
            this.logPath.Size = new System.Drawing.Size(491, 20);
            this.logPath.TabIndex = 21;
            // 
            // logSelect
            // 
            this.logSelect.Enabled = false;
            this.logSelect.Location = new System.Drawing.Point(548, 31);
            this.logSelect.Name = "logSelect";
            this.logSelect.Size = new System.Drawing.Size(75, 23);
            this.logSelect.TabIndex = 22;
            this.logSelect.Text = "Select";
            this.logSelect.UseVisualStyleBackColor = true;
            this.logSelect.Click += new System.EventHandler(this.OpenLogFileSelectionDialog);
            // 
            // useLog
            // 
            this.useLog.AutoSize = true;
            this.useLog.Location = new System.Drawing.Point(6, 6);
            this.useLog.Name = "useLog";
            this.useLog.Size = new System.Drawing.Size(85, 17);
            this.useLog.TabIndex = 23;
            this.useLog.Text = "Use Log File";
            this.useLog.UseVisualStyleBackColor = true;
            this.useLog.CheckedChanged += new System.EventHandler(this.UseLogFile_CheckedChanged);
            // 
            // verbose
            // 
            this.verbose.AutoSize = true;
            this.verbose.Enabled = false;
            this.verbose.Location = new System.Drawing.Point(97, 6);
            this.verbose.Name = "verbose";
            this.verbose.Size = new System.Drawing.Size(100, 17);
            this.verbose.TabIndex = 24;
            this.verbose.Text = "Verbose Output";
            this.verbose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Log File:";
            // 
            // dirPath
            // 
            this.dirPath.Enabled = false;
            this.dirPath.Location = new System.Drawing.Point(56, 33);
            this.dirPath.Name = "dirPath";
            this.dirPath.Size = new System.Drawing.Size(486, 20);
            this.dirPath.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Directory:";
            // 
            // dirSelect
            // 
            this.dirSelect.Enabled = false;
            this.dirSelect.Location = new System.Drawing.Point(548, 31);
            this.dirSelect.Name = "dirSelect";
            this.dirSelect.Size = new System.Drawing.Size(75, 23);
            this.dirSelect.TabIndex = 27;
            this.dirSelect.Text = "Select";
            this.dirSelect.UseVisualStyleBackColor = true;
            this.dirSelect.Click += new System.EventHandler(this.OpenOutputDirectorySelectionDialog);
            // 
            // useDir
            // 
            this.useDir.AutoSize = true;
            this.useDir.Location = new System.Drawing.Point(6, 6);
            this.useDir.Name = "useDir";
            this.useDir.Size = new System.Drawing.Size(125, 17);
            this.useDir.TabIndex = 28;
            this.useDir.Text = "Use Output Directory";
            this.useDir.UseVisualStyleBackColor = true;
            this.useDir.CheckedChanged += new System.EventHandler(this.UseOutputDirectory_CheckedChanged);
            // 
            // nz
            // 
            this.nz.AutoSize = true;
            this.nz.Location = new System.Drawing.Point(6, 115);
            this.nz.Name = "nz";
            this.nz.Size = new System.Drawing.Size(161, 17);
            this.nz.TabIndex = 29;
            this.nz.Text = "Do not recode IDAT streams";
            this.nz.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 321);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selection);
            this.tabPage1.Controls.Add(this.fix);
            this.tabPage1.Controls.Add(this.addFiles);
            this.tabPage1.Controls.Add(this.preserve);
            this.tabPage1.Controls.Add(this.removeSel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.optipngPath);
            this.tabPage2.Controls.Add(this.optipngSelector);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.workerThreads);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.nz);
            this.tabPage2.Controls.Add(this.simulate);
            this.tabPage2.Controls.Add(this.optimisationLevel);
            this.tabPage2.Controls.Add(this.interlaceType);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Optimisation Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Worker Threads: ";
            // 
            // workerThreads
            // 
            this.workerThreads.Location = new System.Drawing.Point(99, 144);
            this.workerThreads.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.workerThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.workerThreads.Name = "workerThreads";
            this.workerThreads.Size = new System.Drawing.Size(68, 20);
            this.workerThreads.TabIndex = 30;
            this.workerThreads.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.logPath);
            this.tabPage3.Controls.Add(this.verbose);
            this.tabPage3.Controls.Add(this.useLog);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.full);
            this.tabPage3.Controls.Add(this.logSelect);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(629, 295);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logging";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 230);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Data";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(6, 19);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(605, 205);
            this.logBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dirPath);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dirSelect);
            this.tabPage4.Controls.Add(this.useDir);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(629, 295);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Output Directory";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // notification
            // 
            this.notification.AutoSize = true;
            this.notification.Location = new System.Drawing.Point(9, 373);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(85, 13);
            this.notification.TabIndex = 31;
            this.notification.Text = "Waiting for Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "OptiPNG Executable:";
            // 
            // optipngSelector
            // 
            this.optipngSelector.Location = new System.Drawing.Point(548, 9);
            this.optipngSelector.Name = "optipngSelector";
            this.optipngSelector.Size = new System.Drawing.Size(75, 23);
            this.optipngSelector.TabIndex = 33;
            this.optipngSelector.Text = "Select";
            this.optipngSelector.UseVisualStyleBackColor = true;
            this.optipngSelector.Click += new System.EventHandler(this.OpenOptiPNGSelectorDialog);
            // 
            // optipngPath
            // 
            this.optipngPath.Location = new System.Drawing.Point(117, 11);
            this.optipngPath.Name = "optipngPath";
            this.optipngPath.Size = new System.Drawing.Size(425, 20);
            this.optipngPath.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 402);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.exec);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "OptiPNG Frontend";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerThreads)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button exec;
        private System.Windows.Forms.ListView selection;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button addFiles;
        private System.Windows.Forms.Button removeSel;
        private System.Windows.Forms.OpenFileDialog fileSelector;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.CheckBox nb;
        private System.Windows.Forms.CheckBox np;
        private System.Windows.Forms.CheckBox nc;
        private System.Windows.Forms.CheckBox nx;
        private System.Windows.Forms.CheckBox preserve;
        private System.Windows.Forms.CheckBox fix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox optimisationLevel;
        private System.Windows.Forms.ComboBox interlaceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox full;
        private System.Windows.Forms.CheckBox simulate;
        private System.Windows.Forms.TextBox logPath;
        private System.Windows.Forms.Button logSelect;
        private System.Windows.Forms.CheckBox useLog;
        private System.Windows.Forms.CheckBox verbose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderSelector;
        private System.Windows.Forms.TextBox dirPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dirSelect;
        private System.Windows.Forms.CheckBox useDir;
        private System.Windows.Forms.CheckBox nz;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown workerThreads;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox optipngPath;
        private System.Windows.Forms.Button optipngSelector;
        private System.Windows.Forms.Label label5;
    }
}

