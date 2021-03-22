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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using System.IO;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();
            if(passwordWindow.ShowDialog()==true);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow();
            taskWindow.Show();
        }
    }
}


