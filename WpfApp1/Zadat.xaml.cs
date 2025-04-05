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
    /// Логика взаимодействия для Zadat.xaml
    /// </summary>
    public partial class Zadat : Window
    {
        public Zadat()
        {
            InitializeComponent();
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string question = QuestionTextBox.Text;

            // Здесь можно добавить логику для отправки данных.
            MessageBox.Show("Ваш вопрос отправлен!\n\n" +
                            $"Имя: {name}\nEmail: {email}\nВопрос: {question}",
                            "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

            // Очистка полей после отправки
            NameTextBox.Clear();
            EmailTextBox.Clear();
            QuestionTextBox.Clear();
        }
        private void Bback1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрыть текущее окно
        }
    }
}
