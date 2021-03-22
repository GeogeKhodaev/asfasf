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
using System.IO;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        public TaskWindow()
        {
            InitializeComponent();
        }
        string a, b;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + LoginBox.Text + ".txt"))
            {
                using (StreamReader sw = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + LoginBox.Text + ".txt", System.Text.Encoding.Default))
                {
                    
                    int count=0;
                    while ((a = sw.ReadLine()) != null)
                    {
                        count++;
                        if (count == 1)
                        {
                            b = a;
                        }

                    }
                    if (b == PasswordBox.Password)
                    {
                        MessageBox.Show("Вход успешен");
                    }
                }           

                
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
