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
        //public static string Username = sqlmanager.username;
        public menu()
        {
            InitializeComponent();
            menuDesign();
        }

        private void menuDesign()
        {
            panelInventory.Visible = false;
            panelProducts.Visible = false;
           
        }

        private void menuHide()
        {

            if (panelInventory.Visible.Equals(true))
            {
                panelInventory.Visible.Equals(false);
            }
            if (panelProducts.Visible.Equals(true))
            {
                panelProducts.Visible.Equals(false);
            }

        }

        private void menuShow(Panel menu)
        {
            if (menu.Visible.Equals(false))
            {
                menuHide();
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
