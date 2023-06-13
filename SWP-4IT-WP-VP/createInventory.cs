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
        public static string v;

        public createInventory()
        {
            InitializeComponent();
            
            //InitializeDatabase();
        }

        //private sqlmanager databaseHelper;
        //private void InitializeDatabase()
        //{
        //    //string connection = "server = (localdb)\\MSSQLLocalDB; database = Intersport; Integrated Security = true";
        //    //databaseHelper = new sqlmanager(connection);

        //    //string selectQuery = "SELECT * FROM ThisMonth";
        //    //dataGridViewInventory.DataSource = databaseHelper.GetData(selectQuery);
        //}
        private void createInventory_Load(object sender, EventArgs e)
        {
            
            // TODO: Diese Codezeile lädt Daten in die Tabelle "intersportDataSet.ThisMonth". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.thisMonthTableAdapter.Fill(this.intersportDataSet.ThisMonth);

            //Todo: format all id numbers into normal numbers
            //dataGridViewInventory.DefaultCellStyle.Format = "0";

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
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            n = textBoxName.Text;

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            q = textBoxQuantity.Text;
        }

        private void textBoxMeasurement_TextChanged(object sender, EventArgs e)
        {
            m = textBoxMeasurement.Text;
        }

        private void textBoxValuePerPiece_TextChanged(object sender, EventArgs e)
        {
            vp = textBoxValuePerPiece.Text;
        }

        private void textBoxValueTotal_TextChanged(object sender, EventArgs e)
        {
            v = textBoxValueTotal.Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string updateQuery = "UPDATE ThisMonth SET id = @id, name = @name, quantity = @quantity, measurement = @measurement, valuePerPiece = @valuePerPiece, valueTotal = @valueTotal WHERE id = @id";
            //    databaseHelper.UpdateData((DataTable)dataGridViewInventory.DataSource, updateQuery);

            //    MessageBox.Show("Daten wurden erfolgreich gespeichert.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Fehler beim Speichern der Daten: " + ex.Message);
            //}

            //todo: check if all cells are filled with information and save the data into variables

            //if (dataGridViewInventory.SelectedCells != null)
            //{
            //    //Run through all selected cells
            //    foreach (DataGridViewCell cell in dataGridViewInventory.SelectedCells)
            //    {
            //        //Access the value of the cell and store it in a variable
            //        string value = cell.Value.ToString();

            //        sqlmanager.UpdateInventoryTableTM(value);
            //        //if (int.TryParse(value, out intValue))
            //        //{
            //        //    MessageBox.Show("Worked!");
            //        //}
            //        //else
            //        //{
            //        //    MessageBox.Show("No!");
            //        //}
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please fill all cells with the right data!");
            //}

            //MessageBox.Show("saved successfully!");

            sqlmanager.UpdateTable(n, q, m, vp, v);

        }

        private void CellFormattingDGV(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //format the id cell into a normal number - not working because of another problem!
            //if (this.dataGridViewInventory.Columns[e.ColumnIndex].Name.Equals("id"))
            //{
            //    e.Value = Math.Abs(Convert.ToInt32(e.Value));

            //    e.CellStyle.Format = "0";
            //}
        }

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        
    }
}
