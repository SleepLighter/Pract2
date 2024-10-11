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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

        }
        private void Menu_click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
        Random R = new Random();

        string a;
        private void Action_TextChanged(object sender, TextChangedEventArgs e)
        {
            a = Action.Text;
        }

        double operand1;
        double operand2;
        private void Variables_click(object sender, RoutedEventArgs e)
        {
            FirstNum.Text = Convert.ToString(R.Next(-1000000, 1000000));
            operand1 = Convert.ToInt32(FirstNum.Text);
            SecondNum.Text = Convert.ToString(R.Next(-1000000, 1000000));
            operand2 = Convert.ToInt32(SecondNum.Text);
        }
        double rez = 0;
        private void Go_click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (a)
                {
                    case "+":
                        rez = operand1 + operand2;
                        Result.Text = Convert.ToString(rez);
                        break;
                    case "-":
                        rez = operand2 - operand1;
                        Result.Text = Convert.ToString(rez);
                        break;
                    case "*":
                        rez = operand1 * operand2;
                        Result.Text = Convert.ToString(rez);
                        break;
                    case "/":
                        rez = operand2 / operand1;
                        Result.Text = Convert.ToString(rez);
                        break;
                    default:
                        Result.Text = "Увы";
                        break;
                }
            }
            catch
            {
                Result.Text = "Увы и ах";
            }
        }
    }
}
