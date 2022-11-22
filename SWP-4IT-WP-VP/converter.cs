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
                SqlDataAdapter sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from " + NameofTable + ";", con));
                sqldataAdapter.Fill(data);
                gridView.DataSource = data;
            }
            catch (Exception)
            { 
                MessageBox.Show("Das hat nicht funktioniert!");
            }
        }

        private void converter_Load(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkbook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;

            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = false;
            excel.DisplayAlerts = false;

            excelworkbook = excel.Workbooks.Add(Type.Missing);

            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkbook.ActiveSheet;
            excelSheet.Name = "Test Work sheet";

            //excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount, data.Columns.Count]]; 
            //excelCellrange.EntireColumn.AutoFit();
            //Microsoft.Office.Interop.Excel.Boders border = excelCellrange.Borders;
            //border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinous;
            //border.Weight = 2d;
        }
    }
}
