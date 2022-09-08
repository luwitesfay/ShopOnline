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
    public partial class Reecipt : Form
    {
        Shoppingwebsite shoppingweb = new Shoppingwebsite();
        public Reecipt()
        {
            InitializeComponent();
        }

        private void itemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameLable.Text = RandomDigits(10);


        }

        public string RandomDigits (int length)
        {
            var random = new Random();
            NameLable.Text = String.Empty;
            for (int i = 0; i < length; i++)
                NameLable.Text = String.Concat(NameLable.Text, random.Next(10).ToString());

            return NameLable.Text;

        }

    }
}
