using System;
using DevExpress.Mvvm;
using System.Threading.Tasks;

namespace T372965.ViewModels {
    public class ViewModel1 : ViewModelBase {
        public AsyncCommand AsyncCommand { get; set; }
        public ViewModel1() {
            AsyncCommand = new AsyncCommand(Calculate);
        }
        private async Task Calculate() {
            try {
                await somethingAsync();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        private Task somethingAsync() {
            throw new InvalidOperationException();
        }
    }
}