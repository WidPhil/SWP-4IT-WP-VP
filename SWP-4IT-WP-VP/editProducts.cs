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
    public partial class editProducts : Form
    {
        SqlCommand cmd = new SqlCommand();
        public editProducts()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sqlmanager.AddProducts(txtbox_product.Text, txtbox_Size.Text, txtbox_Brand.Text, txtbox_color.Text, NUD_Price.Value) ;
        }

        private void editProducts_Load(object sender, EventArgs e)
        {
          
        }
        //preview of table
        private void btn_preview_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlmanager.ConnectionString02);
            DataTable data = new DataTable();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from Products", con));
            sqldataAdapter.Fill(data);

            dataGridView1.DataSource = data;
        }

 
    }
}
