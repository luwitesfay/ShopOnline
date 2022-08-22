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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLoginbutton_Click(object sender, EventArgs e)
        {
            if(AdminPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else if (AdminPasswordTextBox.Text == "Password")
            {
                EmployeeManagement Employee = new EmployeeManagement();
                Employee.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Wrong Admin Password");
            }
        }

        private void If(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
