using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWP_4IT_WP_VP
{
    public partial class orders : Form
    {
        public static decimal Amount;
        public static string ProductGroup;
        public static string Size; 
        public static DateTime Date = DateTime.Today.Date;
        public static DateTime Delieverydate = Date.AddDays(5);

        public orders()
        {
            InitializeComponent();
        }

        private void orders_Load(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Amount = NUD__Amount.Value;
            ProductGroup = cb_productgroup.Text;
            if(radioButton1.Checked == true)
            {
                Size = "Kid";
            }
            else if (radioButton2.Checked == true)
            {
                Size = "Men";
            }
            else if (radioButton3.Checked == true)
            {
                Size = "Women";
            }
            MessageBox.Show("You ordered " + Amount + "\n Product Group " + ProductGroup + "\n the size is " + Size + "\n Delievery is on the: " + Delieverydate.ToShortDateString());
        }
    }
}
