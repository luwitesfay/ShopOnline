using System.Data;
using System.Data.SqlClient;

namespace ShopOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yonit\Desktop\GroceryShop\GroceryShop.mdf;Integrated Security=True;Connect Timeout=30");
        private void adminLogInLabel_Click(object sender, EventArgs e)
        {
            AdminLogin Obj = new AdminLogin();
            Obj.Show();
            this.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Conn.Open();
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
            else
            {
                MessageBox.Show("Wrong user nameOr Passowrd");
            }
            Conn.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}