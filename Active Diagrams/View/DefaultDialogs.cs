namespace Active_Diagrams.View
{
    class DefaultDialogs : IDialogs
    {
        public void ShowAbout()
        {
            (new View.About()).ShowDialog();
        }

        public void OpenWebBrowser(string URI)
        {
            System.Diagnostics.Process.Start(URI);
        }
    }
}
