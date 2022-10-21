using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SWP_4IT_WP_VP
{
    internal class sqlmanager
    {
        public static string ConnectionString = "server = (localdb)\\MSSQLLocalDB; Integrated Security = true";
        public static string ConnectionString02 = "server = (localdb)\\MSSQLLocalDB; database = Intersport; Integrated Security = true";

        public static string username = login.Username;

        public static SqlConnection con;
        public static SqlConnection con02;
        public static SqlCommand cmd;

        public static bool createDatabase(string dbname)
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM sys.databases", con);

            SqlDataReader checkDatabase = cmd.ExecuteReader();
            while (checkDatabase.Read())
            {
                if (checkDatabase.GetString(0).ToLower().Equals(dbname.ToLower()))
                {
                    return true;
                }
            }
            checkDatabase.Close();

            try
            {

                SqlCommand cmd02 = new SqlCommand("Create Database " + dbname , con);
                cmd02.ExecuteNonQuery();
                

            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            
            con.Close();
            return false;
            

        }

        public static bool createTableProducts(string tnameWomen, string tnameMen, string tnameKids)
        {
            con02 = new SqlConnection(ConnectionString02);
            con02.Open();
            cmd = new SqlCommand("SELECT * FROM sys.tables", con02);

            SqlDataReader checkTable = cmd.ExecuteReader();

            while (checkTable.Read())
            {
                if (checkTable.GetString(0).ToLower().Equals(tnameWomen.ToLower()))
                {
                    return true;
                }
            }
            checkTable.Close();

            SqlCommand comWomen = new SqlCommand("Create Table " + tnameWomen + "(id int primary key IDENTITY (1, 1), type varchar(100), brand varchar(100),  price varchar(100), amount varchar(100))", con02);
            comWomen.ExecuteNonQuery();
            con02.Close();

            return false;

            //SqlCommand comMen = new SqlCommand("Create Table " + tnameMen + "(id int primary key IDENTITY (1, 1), type varchar(100), brand varchar(100),  price varchar(100), amount varchar(100))", con02);
            //SqlCommand comKids = new SqlCommand("Create Table " + tnameKids + "(id int primary key IDENTITY (1, 1), type varchar(100), brand varchar(100),  price varchar(100), amount varchar(100))", con02);

            //com = new SqlCommand("Insert into Products (type, brand, price, amount) values ('','','','')", con02);


            //comMen.ExecuteNonQuery();
            //comKids.ExecuteNonQuery();



        }

        public static string ReadPassword()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            cmd = new SqlCommand("SELECT Password FROM UserData where Username = " + username);
            cmd.ExecuteNonQuery();
            return cmd.CommandText;
        }


    }
}
