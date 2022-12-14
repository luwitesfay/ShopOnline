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
    public partial class Shoppingwebsite : Form
    {
        public Shoppingwebsite()
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
        int n = 0, GrdTotal = 0, Amount;
        private void AddToCartButton_Click(object sender, EventArgs e)
        {

            if (ItemAmountTextBox.Text == "" || Convert.ToInt32(ItemAmountTextBox.Text) > stock)
            {
                MessageBox.Show("Enter Quantity");
            }
            else
            {
                int total = Convert.ToInt32(ItemAmountTextBox.Text) * Convert.ToInt32(ItemPriceTextBox.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(CartDataGridView);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = itemNameTextBox.Text;
                newRow.Cells[2].Value = ItemPriceTextBox.Text;
                newRow.Cells[3].Value = ItemAmountTextBox.Text;
                newRow.Cells[4].Value = total;
                CartDataGridView.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                Amount = GrdTotal;
                totalAmountLB.Text ="Total: " + GrdTotal.ToString();
                n++;
                UpdateItemcount();
                Reset();
            }
        }

        private void UpdateItemcount()
        {
            try
            {
                int newAmount =stock - Convert.ToInt32(ItemAmountTextBox.Text);
                Conn.Open();
                string query = "Update ShoppingManagementTable set ItemAmount=" + newAmount + " where ItemID=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item information updated Successfully");
                Conn.Close();
                populate();
                
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        int stock = 0, key = 0;

        private void ItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            itemNameTextBox.Text = ItemsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ItemPriceTextBox.Text = ItemsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            if (itemNameTextBox.Text == "")
            {
                stock = 0;
                key = 0;
            }
            else
            {
                stock = Convert.ToInt32(ItemsDataGridView.SelectedRows[0].Cells[4].Value.ToString());
                key = Convert.ToInt32(ItemsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
        private void Reset()
        {

            itemNameTextBox.Text = "";
            ItemPriceTextBox.Text = "";
            ItemAmountTextBox.Text = "";
            CustommerNameTextBox.Text = "";
        }
        string  EmployeeName = "EmployeeName";
        int EmployeeId = 1;

        private void Reciptbutton_Click(object sender, EventArgs e)
        {
            Reecipt reecipt = new Reecipt();
            reecipt.Show();
            this.Hide();
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            LogInPage Obj = new LogInPage();
            Obj.Show();
            this.Hide();

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void ItemAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LogInPage logInPage = new LogInPage();
            logInPage.Show();
            this.Hide();


        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            

        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Shoppingwebsite_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
    }
}
