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
    
    {
        Dictionary<string, string> translations = new Dictionary<string, string>
            {
            { "солнце", "sun" },
            { "дождь", "rain" },
            { "снег", "snow" },
            { "ветер", "wind" },
            { "облако", "cloud" },
            { "туман", "fog" },
            { "град", "hail" },
            { "мороз", "frost" },
            { "гром", "thunder" },
            { "молния", "lightning" }
        };

        Console.WriteLine("Введите слово на русском языке:");
        string input = Console.ReadLine();

        if (translations.ContainsKey(input))
        {
            Console.WriteLine("Перевод: " + translations[input]);
        }
        else
        {
            Console.WriteLine("Такого слова нет.");
        }
}
