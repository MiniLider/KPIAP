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
    /// Логика взаимодействия для RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
        public RegistrWindow()
        {
            InitializeComponent();
        }
  
        private const string ExpectedUsername = "user";
        private const string ExpectedEmail = "user@gmail.com";
        private const string ExpectedPassword = "123";

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрыть текущее окно
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;
            string confirmPassword = ConfirmPasswordBox.Password;

            if (username == ExpectedUsername && email == ExpectedEmail && password == ExpectedPassword && password == confirmPassword)
            {
             
                MessageBox.Show("Добро пожаловать!", "Регистрация успешна", MessageBoxButton.OK, MessageBoxImage.Information);
                Zaiti mainWindow = new Zaiti();
                mainWindow.Show();
                this.Close();
            }
            else
            {
    
                ResultTextBlock.Text = "Некорректные данные. Пожалуйста, попробуйте снова.";
            }
        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
