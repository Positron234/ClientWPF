using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Threading;
using System.Windows.Input;
using System.Collections;
using System.Windows;

namespace ClientWPF
{
    
   
    internal class ViewModelFactories : BaseViewModel
    {
        object type1;
        public ObservableCollection<Factories> Coll
        {
            get
            {

                ObservableCollection<Factories> obj = this.coll.obj;
                return obj;

            }
        }
        string type;
        private string _Host = "http://localhost:1234/";
        Collection<Factories> coll = new Collection<Factories>();
        private ICommand _SaveCommand;
        public ICommand SaveCommand => new RelayCommand(sender => Save());
        private ICommand _ConnectCommand;
        public ICommand ConnectCommand => new RelayCommand(sender => {Coll.Clear(); Connect(); });
        public ViewModelFactories(string host)
        {
            type = host;
            _Host += host;
            Connect();
        }
        private async Task Save()
        {
            using (var client = new HttpClient())
            {
                StringContent con = new StringContent(coll.SaveData());
                var response = await client.PostAsync(_Host,con);
                var content = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show(content, "Saving", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private async Task Connect()
        {
            using (var client = new HttpClient())
            {
                
                var response = await client.GetAsync(_Host);
                var content = response.Content.ReadAsStringAsync().Result;
                coll.GetData(content);
                OnPropertyChanged(nameof(Coll));
            }
        }
    }
}
