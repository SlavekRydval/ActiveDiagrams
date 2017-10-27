using Microsoft.Win32;
using System;
using System.Windows.Forms;


namespace Active_Diagrams
{
    public partial class frmGetEAPFile : Form
    {
        public frmGetEAPFile()
        {
            InitializeComponent();
        }

        public DialogResult getEARepository (ref string Value)
        {
            DialogResult dr;

            cbEARepository.Text = Value;
            cbEARepository_TextChanged(null, null);

            dr = ShowDialog();
            if (dr == DialogResult.OK)
               Value = cbEARepository.Text;
            return dr;
        }

        const string RecentFilesRegistryKey = @"Software\Sparx Systems\EA400\EA\Recent File List";

        private void frmGetEAPFile_Load(object sender, EventArgs e)
        {
            cbEARepository.Items.Clear();

            for (int i = 1; i <= 10; i++)
                try
                {
                    cbEARepository.Items.Add ((string)Registry.CurrentUser.OpenSubKey(RecentFilesRegistryKey).GetValue($"File{i}"));
                }
                catch
                {
                }
        }

        private void cbEARepository_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (cbEARepository.Text != "");
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            if (ofdEAP.ShowDialog() == DialogResult.OK)
                cbEARepository.Text = ofdEAP.FileName;
        }

        private void btnConnectionString_Click(object sender, EventArgs e)
        {
            /*
            DataConnectionDialog dcd = new DataConnectionDialog();
            DataConnectionConfiguration dcs = new DataConnectionConfiguration(null);
            dcs.LoadConfiguration(dcd);
            if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
                cbEARepository.Text = dcd.ConnectionString;
                */
        }
    }
}
