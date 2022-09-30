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
    public partial class Datagridview : Form
    {
        public static string NameofTable;
        public static string ConnectionString = "server = (localdb)\\MSSQLLocalDB ; Database = User ;  Integrated Security = true";
        public static SqlCommand cmd;

        public Datagridview()
        {
            InitializeComponent();




        }

        private void Datagridview_Load(object sender, EventArgs e)
        {
            //Tabelle im Gridview ausgeben
            try
            {
                DataTable data = new DataTable();
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlDataAdapter sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from " + NameofTable + ";", con));
                sqldataAdapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception)
            {

                MessageBox.Show("Das hat nicht funktioniert!");
            }
        }
    }
}
