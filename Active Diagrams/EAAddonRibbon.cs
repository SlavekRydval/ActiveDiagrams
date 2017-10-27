using System;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

//
//
// Editor for icons: http://www.xiconeditor.com/ 
//
//


namespace Active_Diagrams
{
    public partial class EAAddonRibbon
    {

        WordEAInterface WordEA = new WordEAInterface();

        private void EAAddonRibbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void EAAddonRibbon_Close(object sender, EventArgs e)
        {
            WordEA.CloseEARepository();
            WordEA.ExitRepository();
        }


        private string GetAndSetEAPConnectionStringForm()
        {
            //pokud už nějaký řetězec byl zadán, podívám se, zda jsem již nějaký obrázek nevložil. 
            //Pokud ano, zeptám se, zda je to opravdu záměr. 
            string s = WordEA.EAPConnectionString;
            if (s != null && s.Length > 0)
            {
                foreach (Word.InlineShape sh in Globals.ThisAddIn.Application.ActiveDocument.InlineShapes)
                {
                    if (DiagramIdentification.IsDiagramIdentification(sh.AlternativeText))
                    {
                        if (MessageBox.Show("You are about to change the location of the repository although"+
                                            " at least one diagram in this document reffers to the current"+
                                            " repository. Are you sure you want to do it?", 
                                            "Are you sure?", MessageBoxButtons.YesNoCancel, 
                                            MessageBoxIcon.Question) != DialogResult.Yes)
                            return s;
                        break;
                    }
                }
            }

            frmGetEAPFile f = new frmGetEAPFile();
            
            if (f.getEARepository(ref s) == DialogResult.OK)
            {
                WordEA.EAPConnectionString = s;
                return s;
            }
            return "";
        }

        private bool ExistsEAPConnectionString() => (WordEA.EAPConnectionString != "") || (GetAndSetEAPConnectionStringForm() != "");

        private void btnLinkWithEAP_Click(object sender, RibbonControlEventArgs e) => GetAndSetEAPConnectionStringForm();
        
        private void btnAddDiagram_Click(object sender, RibbonControlEventArgs e)
        {
            if (!ExistsEAPConnectionString())
                return;

            frmSelectDiagram ff = new frmSelectDiagram();
            ff.Repository = WordEA;
            if (ff.SelectDiagram() != DialogResult.OK)
                return;

            try
            {
                WordEA.OpenEARepository();
                if (!WordEA.SaveDiagramIntoFile(ff.SelectedDiagramGUID))
                {
                    MessageBox.Show("Cannot save a diagram into a file. Check if the GUID is correct.");
                    return;
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot get a selected diagram. Error description: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                EADiagram Diagram = WordEA.GetDiagram(ff.SelectedDiagramGUID);

                Word.InlineShape ish;
                ish = Globals.ThisAddIn.Application.ActiveDocument.InlineShapes.AddPicture(WordEA.GetFileName(ff.SelectedDiagramGUID), true, true);
                ish.AlternativeText = (new DiagramIdentification(Diagram, DateTime.Now, DateTime.MinValue)).ToString();
                try
                {
                    ish.LockAspectRatio = Microsoft.Office.Core.MsoTriState.msoCTrue;
                }
                catch (Exception) //neřeším... výjimku to háže u starší verze dokumentu
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot insert a diagram into the document. Error description: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        frmProcessRefresh frmRefresher = null;

        async private void btnRefresh_Click(object sender, RibbonControlEventArgs e)
        {
            if (!ExistsEAPConnectionString())
                return;

            if (WordDocumentOperations.IsOldDocVersion())
                MessageBox.Show("Your document is saved in older format. To achieve better results with Active Diagrams save it in actual format.");

            
            try
            {
                //Cursor.Current = Cursors.WaitCursor;
                Application.UseWaitCursor = true;
                System.Threading.SynchronizationContext.SetSynchronizationContext(new WindowsFormsSynchronizationContext());
                bool b = await WordDocumentOperations.RefreshDiagramsAsync(WordEA);
            }
            finally
            {
                //Cursor.Current = Cursors.Default;
                Application.UseWaitCursor = false;
            }
            
            /*
            if (frmRefresher == null)
            {
                frmRefresher = new frmProcessRefresh();
                System.Threading.SynchronizationContext.SetSynchronizationContext(new WindowsFormsSynchronizationContext());
            }

            frmRefresher.WordEA = WordEA;
            frmRefresher.ShowDialog();
            */
        }

        private void btnAbout_Click(object sender, RibbonControlEventArgs e) => (new View.About()).ShowDialog();

        private void cbShowTaskPane_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.adCustomTaskPane.Visible = cbShowTaskPane.Checked;
        }

        private void btnOpenRepositoryInEA_Click(object sender, RibbonControlEventArgs e)
        {
            if (!ExistsEAPConnectionString())
                return;
            try
            {
                System.Diagnostics.Process.Start(WordEA.EAPConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnOpenHomepage_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("http://odkazy.rydval.cz/activediagrams");
        }
    }
}
