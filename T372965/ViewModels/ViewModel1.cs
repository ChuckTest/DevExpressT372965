using System;
using DevExpress.Mvvm;
using System.Threading.Tasks;
using System.Windows;

namespace T372965.ViewModels {
    public class ViewModel1 : ViewModelBase {
        public AsyncCommand AsyncCommand { get; set; }
        public ViewModel1() {
            AsyncCommand = new AsyncCommand(() => Task.Run(new Action(Calculate)));
        }

        private async void Calculate() 
        {
            await Task.Delay(5000);
            MessageBox.Show("test");
        }

    }
}