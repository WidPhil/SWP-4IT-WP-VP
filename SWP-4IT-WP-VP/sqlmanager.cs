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
        public static string ConnectionString = "server = (localdb)\\MSSQLLocalDB;Database = master;Integrated Security = true";
        /*;Database =" + NameofDB + "*/

        public static int iForDatabases;
        public static int iForTables;
        //public static string Username = login.Username;
        //public static string Password = login.Password;




        public static int ID;
        //df



        public static string NameofDB = "INVSOFTWARE";
        public static string NameofDB2 = "UserData";
        public static string NameofTBL;
        public static SqlConnection con;
        public static SqlCommand cmd;


        //Testpush



        //Datenbank erstellen, löschen und verändern
        //Wir brauchen Tabelle Veranstaltung und Tabelle Gäste
        public static bool createDatabaseandTable()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM sys.databases", con);

            SqlDataReader checkDatabase = cmd.ExecuteReader();
            while (checkDatabase.Read())
            {
                if (checkDatabase.GetString(0).ToLower().Equals(NameofDB.ToLower()))
                {
                    return true;
                }
            }
            checkDatabase.Close();



            try
            {

                SqlCommand cmd2 = new SqlCommand("Create Database INVSOFTWARE", con);
                cmd2.ExecuteNonQuery();
                con.Close();



                con = new SqlConnection("server = (localdb)\\MSSQLLocalDB; Database = INVSOFTWARE; Integrated Security = true");
                con.Open();
                SqlCommand cmd = new SqlCommand("CREATE TABLE PRODUCTS(pid int, description varchar(50), delivery varchar(100))", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            return false;
        }

        public static bool createDatabaseandTableforPassword()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM sys.databases", con);

            SqlDataReader checkDatabase = cmd.ExecuteReader();
            while (checkDatabase.Read())
            {
                if (checkDatabase.GetString(0).ToLower().Equals(NameofDB2.ToLower()))
                {
                    return true;
                }
            }
            checkDatabase.Close();



            try
            {

                SqlCommand cmd2 = new SqlCommand("Create Database UserData", con);
                cmd2.ExecuteNonQuery();
                con.Close();



                con = new SqlConnection("server = (localdb)\\MSSQLLocalDB; Database = UserData; Integrated Security = true");
                con.Open();
                SqlCommand cmd = new SqlCommand("CREATE TABLE Data(id int, Username varchar(50), Password varchar(100))", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            return false;
        }

        public static string ReadUser()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            cmd = new SqlCommand("SELECT Username FROM UserData where id = 1");
            cmd.ExecuteNonQuery();
            return cmd.CommandText;


        }

        public static string ReadPassword()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            cmd = new SqlCommand("SELECT Password FROM UserData where id = 1");
            cmd.ExecuteNonQuery();
            return cmd.CommandText;
        }

        //Datenbank löschen
        public static void deleteDB()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("DROP DATABASE IF EXISTS " + NameofDB, con);
                cmd.ExecuteNonQuery();
                iForDatabases++;

            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            con.Close();
            MessageBox.Show("Database Successfully deleted!");
        }
             
        public static void InsertintoTable()

        {
            try
            {
               
                con = new SqlConnection("server = (localdb)\\MSSQLLocalDB; Database = UserData; Integrated Security = true");
                con.Open();

                //SqlCommand cmd = new SqlCommand("INSERT INTO TABLE UserData (" + "'" + ID + "' " + "INT PRIMARY KEY," + " '" + Username + "' " + "VARCHAR NOT NULL," + " '" + Password + "' " + "VARCHAR NOT NULL," + ")" +
                 SqlCommand cmd = new SqlCommand("INSERT INTO UserData('id', 'Username', 'Password') VALUES('1', 'Widauer', '1234')", con);
                cmd.ExecuteNonQuery();
                iForTables++;




            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void deleteTBL()
        {
            //Funktioniert nicht
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("DROP TABLE " + NameofTBL, con);
                cmd.ExecuteNonQuery();
                iForTables++;

            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            con.Close();
            MessageBox.Show("Table Successfully deleted!");
        }



        //public static void AlterTBL()
        //{
        //    con = new SqlConnection(ConnectionString);
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //}
        public static void searchData()
        {
            //SELECT CustomerID, CompanyName, ContactName, ContactTitle,
            //Address, City, Region, PostalCode, Country, Phone, Fax
            //FROM Customers
            //WHERE City = @City
        }
    }
}
