using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace negri.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task3.xaml
    /// </summary>
    public partial class Task3 : Page
    {
        public Task3()
        {
            InitializeComponent();
        }
        public void BTN3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double k = Convert.ToDouble(TBk.Text);
                double y = Convert.ToDouble(TBy2.Text);
                MessageBox.Show($"", "задание 1.2",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.2",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
    }
}
