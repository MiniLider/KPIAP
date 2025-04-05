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
    /// Логика взаимодействия для Avia.xaml
    /// </summary>
    public partial class Avia : Window
    {
        public Avia()
        {
            InitializeComponent();
        }
        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика бронирования может быть добавлена здесь
            string departureCity = DepartureCityTextBox.Text;
            string destinationCity = DestinationCityTextBox.Text;
            string departureDate = DepartureDatePicker.SelectedDate?.ToString("d");
            string returnDate = ReturnDatePicker.SelectedDate?.ToString("d");
            string flightClass = (FlightClassComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (string.IsNullOrWhiteSpace(departureCity) || string.IsNullOrWhiteSpace(destinationCity) ||
                departureDate == null || returnDate == null || flightClass == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Сообщение об успешной броне
            MessageBox.Show("Бронирование успешно!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void BookFlight_Click(object sender, RoutedEventArgs e)
        {
            string departureCity = DepartureCityTextBox.Text;
            string destinationCity = DestinationCityTextBox.Text;

            // Реализация логики бронирования
            MessageBox.Show($"Бронирование рейса из {departureCity} в {destinationCity} выполнено!");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрыть текущее окно
        }
    }
}
