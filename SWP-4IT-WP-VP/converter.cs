using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SWP_4IT_WP_VP
{
    public partial class converter : Form
    {
        public static string Connectionstring = "server = (localdb)\\MSSQLLocalDB;Database = Intersport;Integrated Security = true";
        public static string NameofTable;

        //TestEdit

        public converter()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataGridView gridView = new DataGridView();
                DataTable data = new DataTable();
                SqlConnection con = new SqlConnection(Connectionstring);
                con.Open();
                SqlDataAdapter sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from Users;", con));
                sqldataAdapter.Fill(data);
                gridView.DataSource = data;




               
                Microsoft.Office.Interop.Excel.Worksheet excelSheet;
                Microsoft.Office.Interop.Excel.Range excelCellrange;


                //load Excel and creatr a new Workbook
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Workbooks.Add();

                //single Worksheet
                //Microsoft.Office.Interop.Excel._Worksheet worksheet = excel.ActivateSheet;


                Microsoft.Office.Interop.Excel.Workbook excelworkbook = new Microsoft.Office.Interop.Excel.Workbook();
                excelworkbook.Worksheets.Add(data, "Inventur-Uebersicht");

                //Datacells
                int RowsCount = data.Rows.Count;





                excel.Visible = true;
                excel.DisplayAlerts = false;

                

                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkbook.ActiveSheet;
                excelSheet.Name = "Test Work sheet";

                //excelCellrange = excelSheet.Range(excelSheet.Cells[1, 1], excelSheet.Cells[RowIndex, data.Columns.Count]);
                //excelCellrange.EntireColumn.AutoFit();
            }
            catch (Exception)
            { 
                MessageBox.Show("Das hat nicht funktioniert!");
            }
        }

        private void converter_Load(object sender, EventArgs e)
        {
          

            //excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount, data.Columns.Count]]; 
            //excelCellrange.EntireColumn.AutoFit();
            //Microsoft.Office.Interop.Excel.Boders border = excelCellrange.Borders;
            //border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinous;
            //border.Weight = 2d;
        }
    }
}
