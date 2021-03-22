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
    /// Логика взаимодействия для PasswordWindow.xaml
    /// </summary>
    public partial class PasswordWindow : Window
    {
        public PasswordWindow()
        {
            InitializeComponent();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
        
            bool c = false;
            bool b = false;
            bool a = false;
      
           
            
                if (Password.Length >= 8)
                {
                    for (int i = 0; i < Password.Length; i++)
                    {
                        for (int j = 65; j < 90; j++)
                        {
                            if (Password[i] == (char)j)
                            {
                                a = true;
                            }
                        }

                    }
                    for (int i = 0; i < Password.Length; i++)
                    {
                        for (int j = 97; j < 122; j++)
                        {
                            if (Password[i] == (char)j)
                            {
                                b = true;
                            }
                        }
                    }
                    for (int i = 0; i < Password.Length; i++)
                    {
                        for (int j = 48; j < 57; j++)
                        {
                            if (Password[i] == (char)j)
                            {
                                c = true;
                            }
                        }
                    }

                }
                if (!a && !b && !c)
                {
                    MessageBox.Show("Авторизация не пройдена");
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + LoginBox.Text + ".txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(PasswordBox.Password);
                    sw.WriteLine(LoginBox.Text);
                    sw.WriteLine(SurNameBox.Text);
                    sw.WriteLine(NameBox.Text);
                    sw.WriteLine(SturduBox.Text);
                    sw.WriteLine(DataBox.SelectedDate);
                    }
                }
                this.DialogResult = true;
           
        }
        public string Password
        {
            get { return PasswordBox.Password; }
        }
        private void passwordBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

             
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
