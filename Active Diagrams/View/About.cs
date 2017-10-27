using System.Windows.Forms;

namespace Active_Diagrams.View
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            ucAbout.FormsWindow = this;
            ucAbout.DataContext = new ViewModel.ApplicationMetadata();
        }
    }
}
