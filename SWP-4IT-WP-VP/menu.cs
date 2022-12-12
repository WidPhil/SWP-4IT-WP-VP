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

        private void SubMenuHide()
        {

            if (panelInventory.Visible.Equals(true))
            {
                panelInventory.Visible = false;
            }
            if (panelProducts.Visible.Equals(true))
            {
                panelProducts.Visible = false;
            }

        }

        private void SubMenuShow(Panel SubMenu)
        {
            if (SubMenu.Visible.Equals(false))
            {
                SubMenuHide();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            SubMenuShow(panelInventory);
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            SubMenuHide();
        }

        private void buttonOverview_Click(object sender, EventArgs e)
        {
            SubMenuHide();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            SubMenuHide();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            SubMenuHide();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            SubMenuShow(panelProducts);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            SubMenuHide();
        }

        private void buttonRequirements_Click(object sender, EventArgs e)
        {
            SubMenuHide();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            SubMenuHide();
        }

    }
}

