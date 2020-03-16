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

namespace MysqlTest.Database
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        Login log = new Login();
        public Window1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            string output = "Error";
            log.Username = UserNameInput.Text;
            log.Password = PasswordInput.Password;
            List<string> error = App.db.Login(log);
            if (error.Count == 0)
            {
                UserPage win3 = new UserPage();
                win3.Show();
                this.Close();
            }
            else
            {
                foreach (string items in error)
                {
                    output = $"{output} {items}";
                }
                Error.Text = output;
            }


        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Close();
        }
    }
}
