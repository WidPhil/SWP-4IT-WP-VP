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
        public static SqlDataReader reader;

        //Creates Database
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
            catch (Exception cex)
            {
                MessageBox.Show(cex.ToString());
            }
            
            con.Close();
            return false;
            

        }

        //Creates Table Products
        public static bool createTableInventory(string tname)
        {
            try
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

                SqlCommand com = new SqlCommand("Create Table " + tname + "(id int primary key IDENTITY (1, 1), name varchar(100), quantity varchar(100), measurement varchar(100), valuePerPiece varchar(100), valueTotal varchar(100), sum varchar(100))", con);
                com.ExecuteNonQuery();
                
                con.Close();
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Creates Table Users
        public static bool createTableUsers(string tname)
        {
            try
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

                SqlCommand com = new SqlCommand("Create Table " + tname + "(id int primary key IDENTITY (1, 1), name varchar(100), Email varchar(100), password varchar(100), hashedPassword varchar(100))", con);
                com.ExecuteNonQuery();
                //test products


                con.Close();
                return false;

            }
            catch (Exception)
            {

                throw;
            }

            
        }

       //Create Table Requirements
        public static bool createTableRequirements(string tname)
        {
            try
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

                //SqlCommand com = new SqlCommand("Create Table " + tname + "(id int primary key IDENTITY (1, 1), name varchar(100), type varchar(100), inStock varchar(100), MinimumStock varchar(100))", con);
                //com.ExecuteNonQuery();
                SqlCommand com = new SqlCommand("Create Table " + tname + "(id int primary key IDENTITY (1, 1), Product1 varchar(100), Product2 varchar(100), Product3 varchar(100), Product4 varchar(100), Product5 varchar(100), Product6 varchar(100), Product7 varchar(100))", con);
                com.ExecuteNonQuery();

                //cmd = new SqlCommand("Insert into Requirements (Product1, Product2, Product3, Product4, Product5, Product6, Product7) values(3, 3, 4, 3, 2, 3, 2");

                con.Close();
                return false;

            }
            catch (Exception CEX)
            {
                throw;
                MessageBox.Show(CEX.Message);

            }
        }

        //Adds User to Table
        public static void AddUser(string name, string Email, string password, string Hash)
        {
            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();
                cmd = new SqlCommand("insert into Users(name, Email, password, hashedPassword) values('" + name + "', '" + Email + "', '" + password + "', '" + Hash + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Signed up successfully!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Updates Password in Table
        //working on it
        public static void NewPassword(string newPassword, string Username, string newHash)
        {
            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();
                cmd = new SqlCommand("UPDATE Users SET password = '" + newPassword + "', hashedPassword = '" + newHash + "' WHERE name = '" + Username + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Updated successfully");
            }
        }

        //Get Password
        public static string ReadPassword(string username)
        {
            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();
                cmd = new SqlCommand("SELECT password FROM Users Where name = '"+ username + "'", con);
                
                string password = (string)cmd.ExecuteScalar();
                return password;
                con.Close();

            }
            catch (Exception)
            {
                
                throw;
                
            }
        }

        //This Method Querys all the data from
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

        //This Method checks if the Products are low in Quantity
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
    }
}
