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
        public static SqlCommand cmd = new SqlCommand();
        public static SqlConnection con = new SqlConnection();
        public static DataTable data = new DataTable();
        public static SqlDataAdapter sqldataAdapter = new SqlDataAdapter();

        public converter()
        {
            InitializeComponent();
        }

        //This Button should convert an Inventory into excel
        private void btn_convert_Click(object sender, EventArgs e)
        {
           
            try
            {
                con = new SqlConnection(Connectionstring);
                con.Open();
                CreateExcel();
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Das hat nicht funktioniert!");
            }
        }

        private void CreateExcel()
        {
            try
            {
                cmd = new SqlCommand();
                data = new DataTable();
                sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from Users", con));
                sqldataAdapter.Fill(data);

                dgv_convert.DataSource = data;
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Tabelle1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                

                fillExcel();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
                
            }
        }
        private void fillExcel()
        {
            ////storing header part in Excel
            //for (int i = 1; i < dgv_convert.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = dgv_convert.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < dgv_convert.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < dgv_convert.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = dgv_convert.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
        }
              
    }
}
