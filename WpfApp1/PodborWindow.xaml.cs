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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class PodborWindow : Window
    {
        public PodborWindow()
        {
            InitializeComponent();
        }
        private void CityComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Логика для обработки выбора города
        }
        private void CountryComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedCountry = (ComboBoxItem)CountryComboBox.SelectedItem;
            string country = selectedCountry.Content.ToString();

            CityComboBox.Items.Clear();

            if (country == "Россия")
            {
                CityComboBox.Items.Add("Москва");
                CityComboBox.Items.Add("Санкт-Петербург");
                CityComboBox.Items.Add("Казань");
                CityComboBox.Items.Add("Нижний Новгород");
                CityComboBox.Items.Add("Екатеринбург");
            }
            else if (country == "Беларусь")
            {
                CityComboBox.Items.Add("Минск");
                CityComboBox.Items.Add("Гродно");
                CityComboBox.Items.Add("Брест");
                CityComboBox.Items.Add("Могилев");
                CityComboBox.Items.Add("Гомель");
            }
            else if (country == "Индия")
            {
                CityComboBox.Items.Add("Нью-Дели");
                CityComboBox.Items.Add("Акра");
                CityComboBox.Items.Add("Бангалор");
                CityComboBox.Items.Add("Мумбаи");
                CityComboBox.Items.Add("Калькутта");
            }
            else if (country == "Китай")
            {
                CityComboBox.Items.Add("Шанхай");
                CityComboBox.Items.Add("Макао");
                CityComboBox.Items.Add("Пекин");
                CityComboBox.Items.Add("Хайнань");
            }
            else if (country == "Италия")
            {
                CityComboBox.Items.Add("Рим");
                CityComboBox.Items.Add("Флоренция");
                CityComboBox.Items.Add("Сардиния");
            }
        }

        private void IncreaseButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(PeopleCountTextBox.Text, out int count))
            {
                PeopleCountTextBox.Text = (count + 1).ToString();
            }
        }

        private void DecreaseButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(PeopleCountTextBox.Text, out int count) && count > 1)
            {
                PeopleCountTextBox.Text = (count - 1).ToString();
            }
        }

        private void IncreaseButton1_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(NightTextBox.Text, out int count))
            {
                NightTextBox.Text = (count + 1).ToString();
            }
        }
        private void DecreaseButton1_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(NightTextBox.Text, out int count) && count > 1)
            {
                NightTextBox.Text = (count - 1).ToString();
            }
        }

        private void Poisk_Click(object sender, RoutedEventArgs e)
        {
            if (CountryComboBox.Text == "Индия" && CityComboBox.Text == "Нью-Дели")
            {
                PodborTyra222 podbor2Window = new PodborTyra222();
                podbor2Window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не Индия. Туров нет :)");
            }
          
        }

        private void Bback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрыть текущее окно
        }
    }
}
