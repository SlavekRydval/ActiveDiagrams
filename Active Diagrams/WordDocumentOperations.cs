using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace Active_Diagrams
{
    public static class WordDocumentOperations
    {
        public static Word.Document Document { get { return Globals.ThisAddIn.Application.ActiveDocument; } }

        //11 == Office 2003
        //12 == Office 2007
        //13 == nic
        //14 == Office 2010
        //15 == Office 2013
        //16 == Office 2016
        //for more information see https://en.wikipedia.org/wiki/Microsoft_Word, chapter Release History
        public static bool IsOldDocVersion() => Document.CompatibilityMode < 14;


        public static void UpdateImage(Word.InlineShape sh, DiagramIdentification di, WordEAInterface WordEA)
        {
            sh.LinkFormat.SourceFullName = WordEA.GetFileName(di.GUID);
            sh.LinkFormat.Update();

            if (!WordDocumentOperations.IsOldDocVersion())
            {
                float FactualWidht = sh.ScaleWidth == 0 ? sh.Width : (100 / sh.ScaleWidth) * sh.Width;
                float FactualHeight = sh.ScaleHeight == 0 ? sh.Height : (100 / sh.ScaleHeight) * sh.Height;
                float PageWidth = sh.Range.PageSetup.PageWidth - sh.Range.PageSetup.RightMargin - sh.Range.PageSetup.LeftMargin;
                float PageHeight = sh.Range.PageSetup.PageHeight - sh.Range.PageSetup.TopMargin - sh.Range.PageSetup.BottomMargin;
                float ScaleWidth = (FactualWidht > PageWidth) ? ScaleWidth = 100 / (FactualWidht / PageWidth) : 100;
                float ScaleHeight = (FactualHeight > PageHeight) ? ScaleHeight = 100 / (FactualWidht / PageHeight) : 100;

                sh.ScaleWidth = Math.Min(ScaleWidth, ScaleHeight);
                sh.ScaleHeight = Math.Min(ScaleWidth, ScaleHeight);
            }

            di.SetValues(WordEA.GetDiagram(di.GUID));
            di.WordModifiedDate = DateTime.Now;

            sh.AlternativeText = di.ToString();
        }


        public static Task<bool> RefreshDiagramsAsync(WordEAInterface WordEA, BackgroundWorker worker = null)
        {
            Func<WordEAInterface, BackgroundWorker, bool> f;
            f = new Func<WordEAInterface, BackgroundWorker, bool>(RefreshDiagrams);           

            //return Task.Run(() => f(WordEA, worker));

            return Task.Factory.StartNew(() => f(WordEA, worker), 
                                         CancellationToken.None, 
                                         TaskCreationOptions.DenyChildAttach,
                                         TaskScheduler.FromCurrentSynchronizationContext());


            //Task.Run(() => new Func<WordEAInterface, BackgroundWorker, bool>(RefreshDiagrams)(WordEA, worker))
            //return Task.Run(() => new Func<WordEAInterface, BackgroundWorker, bool>(RefreshDiagrams)(WordEA, worker));
            //return Task.Factory.StartNew(() => new Func<WordEAInterface, BackgroundWorker, bool>(RefreshDiagrams)(WordEA, worker), 
            //    CancellationToken.None, 
            //    TaskCreationOptions.None,
            //    TaskScheduler.FromCurrentSynchronizationContext());
        }

        public static bool RefreshDiagrams(WordEAInterface WordEA, BackgroundWorker worker = null)
        {
            int OverallSteps = Document.InlineShapes.Count + 1; //plus 1 for RefreshRepository
            int StepsDone = 0;

            try
            {
                worker?.ReportProgress(0, "Reloading EA repository");
                WordEA.RefreshEARepository();
                worker?.ReportProgress((100 * ++StepsDone) / OverallSteps, "Repository reloaded. Searching for a diagram...");

                int vDiagramsCount = 0;
                int vDeletedDiagrams = 0;

                foreach (Word.InlineShape sh in Document.InlineShapes)
                {
                    if (worker?.CancellationPending == true)
                        return true;

                    if (!DiagramIdentification.IsDiagramIdentification(sh.AlternativeText))
                    {
                        worker?.ReportProgress((100 * ++StepsDone) / OverallSteps, "Searching for a diagram...");
                        continue;
                    }

                    DiagramIdentification di = new DiagramIdentification(sh.AlternativeText);
                    worker?.ReportProgress((100 * StepsDone) / OverallSteps, $"Updating {di.Name} ({di.GUID})");
                    if (WordEA.SaveDiagramIntoFile(di.GUID))
                    {
                        UpdateImage(sh, di, WordEA);
                        vDiagramsCount++;
                    }
                    else
                    {
                        vDeletedDiagrams++;
                    }

                    worker?.ReportProgress((100 * ++StepsDone) / OverallSteps, "");
                }

                worker?.ReportProgress(100, "Done.");

                string vReport = $"{vDiagramsCount} diagrams were reloaded.";
                if (vDeletedDiagrams > 0)
                    vReport += $"\n{vDeletedDiagrams} diagrams were probably removed from the EA repository (in this document they were left as they are).";

                
                if (worker == null)
                    MessageBox.Show(vReport, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    worker.ReportProgress(100, vReport);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot refresh digrams in the document. Error description: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }


    }
}
