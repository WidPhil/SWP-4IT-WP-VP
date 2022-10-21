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
        public static string nameofDB = "Intersport";
        public static string nameofPrT = "products";

        public static string username = login.Username;
        
        public static SqlConnection con;
        public static SqlCommand cmd;


        public static bool createDatabase()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM sys.databases", con);

            SqlDataReader checkDatabase = cmd.ExecuteReader();
            while (checkDatabase.Read())
            {
                if (checkDatabase.GetString(0).ToLower().Equals(nameofDB.ToLower()))
                {
                    return true;
                }
            }
            checkDatabase.Close();

            try
            {

                SqlCommand cmd02 = new SqlCommand("Create Database" + nameofDB , con);
                cmd02.ExecuteNonQuery();
                con.Close();

            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            return false;
        }

        public static bool createTableProducts()
        {
            SqlCommand checkcom = new SqlCommand("select name from sys.tables", con);
            SqlDataReader checkTable = checkcom.ExecuteReader();

            while (checkTable.Read())
            {
                if (checkTable.GetString(0).ToLower().Equals(nameofPrT.ToLower()))
                {
                    return true;
                }

            }
            checkTable.Close();

            SqlCommand com = new SqlCommand("Create Table" + nameofPrT + "(id int primary key IDENTITY (1, 1), type varchar(100), brand varchar(100),  price varchar(100), number varchar(100))", con);
            com.ExecuteNonQuery();
            con.Close();

            return false;
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
