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
        public static string connectionstring = "server = (localdb)\\MSSQLLocalDB ; Database = User ;  Integrated Security = true";
        public static SqlCommand cmd;
        public static SqlConnection con;
        public static string Base;
        public static string CompareTo;

        public static int choice;

        public compare()
        {
            InitializeComponent();
        }

        private void cb_chooseTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            //choice = cb_chooseTable.SelectedIndex;
        }

        private void Compare_Load(object sender, EventArgs e)
        {
            //cb_chooseTable.Items.Add(cmd = "SELECT * FROM INVENTORY WHERE INVID = " + choice + "", con);

        }

      

        private void btn_compare_Click_1(object sender, EventArgs e)
        {
            Base = cb_Base.Text;
            CompareTo = cb_compareBase.Text;
            //Tabelle im Gridview ausgeben
            try
            {
                SqlCommand cmd = new SqlCommand();
                
                DataTable dataBase = new DataTable();
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                SqlDataAdapter sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from " + Base + ";", con));
                sqldataAdapter.Fill(dataBase);
                dgv_Base.DataSource = dataBase;
            }
            catch (Exception)
            {
            }
            //Tabelle im Gridview ausgeben
            try
            {
                SqlCommand cmd = new SqlCommand();
                
                DataTable data = new DataTable();
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                SqlDataAdapter sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from " + CompareTo + ";", con));
                sqldataAdapter.Fill(data);
                dgv_compareBase.DataSource = data;
            }
            catch (Exception)
            {
            }

        }
    }
}
