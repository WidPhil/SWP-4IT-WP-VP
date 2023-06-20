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

        //Close submenu when another menu is clicked
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

        //Opens submenu when menu is clicked
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

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            SubMenuShow(panelInventory);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            openMainForm(new createInventory());
        }

        private void buttonOverview_Click(object sender, EventArgs e)
        {
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            openMainForm(new converter());
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            openMainForm(new compare());
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            SubMenuShow(panelProducts);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            openMainForm(new order());
        }

        //Opens Requirements
        private void buttonRequirements_Click(object sender, EventArgs e)
        {
            //openMainForm(new requirements());
        }

        //Opens editProducts
        private void buttonProduct_Click(object sender, EventArgs e)
        {
            openMainForm(new editProducts());
        }

        //Opens Info
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            SubMenuHide();
            openMainForm(new info());
        }

        //Forms are shown inside the MainPanel
        private Form currentForm = null;
        private void openMainForm(Form MainForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm = MainForm;
            }

            MainForm.TopLevel = false;
            MainForm.FormBorderStyle = FormBorderStyle.None;
            MainForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(MainForm);

            MainForm.BringToFront();
            MainForm.Show();
            
        }

        //Exit Button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}

