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
            ReciptDataGridView;
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
            //employeeDataGridView.ColumnCount = 7;
            CategoriescomboBox.SelectedItem = ItemsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            itemNameTextBox.Text = ItemsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ItemPriceTextBox.Text = ItemsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            ItemAmountTextBox.Text = ItemsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            //employeesocialsecuritytextBox.Text = employeeDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            if (itemNameTextBox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ItemsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CategoriescomboBox.SelectedIndex == -1 || itemNameTextBox.Text == "" || ItemPriceTextBox.Text == "" ||
                 ItemAmountTextBox.Text == "")
            {
                MessageBox.Show("Select The item To be updated");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "Update ShoppingManagementTable set ItemCategory='" + CategoriescomboBox.SelectedItem.ToString() + "',ItemName='" + itemNameTextBox.Text + "', ItemPrice=" + ItemPriceTextBox.Text + ", ItemAmount=" + ItemAmountTextBox.Text + " where ItemID=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item information updated Successfully");
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Item To be deleted");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "delete from ShoppingManagementTable where ItemID=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Items information deleted Successfully");
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

        public void Calculatate()
        { 
            int total = Convert.ToInt32(ItemAmountTextBox.Text) * Convert.ToInt32(ItemPriceTextBox.Text);
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView: Recipt.ReciptDataGridView);

        }
    }
}
