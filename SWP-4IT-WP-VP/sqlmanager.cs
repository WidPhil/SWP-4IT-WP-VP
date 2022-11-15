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

        public static bool createTableProducts(string tname)
        {
            con = new SqlConnection(ConnectionString02);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM sys.tables", con);

            SqlDataReader checkTable = cmd.ExecuteReader();

            while (checkTable.Read())
            {
                if (checkTable.GetString(0).ToLower().Equals(tname.ToLower()))
                {
                    return true;
                }
                
            }
            checkTable.Close();

            SqlCommand com = new SqlCommand("Create Table " + tname + "(id int primary key IDENTITY (1, 1), name varchar(100), type varchar(100), brand varchar(100),  price varchar(100), amount varchar(100), availableFor varchar(100))", con02);
            //test products
            SqlCommand com02 = new SqlCommand("insert into Products(name, type, brand, price, amount, availableFor) values('SM34', 'Wanderschuhe', 'Salomon', '0.0EUR', '100Stück', 'women')", con02);
            com.ExecuteNonQuery();
            com02.ExecuteNonQuery();
            
            con.Close();
            return false;

        }

        //public static string ReadPassword()
        //{
        //    con = new SqlConnection(ConnectionString);
        //    con.Open();
        //    cmd = new SqlCommand("SELECT Password FROM UserData where Username = " + username);
        //    cmd.ExecuteNonQuery();
        //    return cmd.CommandText;
        //}


    }
}
