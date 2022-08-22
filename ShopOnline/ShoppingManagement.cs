using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOnline
{
    public partial class ShoppingManagement : Form
    {
        public ShoppingManagement()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yonit\Desktop\GroceryShop\GroceryShop.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Conn.Open();
            string query = "select * from ShoppingManagementTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            ItemsDataGridView.DataSource = ds.Tables[0];
            Conn.Close();

        }

        private void Clear()
        {
            CategoriescomboBox.SelectedIndex = -1;
            itemNameTextBox.Text = "";
            ItemPriceTextBox.Text = "";
            ItemAmountTextBox.Text = "";
            key = 0;
            //employeesocialsecuritytextBox.Text = "";

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CategoriescomboBox.SelectedIndex == -1 || itemNameTextBox.Text == "" || ItemPriceTextBox.Text == "" ||
                ItemAmountTextBox.Text == "")
            {
                MessageBox.Show("Please Enter employee infomation to save.");
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into ShoppingManagementTable values('" + CategoriescomboBox.SelectedItem.ToString() + "','" + itemNameTextBox.Text + "'," + ItemPriceTextBox.Text + "," + ItemAmountTextBox.Text + ")", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Items information saved Successfully");
                    Conn.Close();
                    populate();
                    Clear();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }
        int key = 0;
        private void ItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
