namespace ShopOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adminLogInLabel_Click(object sender, EventArgs e)
        {
            EmployeeManagement Employee = new EmployeeManagement();
            Employee.Show();
            this.Hide();
        }
    }
}