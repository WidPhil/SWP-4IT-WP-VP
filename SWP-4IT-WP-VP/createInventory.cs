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
            // TODO: Diese Codezeile lädt Daten in die Tabelle "intersportDataSet.ThisMonth". Sie können sie bei Bedarf verschieben oder entfernen.
            this.thisMonthTableAdapter.Fill(this.intersportDataSet.ThisMonth);
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {

                thisMonthBindingSource.RemoveCurrent();
                MessageBox.Show("Successfully cleared selected row");

            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to clear");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            sqlmanager.UpdateInventoryTable();
            thisMonthBindingSource.DataSource

            dataGridViewInventory.DataSource = ttm;
        }
    }
}
