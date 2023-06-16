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
    public partial class createInventory : Form
    {
        public static string n;
        public static string q;
        public static string m;
        public static string vp;
        public static decimal v;

        public createInventory()
        {
            InitializeComponent();
            textBoxName.Enabled = false;
            textBoxQuantity.Enabled = false;
            textBoxMeasurement.Enabled = false;
            textBoxValuePerPiece.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
           sqlmanager.UpdateTable(n, q, m, vp, v);
             
        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            n = textBoxName.Text;

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            sum();

            q = textBoxQuantity.Text;
        }

        private void textBoxMeasurement_TextChanged(object sender, EventArgs e)
        {
            m = textBoxMeasurement.Text;
        }

        private void textBoxValuePerPiece_TextChanged(object sender, EventArgs e)
        {
            sum();

            vp = textBoxValuePerPiece.Text;
        }

        private void sum()
        {
            try
            {
                if (textBoxQuantity.Text != null || textBoxValuePerPiece.Text != null)
                {
                    decimal qi = Convert.ToDecimal(textBoxQuantity.Text);
                    decimal vpi = Convert.ToDecimal(textBoxValuePerPiece.Text);

                    v = qi * vpi;


                    textBoxValueTotal.Text = v.ToString();
                }
                else
                {
                    MessageBox.Show("!");
                }
            }
            catch
            {
                
            }
            
        }

        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxQuantity.Clear();
            textBoxMeasurement.Clear();
            textBoxValuePerPiece.Clear();
            textBoxValueTotal.Clear();

        }


        private void buttonNewMonth_Click(object sender, EventArgs e)
        {
            textBoxName.Enabled = true;
            textBoxQuantity.Enabled = true;
            textBoxMeasurement.Enabled = true;
            textBoxValuePerPiece.Enabled = true;
            sqlmanager.NewMonth();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            textBoxName.Enabled = true;
            textBoxQuantity.Enabled = true;
            textBoxMeasurement.Enabled = true;
            textBoxValuePerPiece.Enabled = true;
        }
    }
}
