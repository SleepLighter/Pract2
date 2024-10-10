using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uhh2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Translator_click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.Show();
            this.Close();
        }

        private void Calculator_click(object sender, RoutedEventArgs e)
        {
            Window2 b = new Window2();
            b.Show();
            this.Close();
        }

        private void Numbers_click(object sender, RoutedEventArgs e)
        {
            Window3 c = new Window3();
            c.Show();
            this.Close();
        }

        private void Login_click(object sender, RoutedEventArgs e)
        {
            Window4 d = new Window4();
            d.Show();
            this.Close();
        }
    }
}