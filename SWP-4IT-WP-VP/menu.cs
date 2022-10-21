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
    public partial class menu : Form
    {
        //public static string Username = sqlmanager.Username;
        public menu()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            orders orders = new orders();
            orders.Show();
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            compare compare = new compare();
            compare.Show();
            
        }

        private void btn_requirements_Click(object sender, EventArgs e)
        {
            requirements requirements = new requirements();
            requirements.Show();
        }

        private void btn_showInv_Click(object sender, EventArgs e)
        {
            overview overview = new overview();
            overview.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            //lbl_name.Text = Username;
        }
    }
}
