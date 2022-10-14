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
    public partial class overview : Form
    {
        public static string ConnectionString = "server = (localdb)\\MSSQLLocalDB;Database = INVSOFTWARE;Integrated Security = true";
        public static string NameofTable;
        public overview()
        {
            InitializeComponent();
        }

        private void overview_Load(object sender, EventArgs e)
        {
            //Tabelle im Gridview ausgeben
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataGridView gridView = new DataGridView();
                DataTable data = new DataTable();
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlDataAdapter sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from " + NameofTable + ";", con));
                sqldataAdapter.Fill(data);
                gridView.DataSource = data;
            }
            catch (Exception)
            {
            }
        }
    }
}
