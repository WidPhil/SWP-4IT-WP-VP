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
        static int Product1;
        static int Product2;
        static int Product3;
        static int Product4;
        static int Product5;
        static int Product6;
        static int Product7;
        public requirements()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void requirements_Load(object sender, EventArgs e)
        {
            sqlmanager.GetInventory();
            if(Product1 <= 3)
            {
                MessageBox.Show("Product1 has fallen below minimum stock!");
            }
            else if (Product2 <= 3)
            {
                MessageBox.Show("Product2 has fallen below minimum stock!");
            }
            else if (Product3 <= 3)
            {
                MessageBox.Show("Product3 has fallen below minimum stock!");
            }
            else if (Product4 <= 3)
            {
                MessageBox.Show("Product4 has fallen below minimum stock!");
            }
            else if (Product5 <= 3)
            {
                MessageBox.Show("Product5 has fallen below minimum stock!");
            }
            else if (Product6 <= 3)
            {
                MessageBox.Show("Product6 has fallen below minimum stock!");
            }
            else if (Product7 <= 3)
            {
                MessageBox.Show("Product7 has fallen below minimum stock!");
            }

        }
    }
}
