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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }
        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double f = Convert.ToDouble(TBf.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"G={(Math.Exp(2 * y) + Math.Sin(f)) / Math.Log10(3.8 * y + f)}", " задание 1.1",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
            catch 
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่","задание 1.1",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
    }
}
