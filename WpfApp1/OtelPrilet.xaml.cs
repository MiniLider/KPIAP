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
    /// Логика взаимодействия для OtelPrilet.xaml
    /// </summary>
    public partial class OtelPrilet : Window
    {
        public OtelPrilet()
        {
            InitializeComponent();
            InitializeHotelData();
        }

        private Dictionary<string, List<string>> cityHotels;

        private void InitializeHotelData()
        {
            cityHotels = new Dictionary<string, List<string>>
            {
                {"Москва", new List<string> { "Отель Лилия", "Отель Бурундук", "Отель Зима" }},
                {"Шанхай", new List<string> { "Отель Чибаль", "Отель ДинДон", "Отель Ей" }},
                {"Нью-Дели", new List<string> { "Отель Ганг", "Отель Шанши", "Отель Ихши" }}
            };
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            string city = CityTextBox.Text;

            if (cityHotels.ContainsKey(city))
            {
                HotelsListBox.ItemsSource = cityHotels[city];
            }
            else
            {
                MessageBox.Show("Отели не найдены для данного города.");
                HotelsListBox.ItemsSource = null;
            }
        }

        private void HotelsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (HotelsListBox.SelectedItem != null)
            {
                string selectedHotel = HotelsListBox.SelectedItem.ToString();
                if(HotelsListBox.SelectedItem == "Отель Лилия")
                {
                    HotelInfoTextBox.Text = $"Информация об {selectedHotel}: отель имеет 4 звезды. Доступ к морю. Включены завтрак, обед и ужин. Подойдет для всей семьи";
                }
                if (HotelsListBox.SelectedItem == "Отель Бурундук")
                {
                    HotelInfoTextBox.Text = $"Информация об {selectedHotel}: отель имеет 3 звезды. Нет доступа к морю. Включены завтрак, обед и ужин. Подойдет для всей семьи";
                }
                if (HotelsListBox.SelectedItem == "Отель Зима")
                {
                    HotelInfoTextBox.Text = $"Информация об {selectedHotel}: отель имеет 3.5 звезды. Нет доступа к морю. Включены завтрак, обед и ужин. Подойдет для всей семьи";
                }
                if (HotelsListBox.SelectedItem == "Отель Чибаль")
                {
                    HotelInfoTextBox.Text = $"Информация об {selectedHotel}: отель имеет 4.5 звезды. Нет доступа к морю. Включены обед и ужин. Подойдет для всей семьи";
                }
                if (HotelsListBox.SelectedItem == "Отель ДинДон")
                {
                    HotelInfoTextBox.Text = $"Информация об {selectedHotel}: отель имеет 4 звезды. Нет доступа к морю. Включены завтрак и ужин. Подойдет для всей семьи";
                }
                if (HotelsListBox.SelectedItem == "Отель Ей")
                {
                    HotelInfoTextBox.Text = $"Информация об {selectedHotel}: отель имеет 5 звезд. Нет доступа к морю. Включены завтрак, обед и ужин. Подойдет для всей семьи";
                }
                if (HotelsListBox.SelectedItem == "Отель Ганг")
                {
                    HotelInfoTextBox.Text = $"Информация об {selectedHotel}: отель имеет 2.5 звезды. Есть доступа к морю. Включены завтрак и ужин. Подойдет для всей семьи";
                }
                if (HotelsListBox.SelectedItem == "Отель Шанши")
                {
                    HotelInfoTextBox.Text = $"Информация об {selectedHotel}: отель имеет 3 звезды. ЕСть доступ к морю. Включены завтрак, обед и ужин. Подойдет для всей семьи";
                }
                if (HotelsListBox.SelectedItem == "Отель Ихши")
                {
                    HotelInfoTextBox.Text = $"Информация об {selectedHotel}: отель имеет 4 звезды. Нет доступа к морю. Включен только завтрак. Подойдет для всей семьи";
                }

               

            }
        }
        private void Bback0_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрыть текущее окно
        }
    }
}
