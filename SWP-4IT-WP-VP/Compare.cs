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

        public static int choice;

        public compare()
        {
            InitializeComponent();
        }

        private void cb_chooseTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = cb_chooseTable.SelectedIndex;
        }

        private void Compare_Load(object sender, EventArgs e)
        {
            //cb_chooseTable.Items.Add(cmd = "SELECT * FROM INVENTORY WHERE INVID = " + choice + "", con);
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            overview show = new overview();
            show.Show();
        }
    }
}
