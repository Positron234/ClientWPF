
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClientWPF
{
    /// <summary>
    /// Логика взаимодействия для ClientData.xaml
    /// </summary>
    public partial class ClientData : Window
    {
        public ClientData(string URL)
        {
            InitializeComponent();
            DataContext=new ViewModelFactories(URL);
        }
    }
}
