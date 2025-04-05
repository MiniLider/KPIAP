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
using WpfApp1;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private Model model;
        private Presenter presenter;
        public LoginWindow()
        {
            InitializeComponent();
            model = new Model();
            presenter = new Presenter(model);
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            this.model = this.presenter.Login(LoginTextBox.Text, PassBox.Password);

        }
        private void OpenMainWindow_Click(object sender, RoutedEventArgs e)
        {
            Zaiti mainWindow = new Zaiti();
            mainWindow.Show();
            this.Close();
        }
        private void Update()
        {
            MessageBlock.Text = this.model.Message; //Вывод сообщения из модели
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрыть текущее окно
        }
        public class Presenter
        {
            private Model model; //Связь с моделью
            public Presenter(Model model)
            {
                this.model = model;
            }
            public Model Login(string login, string password) //Получение данных от вида
            {
                login = login.Trim(); //Обработка полученной информации
                password = password.Trim();
                this.model.Login(login, password); //Обновление модели
                return this.model; //Передача обновлённой модели
            }
        }
        public class Model
        {
            private List<User> users;
            private User loggedUser;
            public Model()
            {
                users = new List<User>();

                users.Add(new User("Name1", "Login1", "password1"));
                users.Add(new User("Name2", "Login2", "password2"));
                users.Add(new User("Name3", "Login3", "password3"));
                users.Add(new User("Name4", "Login4", "password4"));
                loggedUser = null;
            }
            public void Login(string login, string password)
            {
                bool hasLogged = false;
                foreach (User user in this.users)
                {
                    if (user.Login == login && user.Password == password)
                    {

                        this.loggedUser = user;
                        hasLogged = true;
                        break;
                    }

                }
                if (!hasLogged)
                {
                    this.loggedUser = null;
                }
            }
            public string Message
            {
                get
                {
                    return this.loggedUser != null ? $"Nice to see you { this.loggedUser.Name}!" :
                        "Wrong login or password!";

                }
            }
            public class User
            {
                private string name;
                private string login;
                private string password;
                public User(string name, string login, string password)
                {
                    this.name = name;
                    this.login = login;
                    this.password = password;
                }
                public string Name
                {
                    get
                    {
                        return this.name;
                    }
                }
                public string Login
                {
                    get
                    {
                        return this.login;
                    }
                }
                public string Password
                {
                    get

                    {
                        return this.password;
                    }
                }
            }
        }

        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
