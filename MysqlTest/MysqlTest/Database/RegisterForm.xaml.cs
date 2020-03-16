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

namespace MysqlTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            

            
           // Textthing.Text = userdata[0].ElementAt(3);



        }
        private void submit_Click(object sender, RoutedEventArgs e)
        {
            Register reg = new Register();
            reg.Name = NameInput.Text;
            reg.Username = UsernameInput.Text;
            reg.Email = EmailInput.Text;
            reg.Age = Convert.ToInt32(AgeInput.Text);
            reg.Password = PasswordInput.Password;
            App.db.InsertUserData(reg);
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window1 win3 = new Window1();
            win3.Show();
            this.Close();
        }
    }
}
