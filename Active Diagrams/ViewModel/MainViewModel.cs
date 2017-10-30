using Active_Diagrams.View;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active_Diagrams.ViewModel
{
    class MainViewModel
    {
        private readonly IDialogs dialogs;

        public RelayCommand cmdAbout;
        public RelayCommand <string>cmdOpenWebBrowser;


        public MainViewModel(IDialogs Dialogs) {
            dialogs = Dialogs;

            cmdAbout = new RelayCommand(() => { dialogs.ShowAbout(); });
            cmdOpenWebBrowser = new RelayCommand<string>((URI) => { dialogs.OpenWebBrowser(URI); });
        }






    }
}
