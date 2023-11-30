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
    /// Interaction logic for Forget_Pass.xaml
    /// </summary>
    public partial class Forget_Pass : Page
    {
        public Forget_Pass()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            userr userr = new userr();
            userr.email = TextBox5.Text;
            userr.newPass = TextBox_New_Pass.Text;
            MessageBox.Show("Rest Password sucessfully");

        }
    }
}
