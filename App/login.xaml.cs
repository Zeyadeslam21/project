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

namespace App
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            user_home ex = new user_home();
            this.NavigationService.Navigate(ex);
            if(TextBox1.Text == null && TextBox2.Text ==null)
            {
                MessageBox.Show("please enter User Name And Passoward :)");
            }
            else
            {
                MessageBox.Show("Welcome");
            }
        }
    }
}
