using Microsoft.Office.Tools;
using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace Active_Diagrams
{
    public partial class ThisAddIn
    {
        private DiagramInfoTaskPane adTaskPaneControl = new DiagramInfoTaskPane();
        public CustomTaskPane adCustomTaskPane = null;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            Globals.ThisAddIn.Application.WindowSelectionChange += Application_WindowSelectionChange;

            adCustomTaskPane = this.CustomTaskPanes.Add(adTaskPaneControl, "Active Diagrams");
            adCustomTaskPane.DockPosition = Properties.Settings.Default.ADTaskPaneDockPosition;

            if (adCustomTaskPane.DockPosition == Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionFloating)
            {   //šířku a výšku nelze nastavovat v případě, že je okno zadokované
                //bohužel nelze jednoduše nastavit i top a left, zatím to tedy nechám 
                //bez odezvy, ačkoliv mě to sere, řešení zřejmě viz class NativeMethods
                adCustomTaskPane.Height = Properties.Settings.Default.ADTaskPaneHeight;
                adCustomTaskPane.Width = Properties.Settings.Default.ADTaskPaneWidth;
            }

            //nejprve nastavím viditelnost a až poté událost na změnu viditelnosti.
            //je to z toho důvodu, že v té události se dotazuji na EARibbon, který zde
            //ještě není vytvořen
            adCustomTaskPane.Visible = Properties.Settings.Default.ADTaskPaneVisible;
            adCustomTaskPane.VisibleChanged += AdCustomTaskPane_VisibleChanged;
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void AdCustomTaskPane_VisibleChanged(object sender, EventArgs e)
        {
            getEARibbon().cbShowTaskPane.Checked = adCustomTaskPane.Visible;
            Properties.Settings.Default.ADTaskPaneVisible = adCustomTaskPane.Visible;
        }

        EAAddonRibbon getEARibbon()
        {
            foreach (var Ribbon in Globals.Ribbons)
                if (Ribbon is EAAddonRibbon)
                    return (EAAddonRibbon)Ribbon;
            return null;
        }

        private static string DT2String(DateTime dt) => (dt == DateTime.MinValue) ? "" : dt.ToString();

        private void Application_WindowSelectionChange(Word.Selection Sel)
        {
            adTaskPaneControl.dgvDiagramInfo.Rows.Clear();
            if (Sel.InlineShapes.Count == 1)
            {
                if (DiagramIdentification.IsDiagramIdentification(Sel.InlineShapes[1].AlternativeText))
                    try
                    {
                        DiagramIdentification di = new DiagramIdentification(Sel.InlineShapes[1].AlternativeText);

                        adTaskPaneControl.dgvDiagramInfo.Rows.Add("Name", di.Name);
                        adTaskPaneControl.dgvDiagramInfo.Rows.Add("Type", di.Type);
                        adTaskPaneControl.dgvDiagramInfo.Rows.Add("Stereotype", di.Stereotype);
                        adTaskPaneControl.dgvDiagramInfo.Rows.Add("GUID", di.GUID);
                        adTaskPaneControl.dgvDiagramInfo.Rows.Add("Author of Diagram", di.Author);
                        adTaskPaneControl.dgvDiagramInfo.Rows.Add("EA Creation Date", DT2String(di.EACreatedDate));
                        adTaskPaneControl.dgvDiagramInfo.Rows.Add("EA Modification Date", DT2String(di.EAModifiedDate));
                        adTaskPaneControl.dgvDiagramInfo.Rows.Add("Created in Document", DT2String(di.WordCreatedDate));
                        adTaskPaneControl.dgvDiagramInfo.Rows.Add("Lastly Updated in Document", DT2String(di.WordModifiedDate));
                        adTaskPaneControl.dgvDiagramInfo.Rows.Add("Internal Version", di.Version);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                {
                    adTaskPaneControl.dgvDiagramInfo.Rows.Add("Info", "Not an Active Diagram image.");
                }
            }
        }
        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }

    /*
    public class NativeMethods
    {
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "FindWindowW")]
        public static extern System.IntPtr FindWindowW([System.Runtime.InteropServices.InAttribute()]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string
        lpClassName, [System.Runtime.InteropServices.InAttribute()]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string
        lpWindowName);


        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "MoveWindow")]
        [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public static extern bool MoveWindow([System.Runtime.InteropServices.InAttribute()]
        System.IntPtr hWnd, int X, int Y, int nWidth, int nHeight,
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool
        bRepaint);
    }

    /*
    IntPtr ptr = NativeMethods.FindWindowW("MsoCommandBar", "My Task Pane");
    NativeMethods.MoveWindow(ptr, 400, 220, 240, 360, true);
    */
}
