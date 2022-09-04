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

    //Page to allow Admin user enter their passowrd and login
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        //Mathod to allow adin user enter their passord and login to their page
        private void AdminLoginbutton_Click(object sender, EventArgs e)
        {
            //if statemnt to check if what user enter to what is saved for their passoword and send an error if they don't enetr a passord and click login
            if(AdminPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }

            // if else statement to redirect user to employee page is passowrd match with what is saved
            else if (AdminPasswordTextBox.Text == "Password")
            {
                AdminDashBoard AdminDashBoard = new AdminDashBoard();
                AdminDashBoard.Show();
                this.Hide();

            //Else statement to show a message if the user enter invalid password
            }else
            {
                MessageBox.Show("Wrong Admin Password");
            }
        }

        //Show element expection if exception accours
        private void If(bool v)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }
    }
}
