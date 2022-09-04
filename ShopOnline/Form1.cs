using System.Data;
using System.Data.SqlClient;

namespace ShopOnline
{
    public partial class LogInPage : Form
    {
        //Login class to allow user login based on if they are an employee or admin user
        public LogInPage()
        {
            InitializeComponent();
        }

        //Opens Connection with the sQl DB
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yonit\Desktop\GroceryShop\GroceryShop.mdf;Integrated Security=True;Connect Timeout=30");
       
        //Method to redirct Admin user to password page on click of admin label
        private void adminLogInLabel_Click(object sender, EventArgs e)
        {
            AdminLogin Obj = new AdminLogin();
            Obj.Show();
            this.Hide();
        }

        //Login method to allow user login using their username and passowrd that is saved in database
        private void loginbutton_Click(object sender, EventArgs e)
        {
            //Opens connection with database
            Conn.Open();

            //Get a user name and password from data base and allow user to log in if user name and passowrd matches with database and redierct user to shapping page
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from EmployeeInfoTable where Name ='" + usernametextBox.Text + "' and PassWord ='" + passwordtextBox.Text + "'", Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Shoppingwebsite Obj = new Shoppingwebsite();
                Obj.Show();
                this.Hide();
                Conn.Close();
            }
            //if the user name and passord don't watch with what is in datanase send an error message
            else
            {
                MessageBox.Show("Wrong user nameOr Passowrd");
            }
            Conn.Close();
        }

        //Exit button logout the user from the page
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}