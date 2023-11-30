using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Admin_home.xaml
    /// </summary>
    public partial class Admin_home : Page
    {
        AppEntities appEntities = new AppEntities();
        public Admin_home()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
           



        }

        private void Button_Add_Click_1(object sender, RoutedEventArgs e)
        {
            userr userr = new userr();
            userr.TID=int.Parse(TextBox_ID.Text);
            userr.uname = TextBox_Name.Text;
            userr.email = TextBox_Email_.Text;
            userr.addresss = TextBox_Add.Text;
            userr.department = TextBox_Depart.Text;
            appEntities.userrs.Add(userr);
            appEntities.SaveChanges();
            MessageBox.Show("Add user sucessfully");

        }

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {
            userr user=new userr();
            user.uname = TextBox_Name.Text;
            user.email = TextBox_Email_.Text;
            user.addresss = TextBox_Add.Text;
            user.department = TextBox_Depart.Text;
            appEntities.userrs.AddOrUpdate(user);
            appEntities.SaveChanges();
            MessageBox.Show("Update user sucessfuly");
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Refresh_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
