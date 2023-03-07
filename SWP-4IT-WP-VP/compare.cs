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
    public partial class compare : Form
    {
        public static string ConnectionString02 = "server = (localdb)\\MSSQLLocalDB; database = Intersport; Integrated Security = true";
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        public static DataTable data = new DataTable();
        public static SqlDataAdapter sqldataAdapter = new SqlDataAdapter();

        public compare()
        {
            InitializeComponent();
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString02);
            con.Open();
            data = new DataTable();
            sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from " + cb_base.Text, con));
            sqldataAdapter.Fill(data);
            dgv_Base.DataSource = data;

            data = new DataTable();
            sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from " + cb_compare.Text, con));
            sqldataAdapter.Fill(data);
            dgv_compareTo.DataSource = data;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
