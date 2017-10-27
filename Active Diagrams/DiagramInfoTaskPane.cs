using Microsoft.Win32;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Active_Diagrams
{
    public partial class DiagramInfoTaskPane : UserControl
    {
        public DiagramInfoTaskPane()
        {
            InitializeComponent();
        }

        private void tmrAd_Tick(object sender, EventArgs e)
        {
            if (lblQuestion1.Visible)
            {
                lblQuestion2.Visible = true;
                lblQuestion1.Visible = false;
            }
            else if (lblQuestion2.Visible)
            {
                lblAnswer.Visible = true;
                lblQuestion2.Visible = false;
            }
            else //if (lblAnswer.Visible)
            {
                lblQuestion1.Visible = true;
                lblAnswer.Visible = false;
            }
        }

        private void DiagramInfoTaskPane_Load(object sender, EventArgs e)
        {
            lblQuestion1.Visible = false;
            lblQuestion2.Visible = false;
            lblAnswer.Visible = false;

            lblURL.Top = lblURL.Parent.Height - lblURL.Height - 2;
            lblURL.Left = lblURL.Parent.Width - lblURL.Width - 1;

            //reklamu vypnu pouze pro nonCZ a nonSK uživatele nebo když existuje správný klíč v registrech
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Slávek Rydval\Active Diagrams\");
            if ((CultureInfo.InstalledUICulture.TwoLetterISOLanguageName.ToLower() != "cs" &&
                CultureInfo.InstalledUICulture.TwoLetterISOLanguageName.ToLower() != "sk" &&
                CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLower() != "cs" &&
                CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLower() != "sk" &&
                CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToLower() != "cs" &&
                CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToLower() != "sk")
                ||
                ((rk != null) && rk.GetValue("ShowAds", "").ToString().ToLower() == "no")
                )
            {
                splitContainer1.Panel2Collapsed = true;
                tmrAd.Enabled = false;
            }
        }

        private void splitContainerAd_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.kurzy-uml.cz");
        }

        private void DiagramInfoTaskPane_Resize(object sender, EventArgs e)
        {
            ///Tohle chce vysvětlit, proč je to v try, na úvod to padalo, ale zjisti, proč, 
            ///třeba mám něco blbě
            ///JTS
            try
            {
                Properties.Settings.Default.ADTaskPaneHeight = Globals.ThisAddIn.adCustomTaskPane.Height;
                Properties.Settings.Default.ADTaskPaneWidth = Globals.ThisAddIn.adCustomTaskPane.Width;
                Properties.Settings.Default.ADTaskPaneDockPosition = Globals.ThisAddIn.adCustomTaskPane.DockPosition;
            }
            catch (Exception)
            {
            }
        }

        private void dgvDiagramInfo_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Properties.Settings.Default.ADTaskPaneColumnPropertyWidth = dgvDiagramInfo.Columns[0].Width;
        }
    }
}
