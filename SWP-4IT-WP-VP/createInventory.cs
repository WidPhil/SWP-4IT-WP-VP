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
            // TODO: Diese Codezeile lädt Daten in die Tabelle "intersportDataSet5.ThisMonth". Sie können sie bei Bedarf verschieben oder entfernen.
            this.thisMonthTableAdapter5.Fill(this.intersportDataSet5.ThisMonth);

            

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
            int id;
            string name;
            int quantity;
            string measurement;
            string valuePerPiece;
            string valueTotal;

            DataGridViewRow selectedRow = dataGridViewInventory.SelectedRows[0];

            id = int.Parse(selectedRow.Cells["id"].Value.ToString());
            name = selectedRow.Cells["name"].Value.ToString();
            quantity = int.Parse(selectedRow.Cells["quantity"].Value.ToString());
            measurement = selectedRow.Cells["measurement"].Value.ToString();
            valuePerPiece = selectedRow.Cells["valuePerPiece"].Value.ToString();
            valueTotal = selectedRow.Cells["valueTotal"].Value.ToString();
            
            sqlmanager.UpdateInventoryTableTM(id, name, quantity, measurement, valuePerPiece, valueTotal);
            

            
        }

        private void CellFormattingDGV(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.dataGridViewInventory.Columns[e.ColumnIndex].Name.Equals("id"))
            {
                e.Value = Math.Abs(Convert.ToInt32(e.Value));

                e.CellStyle.Format = "0";
            }
        }
    }
}
