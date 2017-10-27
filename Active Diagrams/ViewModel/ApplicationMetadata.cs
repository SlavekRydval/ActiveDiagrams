namespace Active_Diagrams.ViewModel
{
    public class ApplicationMetadata
    {
        private Model.ApplicationMetadata _modelApplicationMetadata;

        public ApplicationMetadata()
        {
            _modelApplicationMetadata = new Model.ApplicationMetadata();
        }

        public string Version { get { return $"Version: {_modelApplicationMetadata.MajorVersion}.{_modelApplicationMetadata.MinorVersion} (revision {_modelApplicationMetadata.Revision})"; } }
        public string AddinWebPage { get => "http://blok.kurzy-uml.cz/active-diagrams/"; } //http://odkazy.rydval.cz/ActiveDiagrams
        public string AuthorHomepage { get => "http://www.rydval.cz"; }
        public string AuthorEmail { get => "slavek@rydval.cz"; }
        public string AuthorEmailAsHyperlink { get => $"mailto:{AuthorEmail}"; }
        public string GitHubURL { get => "https://github.com/SlavekRydval/ActiveDiagrams"; }
        public string MITLicenceURL { get => "https://en.wikipedia.org/wiki/MIT_License"; }
    }


}
