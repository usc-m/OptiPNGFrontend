using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OptipngFrontend
{
    class ThreadDataBundle
    {
        public string InputPath { get; protected set; }
        public string OutputPath { get; protected set; }
        public int ID { get; protected set; }
        public ListViewItem AssociatedListItem { get; protected set; }
        public string TempFileName { get; protected set; }
        public string TempOutputFileName { get; protected set; }

        public string ExecutionStandardOutput { get; protected set; }
        public string ExecutionStandardError { get; protected set; }

        public void SetStandardOutput(string stdout) { ExecutionStandardOutput = stdout; }
        public void SetStandardError(string stderr) { ExecutionStandardError = stderr; }

        public ThreadDataBundle(string input, string output, int id, ListViewItem assocItem, string tmpFile, string tmpOFile)
        {
            InputPath = input;
            OutputPath = output;
            ID = id;
            AssociatedListItem = assocItem;
            TempFileName = tmpFile;
            TempOutputFileName = tmpOFile;
        }
    }
}
