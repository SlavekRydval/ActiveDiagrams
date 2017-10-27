using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace Active_Diagrams
{
    public partial class frmProcessRefresh : Form
    {
        private BackgroundWorker Refresher = null;

        public WordEAInterface WordEA = null; ///TODO JTS zm21nit na property nebo jako parametr 

        public frmProcessRefresh()
        {
            InitializeComponent();
            Refresher = new BackgroundWorker();
            Refresher.WorkerReportsProgress = true;
            Refresher.WorkerSupportsCancellation = true;
            Refresher.DoWork += Refresher_DoWork;
            Refresher.RunWorkerCompleted += Refresher_RunWorkerCompleted;
            Refresher.ProgressChanged += Refresher_ProgressChanged;
        }


        private void frmProcessRefresh_Shown(object sender, EventArgs e)
        {
            UpdateGUI(0, "Reloading EA repository...");
            WordEA.PrepareForThreadRefresh();
            Refresher.RunWorkerAsync();
        }


        private void UpdateGUI(int value, string label = "", bool Done = false)
        {
            pbProgress.Value = value;
            label1.Text = label;
            btnCancel.Text = Done ? "OK" : "Cancel";
            
        }

        private void Refresher_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Cancel = WordDocumentOperations.RefreshDiagrams(WordEA, sender as BackgroundWorker);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Refresher.WorkerSupportsCancellation)
            {
                Refresher.CancelAsync();
            }
        }

        private void Refresher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string msg = (string) e.UserState;

            if (InvokeRequired)
                Invoke(new Action<int, string, bool>(UpdateGUI), e.ProgressPercentage, msg, false);
            else
                UpdateGUI(e.ProgressPercentage, msg);
        }

        private void Refresher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string msg = e.Error == null ? e.Cancelled ? "Canceled" : "Done" : e.ToString();

            if (InvokeRequired)
                Invoke(new Action<int, string, bool>(UpdateGUI), 100, msg, true);
            else
                UpdateGUI(100, msg, true);
        }

    }
}
