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
    /// Логика взаимодействия для Zaiti.xaml
    /// </summary>
    /// 
    public partial class Zaiti : Window
    {

        // Пример класса для хранения информации о бронировании
        public class Booking
        {
            public string HotelName { get; set; }
            public string CheckInDate { get; set; }
            public string CheckOutDate { get; set; }

            public override string ToString()
            {
                return $"{HotelName} | Заезд: {CheckInDate} | Выезд: {CheckOutDate}";
            }
        }

        public Zaiti()
        {
            InitializeComponent();
            LoadUserData();
            LoadUserBookings();
        }

        private void LoadUserData()
        {
            // Загрузка данных пользователя
            NameTextBox.Text = "user"; // Пример данных
            EmailTextBox.Text = "user@.com"; // Пример данных
        }

        private void LoadUserBookings()
        {
            // Здесь вы можете загрузить данные о бронированиях из базы данных или другого источника.
            List<Booking> bookings = new List<Booking>
            {
                new Booking { HotelName = "Отель А", CheckInDate = "01.01.2023", CheckOutDate = "05.01.2023" },
                new Booking { HotelName = "Отель Б", CheckInDate = "10.02.2023", CheckOutDate = "15.02.2023" },
                new Booking { HotelName = "Отель В", CheckInDate = "20.03.2023", CheckOutDate = "25.03.2023" }
            };

            // Заполнение ListBox данными о бронированиях
            BookingsListBox.ItemsSource = bookings;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Сохранение данных пользователя
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;

            // Логика сохранения данных (например, в базе данных)
            MessageBox.Show("Данные сохранены!");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрыть текущее окно
        }
    }
}
