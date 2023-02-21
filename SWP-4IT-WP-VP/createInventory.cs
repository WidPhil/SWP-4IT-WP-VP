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
        public createInventory()
        {
            InitializeComponent();
        }

        private void createInventory_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "intersportDataSet.test". Sie können sie bei Bedarf verschieben oder entfernen.
            this.testTableAdapter.Fill(this.intersportDataSet.test);
            buttonCreate.Visible = true;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            
            string date = textBox1.Text;
            //string date = dateTimePickerInventory.Text.ToString();
            
            sqlmanager.createTableInventory(date);

            MessageBox.Show("Table created successfully!");

            dataGridViewInventory.Visible = true;
            buttonCreate.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
