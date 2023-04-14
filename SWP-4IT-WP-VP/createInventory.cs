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
            // TODO: Diese Codezeile lädt Daten in die Tabelle "intersportDataSet1.Storage". Sie können sie bei Bedarf verschieben oder entfernen.
            this.storageTableAdapter.Fill(this.intersportDataSet1.Storage);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "intersportDataSet.ThisMonth". Sie können sie bei Bedarf verschieben oder entfernen.
            this.thisMonthTableAdapter.Fill(this.intersportDataSet.ThisMonth);

            //Todo: format all id numbers into normal numbers
            dataGridViewInventory.DefaultCellStyle.Format = "0";

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //delets a row from the datagridview
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
            
            
            //todo: check if all cells are filled with information and save the data into variables

            if (dataGridViewInventory.SelectedCells != null)
            {
                //Run through all selected cells
                foreach (DataGridViewCell cell in dataGridViewInventory.SelectedCells)
                {
                    //Access the value of the cell and store it in a variable
                    string value = cell.Value.ToString();

                    sqlmanager.UpdateInventoryTableTM(value);
                    //if (int.TryParse(value, out intValue))
                    //{
                    //    MessageBox.Show("Worked!");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("No!");
                    //}
                }
            }
            else
            {
                MessageBox.Show("Please fill all cells with the right data!");
            }

            MessageBox.Show("saved successfully!");

        }

        private void CellFormattingDGV(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //format the id cell into a normal number - not working because of another problem!
            if (this.dataGridViewInventory.Columns[e.ColumnIndex].Name.Equals("id"))
            {
                e.Value = Math.Abs(Convert.ToInt32(e.Value));

                e.CellStyle.Format = "0";
            }
        }

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
