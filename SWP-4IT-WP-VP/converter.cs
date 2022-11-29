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
            saveFileDialog.FileName = "Test.xlsx";
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

                //Microsoft.Office.Interop.Excel.Worksheet excelSheet;


                //initialise
                //load Excel and create a new Workbook
                Microsoft.Office.Interop.Excel.Worksheet excelSheet = new Microsoft.Office.Interop.Excel.Worksheet();
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                //Workbook
                Microsoft.Office.Interop.Excel.Workbook excelworkbook = new Microsoft.Office.Interop.Excel.Workbook();
                excelworkbook.Worksheets.Add(data, "Inventur-Uebersicht");

                //making Excel visible
                excel.Visible = true;
                excel.DisplayAlerts = true;

                //Worksheet
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkbook.ActiveSheet;
                excelSheet.Name = "Inventur";
                excel.Workbooks.Add();

                excelSheet.Cells[1, 1] = "Test";

                //resize Columns
                Microsoft.Office.Interop.Excel.Range excelCellrange;
                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[/*excelSheet.Rows,*/data.Columns.Count]];
                excelCellrange.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;


                ////Datacells
                //int RowsCount = data.Rows.Count;


                //excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkbook.ActiveSheet;
                //excelSheet.Name = "Test Work sheet";


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
