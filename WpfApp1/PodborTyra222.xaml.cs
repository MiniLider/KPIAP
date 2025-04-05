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
    /// Логика взаимодействия для PodborTyra222.xaml
    /// </summary>
    public partial class PodborTyra222 : Window
    {
        public PodborTyra222()
        {
            InitializeComponent();
        }
        private void Bback1_Click(object sender, RoutedEventArgs e)
        {
            PodborWindow mainWindow = new PodborWindow();
            mainWindow.Show();
            this.Close(); // Закрыть текущее окно
        }
    }
}
