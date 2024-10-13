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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public string Password { get; set; }
        public Window4()

        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "12345")
            {
                MessageBox.Show("Welcome " + tbUsername.Text);
            }
            else
            {
                MessageBox.Show("Неверный пароль. Попробуйте ещё раз");
            }

        }
        private void Menu_click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "Password")
            {
                MessageBox.Show("'Password' is not allowed as a password.");
            }
            else
            {
                
            }
        }
    }
}
