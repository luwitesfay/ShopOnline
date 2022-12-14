using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopOnline
{
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yonit\Desktop\GroceryShop\GroceryShop.mdf;Integrated Security=True;Connect Timeout=30");
       
        private void populate()
        {
            Conn.Open();
            string query = "select * from EmployeeInfoTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            employeeDataGridView.DataSource = ds.Tables[0];
            Conn.Close();

        }

        private void empoyeeaddbutton_Click(object sender, EventArgs e)
        {
            if (employeenametextBox.Text == "" || employeeaddresstextBox.Text == "" || employeePhonetextBox.Text == "" ||
                employeeEmailTextBox.Text == "" || employeePassowordTextBox.Text == ""  )
            {
                MessageBox.Show("Please Enter employee infomation to save.");
            }
            else
            { 
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeInfoTable values('" + employeenametextBox.Text+ "','" +employeeaddresstextBox.Text+ "','" +employeePhonetextBox.Text+ "','" + employeeEmailTextBox.Text + "','" + employeePassowordTextBox.Text + "')", Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee information saved Successfully");
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
        private void Clear()
        {
            employeenametextBox.Text = "";
            employeeaddresstextBox.Text = "";
            employeePhonetextBox.Text = "";
            employeeEmailTextBox.Text = "";
            employeePassowordTextBox.Text = "";
            key = 0;
            

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            Clear();
        }
        int key=0;
        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employeenametextBox.Text = employeeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            employeeaddresstextBox.Text = employeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            employeePhonetextBox.Text = employeeDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            employeeEmailTextBox.Text = employeeDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            employeePassowordTextBox.Text = employeeDataGridView.SelectedRows[0].Cells[5].Value.ToString();

            if (employeenametextBox.Text =="")
            {
                key = 0;
            }else
            {
                key = Convert.ToInt32(employeeDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Employee To be deleted");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "delete from EmployeeInfoTable where EmployeeID=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query , Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee information deleted Successfully");
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

        private void employeeupdatebutton_Click(object sender, EventArgs e)
        {
            if (employeenametextBox.Text == "" || employeeaddresstextBox.Text == "" || employeePhonetextBox.Text == "" ||
                employeeEmailTextBox.Text == "" || employeePassowordTextBox.Text == "")
            {
                MessageBox.Show("Select The Employee To be updated");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "Update EmployeeInfoTable set Name='" + employeenametextBox.Text + "',Address='"+ employeeaddresstextBox.Text + "', PhoneNumber='"+ employeePhonetextBox.Text + "', Email='"+ employeeEmailTextBox.Text + "', PassWord='" + employeePassowordTextBox.Text + "' where EmployeeID=" + key+";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee information updated Successfully");
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminDashBoard AdminDashBoard = new AdminDashBoard();
            AdminDashBoard.Show();
            this.Hide();

        }
    }
}
