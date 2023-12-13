
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientWPF
{
    internal class ViewModel
    {
        private ICommand _FactoryCommand;
        public ICommand FactoryCommand => new RelayCommand(sender => {ClientData client=new ClientData("Factory"); client.Show(); });
        private ICommand _TanksCommand;
        public ICommand TanksCommand => new RelayCommand(sender => { ClientTanks client = new ClientTanks("Tank"); client.Show(); });
        private ICommand _UnitsCommand;
        public ICommand UnitsCommand => new RelayCommand(sender => { ClientData client = new ClientData("Unit"); client.Show(); });
    }
}
