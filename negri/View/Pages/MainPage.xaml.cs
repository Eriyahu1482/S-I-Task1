using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp3;
using static negri.Core.Core;

namespace negri.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task1());
        }
    }
}
