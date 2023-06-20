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

namespace SWP_4IT_WP_VP
{
    public partial class order : Form
    {
        public static SqlCommand cmd;
        public static List<string> list = new List<string>();
        public order()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            sqlmanager.OrderProducts(cb_Products.Text, nud_product.Value);
            MessageBox.Show("It has been stored in Storage");
        }

        //Fills up Combobox and Gridview
        private void order_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlmanager.ConnectionString02);
            DataTable data = new DataTable();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from Products", con));
            sqldataAdapter.Fill(data);

            dataGridView1.DataSource = data;

            DataTable data1 = new DataTable();
            SqlDataAdapter sqldataAdapter1 = new SqlDataAdapter(cmd = new SqlCommand("Select Product from Products", con));
            sqldataAdapter1.Fill(data1);
            cb_Products.DataSource = data1;
            cb_Products.DisplayMember = "Product";
            cb_Products.ValueMember = "Product";

        }

    }
}
