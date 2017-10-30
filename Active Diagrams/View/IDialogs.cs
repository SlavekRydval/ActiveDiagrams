namespace Active_Diagrams.View
{
    internal interface IDialogs
    {
        /// <summary>
        /// Shows About dialog
        /// </summary>
        void ShowAbout();

        /// <summary>
        /// Opens default web browser with given URI
        /// </summary>
        /// <param name="URI">URI to be opened</param>
        void OpenWebBrowser(string URI);


    }
}
