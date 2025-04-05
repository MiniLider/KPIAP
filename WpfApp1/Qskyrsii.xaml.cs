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
    public partial class Qskyrsii : Window
    {
        public Qskyrsii()
        {
            InitializeComponent();
        }

        private void BookExcursion_Click(object sender, RoutedEventArgs e)
        {
            string selectedExcursion = (ExcursionComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            MessageBox.Show($"Вы забронировали {selectedExcursion} на {ExcursionDatePicker.SelectedDate.Value.ToShortDateString()} на {NumberOfPeopleTextBox.Text} человек.");
        }

        private void Bback1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрыть текущее окно
        }

        private void ExcursionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ExcursionComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedExcursion = selectedItem.Content.ToString();
                UpdateExcursionDetails(selectedExcursion);
            }
        }

        private void UpdateExcursionDetails(string excursionName)
        {
            ExcursionDetailsListView.Items.Clear(); // Очистка текущих деталей

            // Обновление информации в зависимости от выбранной экскурсии
            switch (excursionName)
            {
                case "Экскурсия 1":
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Место назначения: Загородный парк" });
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Время начала: 10:00" });
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Длительность: 3 часа" });
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Цена: 1500 руб." });
                    break;
                case "Экскурсия 2":
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Место назначения: Городской музей" });
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Время начала: 11:00" });
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Длительность: 2 часа" });
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Цена: 1000 руб." });
                    break;
                case "Экскурсия 3":
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Место назначения: Природный заповедник" });
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Время начала: 09:00" });
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Длительность: 4 часа" });
                    ExcursionDetailsListView.Items.Add(new ListViewItem { Content = "Цена: 2000 руб." });
                    break;
            }
        }
    }
}