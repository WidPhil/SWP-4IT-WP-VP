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

        public static string username = login.name;

        public static SqlConnection con;
        public static SqlCommand cmd;
        //public static SqlDataReader reader;

        public static string DbName = "Intersport";
        public static string TInvTM = "ThisMonth";
        public static string TInvLM = "LastMonth";

        public static string TU = "Users";

        public static string TRequ = "Requirements";

        public static bool toReturnDB = false;
        public static bool toReturnT = false;


        //checks if database Intersport is already created
        public static bool CheckDb()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();

            cmd = new SqlCommand("SELECT * FROM sys.databases", con);

            SqlDataReader checkDatabase = cmd.ExecuteReader();
            while (checkDatabase.Read())
            {
                if (checkDatabase.GetString(0).ToLower().Equals(DbName.ToLower()))
                {
                    toReturnDB = true;
                }
            }
            checkDatabase.Close();
            con.Close();
            return toReturnDB;
        }

        //checks if tables are already created
        public static bool CheckT(string table)
        {
            con = new SqlConnection(ConnectionString02);
            con.Open();

            cmd = new SqlCommand("SELECT * FROM sys.tables", con);

            SqlDataReader checkTable = cmd.ExecuteReader();

            while (checkTable.Read())
            {
                if (checkTable.GetString(0).ToLower().Equals(table.ToLower()))
                {
                    toReturnT = true;
                }

            }
            checkTable.Close();
            con.Close();
            return toReturnT;
        }

        //creates database Intersport
        public static void CreateDb()
        {
            CheckDb();

            if (toReturnDB.Equals(false))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Create Database " + DbName, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception cex)
                {
                    MessageBox.Show(cex.ToString());
                }
            }
            else
            {
                con.Close();
            }
            
        }

        //creates Table inventory ThisMonth
        public static void CreateTInventoryTM()
        {
            CheckT(TInvTM);

            if (toReturnT.Equals(false))
            {
                try
                {
                    con = new SqlConnection(ConnectionString02);
                    con.Open();

                    SqlCommand com = new SqlCommand("Create Table " + TInvTM + " " +
                        "(id int primary key IDENTITY (1, 1), name varchar(100), quantity varchar(100), " +
                        "measurement varchar(100), valuePerPiece varchar(100), valueTotal varchar(100), sum varchar(100))", con);
                    com.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                con.Close();
            }
            
        }

        //creates Table inventory LastMonth
        public static void CreateTInventoryLM()
        {
            CheckT(TInvLM);

            if (toReturnT.Equals(false))
            {
                try
                {
                    con = new SqlConnection(ConnectionString02);
                    con.Open();

                    SqlCommand com = new SqlCommand("Create Table " + TInvLM + " " +
                        "(id int primary key IDENTITY (1, 1), name varchar(100), quantity varchar(100), measurement varchar(100), " +
                        "valuePerPiece varchar(100), valueTotal varchar(100), sum varchar(100))", con);
                    com.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                con.Close();
            }
            
        }

        //creates table Users
        public static void CreateTUsers()
        {
            CheckT(TU);

            if (toReturnT.Equals(false))
            {
                try
                {
                    con = new SqlConnection(ConnectionString02);
                    con.Open();

                    SqlCommand com = new SqlCommand("Create Table " + TU +
                        "(id int primary key IDENTITY (1, 1), name varchar(100), Email varchar(100), " +
                        "password varchar(100), hashedPassword varchar(100))", con);
                    com.ExecuteNonQuery();

                    con.Close();

                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                con.Close();
            }
            
        }

        //create table Requirements
        public static void CreateTRequirements()
        {
            CheckT(TRequ);

            if (toReturnT.Equals(false))
            {
                try
                {
                    con = new SqlConnection(ConnectionString02);
                    con.Open();


                    SqlCommand com = new SqlCommand("Create Table " + TRequ + "(id int primary key IDENTITY (1, 1), Product1 varchar(100), Product2 varchar(100), Product3 varchar(100), Product4 varchar(100), Product5 varchar(100), Product6 varchar(100), Product7 varchar(100))", con);
                    com.ExecuteNonQuery();

                    //cmd = new SqlCommand("Insert into Requirements (Product1, Product2, Product3, Product4, Product5, Product6, Product7) values(3, 3, 4, 3, 2, 3, 2");

                    con.Close();

                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                con.Close();
            }
            
        }

        public static void FillRequirements()
        {
            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();
                cmd = new SqlCommand("Insert into Requirements (Name, Color, Type, Brand, MinStock) values (");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //adds user to table
        public static void AddUser(string name, string Email, string Hash)
        {
            
            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();

                cmd = new SqlCommand("insert into Users(name, Email, hashedPassword) values('" + name + "', '" + Email + "', '" + Hash + "')", con);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Signed up successfully!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        //updates password in table
        public static void NewPassword(string Username, string newHash)
        {
            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();

                cmd = new SqlCommand("UPDATE Users SET hashedPassword = '" + newHash + "' WHERE name = '" + Username + "';", con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Updated successfully");
            }
        }

        //get password
        public static string ReadPassword(string username)
        {
            

            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();

                cmd = new SqlCommand("SELECT hashedPassword FROM Users Where name = '"+ username + "'", con);
                string password = (string)cmd.ExecuteScalar();

                con.Close();

                return password;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //this method querys all the data 
        public static void GetInventory()
        {
            

            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();

                cmd = new SqlCommand("Select * from Inventory");
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception CEX)
            {
                MessageBox.Show(CEX.ToString());
            }
        }

        //this method checks if the Products are low in Quantity
        public static void AutomaticOrderProducts()
        {
            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();

                cmd = new SqlCommand("Select Product1 from Inventory");
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //This Method orders Products
        public static void OrderProducts()
        {
            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();

                cmd = new SqlCommand("Insert into ");
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Update the table in the database from gridView
        public static void UpdateInventoryTable()
        {
            


        }

        
    }
}
