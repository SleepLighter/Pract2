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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> Weather = new Dictionary<string, string>()
        {
            { "погода", "weather"},
            { "туман","fog" },
            { "солнечно", "sunny"},
            { "пасмурно", "cloudy"},
            { "ветрено", "wind" },
            { "дождливо","rainy" },
            { "снегопад","snowfall" },
            { "безветренная", "calm" },
            { "град","hail" },
            { "ураган", "hurricane"},


        };

        string s = "";
        private void Rus1_TextChanged(object sender, TextChangedEventArgs e)
        {
            s = Rus1.Text;
        }
        private void Trans_click(object sender, RoutedEventArgs e)
        {
            try
            {
                string w = s.ToLower();
                Eng2.Text = Weather[w];
            }
            catch
            {
                Eng2.Text = "Увы";
            }
        }
        private void Menu_click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
    }
}