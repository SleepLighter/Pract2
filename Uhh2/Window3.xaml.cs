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
using System.Windows.Shapes;

namespace Uhh2
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void Menu_click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
        private void Numbers_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(Numbers.Text);
                if (0 <= num && num <= 14)
                {
                    Intervals.Text = "Вы попали в интервал 0-14";
                }
                else if (15 <= num && num <= 35)
                {
                    Intervals.Text = "Вы попали в интервал 15-35";
                }
                else if (36 <= num && num <= 50)
                {
                    Intervals.Text = "Вы попали в интервал 36-50";
                }
                else if (50 <= num && num <= 100)
                {
                    Intervals.Text = "Вы попали в интервал 50-100";
                }
                else
                {
                    Intervals.Text = "Попробуйте ввести число от 0 до 100";
                }
            }
            catch
            {
                Intervals.Text = "Введите число от 0 до 100.";
            }
        }
    }
}
