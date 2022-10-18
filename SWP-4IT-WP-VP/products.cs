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

namespace SWP_4IT_WP_VP
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void products_Load(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            orders orders = new orders();
            orders.Show();


        }

        private void cb_chooseproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ConnectionString = "server = (localdb)\\MSSQLLocalDB;Database = master;Integrated Security = true";
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            string Product = "jsdlkafj";

            con.Open();
            cmd.CommandText = "SELECT * FROM PRODUCTS WHERE DESCRIPTION = " + Product;
                    
        }
    }
}
