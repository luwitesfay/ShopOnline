using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOnline
{
    public partial class AdminDashBoard : Form
    {

        //Admin dashboard page to allow user get redirected based on the nutton they click
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        //Method to allow user get redirected to employee page 
        private void EmployeePage_Click(object sender, EventArgs e)
        {

            EmployeeManagement ManagementEmployee = new EmployeeManagement();
            ManagementEmployee.Show();
            this.Hide();
        }

        //Method to allow user get redirected to employee page
        private void ItemsPage_Click(object sender, EventArgs e)
        {
            ShoppingManagement ManagementShopping = new ShoppingManagement();
            ManagementShopping.Show();
            this.Hide();
        }

        //Method to redirect user to  to Admin page
        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin.Show();
            this.Hide();
        }
    }
}
