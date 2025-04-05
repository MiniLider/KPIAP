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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Rasprod.xaml
    /// </summary>
    public partial class Rasprod : Window
    {
        public List<Tour> TourList { get; set; }
        public Rasprod()
        {
            InitializeComponent();
            TourList = new List<Tour>
            {
                new Tour { Country = "Италия", Description = "Погружение в культуру и кухню", Price = "250€" },
                new Tour { Country = "Испания", Description = "Солнечные пляжи и живая ночь", Price = "300€" },
                new Tour { Country = "Греция", Description = "Исторические памятники и красивейшие острова", Price = "280€" },
                new Tour { Country = "Франция", Description = "Романтика Парижа и вкусная кухня", Price = "350€" },
                new Tour { Country = "Турция", Description = "Солнце, море и отличные курорты", Price = "220€" }
            };

            DataContext = this;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }

    public class Tour
    {
        public string Country { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }

   
}
