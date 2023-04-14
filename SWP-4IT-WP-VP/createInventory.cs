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

            dataGridViewInventory.DefaultCellStyle.Format = "0";

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
            int intValue;

            if (dataGridViewInventory.SelectedCells.Count > 0)
            {
                // Durchlaufe alle ausgewählten Zellen
                foreach (DataGridViewCell cell in dataGridViewInventory.SelectedCells)
                {
                    // Zugriff auf den Wert der Zelle und Speichern in einer Variable
                    string value = cell.Value.ToString();

                    // Verarbeite die Daten, z.B. speichere sie in Variablen oder führe weitere Aktionen aus
                    // Beispielweise kannst du den Wert in eine Variable von einem bestimmten Typ parsen
                    
                    if (int.TryParse(value, out intValue))
                    {
                        MessageBox.Show("Worked!");
                    }
                    else
                    {
                        MessageBox.Show("No!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing is in the cell");
            }



        }

        private void CellFormattingDGV(object sender, DataGridViewCellFormattingEventArgs e)
        {

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
