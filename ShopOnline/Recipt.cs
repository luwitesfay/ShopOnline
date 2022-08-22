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
    public partial class Recipt : Form
    {
        public Recipt()
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkoutbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
