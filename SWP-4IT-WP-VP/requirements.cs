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
    public partial class requirements : Form
    {
        //current placeholder
        public static string Product;
        //public static int Product2;
        //public static int Product3;
        //public static int Product4;
        //public static int Product5;
        //public static int Product6;
        //public static int Product7;
        public requirements()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Message Box output when products are low
        private void requirements_Load(object sender, EventArgs e)
        {
            MessageBox.Show("If someone has pre-ordered Products, you can order them in this form!");
            sqlmanager.GetInventory();
            for (int i = 0; i < Product[i]; i++)
            {
                if (Product[i] <= 3)
                {
                    sqlmanager.AutomaticOrderProducts();
                    MessageBox.Show("Some of the Products have fallen below minimum stock!\n" +
                        "They were ordered automatically");
                }
            }
            
          
            //else if (Product2 <= 3)
            //{
            //    MessageBox.Show("Product2 has fallen below minimum stock!");
            //}
            //else if (Product3 <= 3)
            //{
            //    MessageBox.Show("Product3 has fallen below minimum stock!");
            //}
            //else if (Product4 <= 3)
            //{
            //    MessageBox.Show("Product4 has fallen below minimum stock!");
            //}
            //else if (Product5 <= 3)
            //{
            //    MessageBox.Show("Product5 has fallen below minimum stock!");
            //}
            //else if (Product6 <= 3)
            //{
            //    MessageBox.Show("Product6 has fallen below minimum stock!");
            //}
            //else if (Product7 <= 3)
            //{
            //    MessageBox.Show("Product7 has fallen below minimum stock!");
            //}

        }
    }
}
