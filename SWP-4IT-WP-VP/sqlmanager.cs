using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics.Eventing.Reader;

namespace SWP_4IT_WP_VP
{
    internal class sqlmanager
    {
        //connection to the server and to the database
        public static string ConnectionString = "server = (localdb)\\MSSQLLocalDB; Integrated Security = true";
        public static string ConnectionString02 = "server = (localdb)\\MSSQLLocalDB; database = Intersport; Integrated Security = true";
        
        public static SqlConnection con;
        public static SqlCommand cmd;

        public static string username = login.name;

        //public static SqlDataReader reader;
        //Name der Datenbank: philip.widauer Benutzer für die Datenbank:   philip.widauer Kennwort für die Datenbank:   MyDatabase017 

        //Table and Database names
        public static string DbName = "Intersport";
        public static string TInvTM = "ThisMonth";
        public static string TInvLM = "LastMonth";
        public static string TInvStorage = "Storage";
        public static string TU = "Users";
        public static string TProducts = "Products";

        public static bool toReturnDB = false;
        public static bool toReturnT = false;


        //This is for getting Tables
        public static List<string> tList = new List<string>();
        public static int iForDatabases;
        public static int iForTables;


        //Entity modell
        public static IntersportEntities1 Entities = new IntersportEntities1();

        //public static DataGridView dgv = createInventory.GetDataGridView();

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
            toReturnT = false;
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

        //creates table Storage
        public static void CreateTInventoryStorage()
        {
            CheckT(TInvStorage);

            if (toReturnT.Equals(false))
            {
                try
                {
                    con = new SqlConnection(ConnectionString02);
                    con.Open();

                    SqlCommand com = new SqlCommand("Create Table " + TInvStorage + "(id int NOT NULL IDENTITY (1, 1) primary key, Product varchar(100), quantity varchar(100))", con);
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

        //creates Table inventory ThisMonth int NOT NULL IDENTITY (1, 1)primary key,
        public static void CreateTInventoryTM()
        {
            CheckT(TInvTM);

            if (toReturnT.Equals(false))
            {
                try
                {
                    con = new SqlConnection(ConnectionString02);
                    con.Open();

                    SqlCommand com = new SqlCommand("Create Table " + TInvTM + "(id int NOT NULL IDENTITY (1, 1) primary key, name varchar(100), quantity varchar(100), measurement varchar(100), valuePerPiece varchar(100), valueTotal varchar(100))", con);
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
                        "valuePerPiece varchar(100), valueTotal varchar(100))", con);
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

        //Creates Table Products
        public static void CreateTProducts()
        {
            CheckT(TProducts);



            if (toReturnT.Equals(false))
            {
                try
                {
                    con = new SqlConnection(ConnectionString02);
                    con.Open();

                    

                    SqlCommand com = new SqlCommand("Create Table " + TProducts +
                        "(id int primary key IDENTITY (1, 1), Product varchar(100), Size varchar(100), " +
                        "Brand varchar(100), Color varchar(100), Price varchar(100))", con);
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

        //Adds standard Values to Products
        public static void AddStandardProducts()
        {
            try
            {


                con = new SqlConnection(ConnectionString02);
                con.Open();



                SqlCommand com = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('Hiking Shoe', '42', 'Salomon', 'Blue', '167.99')", con);
                SqlCommand com1 = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('T-Shirt', 'M', 'McKinley', 'Blue', '67.99')", con);
                SqlCommand com2 = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('Jacket', 'L', 'Watts', 'Blue', '233.99')", con);
                SqlCommand com3 = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('Trousers', 'XL', 'Rehall', 'Blue', '79.99')", con);
                SqlCommand com4 = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('Jacket', 'S', 'McKinley', 'Black', '176.99')", con);
                SqlCommand com5 = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('Hoodie', 'M', 'Watts', 'Navy', '89.99')", con);
                SqlCommand com6 = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('Running Shoe', '43', 'Salomon', 'Blue', '145.99')", con);
                SqlCommand com7 = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('Sneakers', '45', 'Vans', 'Blue', '49.99')", con);
                SqlCommand com8 = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('Hiking Shoe', '41', 'Salomon', 'Black', '129.99')", con);
                SqlCommand com9 = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('Hiking Shoe', '40', 'Salomon', 'Green', '89.99')", con);

                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                com3.ExecuteNonQuery();
                com4.ExecuteNonQuery();
                com5.ExecuteNonQuery();
                com6.ExecuteNonQuery();
                com7.ExecuteNonQuery();
                com8.ExecuteNonQuery();
                com9.ExecuteNonQuery();
                com.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception)
            {



                throw;
            }

        }

        public static void AddProducts(string Product, string Size, string Brand, string Color, decimal Price)
        {
            try
            {
                
                
                con = new SqlConnection(ConnectionString02);
                con.Open();



                SqlCommand com = new SqlCommand("INSERT INTO Products (Product, Size, Brand, Color, Price) VALUES ('" + Product+ "', '" + Size + "', '" + Brand + "', '" + Color + "', '" + Price + "')", con);
                com.ExecuteNonQuery();
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
            con = new SqlConnection(ConnectionString02);
            con.Open();
            cmd = new SqlCommand("Insert into Users (name, Email, hashedPassword) " +
               "values ('" + name + "', '" + Email + "', '" + Hash + "')", con);
            cmd.ExecuteNonQuery();

            con.Close();
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




                cmd = new SqlCommand("Select hashedPassword from Users WHERE name = '" + username+"'", con);



                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Hash = reader[0].ToString();

                    // Lese den Wert einer bestimmten Spalte in der aktuellen Zeile
                    // Du kannst entweder den Index der Spalte verwenden (0-basiert) oder den Namen der Spalte
                    // Beispiel: int id = reader.GetInt32(0);
                    // Beispiel: string name = reader.GetString("Name");


                    return Hash;
                    // Verarbeite den Wert der aktuellen Zeile
                }
                return "User not found";


            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void UpdateTable(string n, string q, string m, string vp, decimal v)
        {
            con = new SqlConnection(ConnectionString02);
            con.Open();

            cmd = new SqlCommand("Insert into ThisMonth (name, quantity, measurement, valuePerPiece, valueTotal) " +
                "values ('" + n + "', '" + q + "', '" + m + "', '" + vp + "', '" + v + "')", con);
            cmd.ExecuteNonQuery();

            con.Close();

        }

        //Transfers Data From This Month to Last Month
        public static void NewMonth()
        {
            string tableName = "LastMonth";
            

            using (con = new SqlConnection(ConnectionString02))
            {
                try
                {
                    con.Open();

                    string query = $"SELECT COUNT(*) FROM {tableName}";
                    SqlCommand command = new SqlCommand(query, con);

                    //Get the number of records in the table
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count.Equals(0))
                    {
                        MessageBox.Show("table LM null");
                        try
                        {
                            // The table is empty

                            SqlCommand com = new SqlCommand("INSERT INTO LastMonth (name, quantity, measurement, valuePerPiece, valueTotal) " +
                                               "SELECT name, quantity, measurement, valuePerPiece, valueTotal " +
                                               "FROM ThisMonth", con);
                            com.ExecuteNonQuery();

                            SqlCommand com02 = new SqlCommand("DROP Table ThisMonth", con);
                            com02.ExecuteNonQuery();

                            con.Close();
                            CreateTInventoryTM();

                            MessageBox.Show("Start with your new inventory!");
                            

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Something went wrong." + ex.Message);
                            con.Close();
                        }
                        
                    }
                    else
                    {
                        // The table is not empty
                        MessageBox.Show("Last Months table is not empty. Now the data has been deleted.");

                        SqlCommand com = new SqlCommand("DROP Table LastMonth", con);
                        com.ExecuteNonQuery();

                        con.Close();
                        CreateTInventoryLM();
                        con.Open();
                        MessageBox.Show("LM clear!");

                        SqlCommand com02 = new SqlCommand("INSERT INTO LastMonth (name, quantity, measurement, valuePerPiece, valueTotal) " +
                                               "SELECT name, quantity, measurement, valuePerPiece, valueTotal " +
                                               "FROM ThisMonth", con);
                        com02.ExecuteNonQuery();

                        SqlCommand com03 = new SqlCommand("DROP Table ThisMonth", con);
                        com03.ExecuteNonQuery();

                        con.Close();
                        CreateTInventoryTM();

                        MessageBox.Show("Start with your new inventory!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong." + ex.Message);
                    con.Close();
                }
                con.Close();
            }
        }









        //Names of tables get saved in a list
        public static void GetListofThisandLastMonth()
        {

            
            con = new SqlConnection(ConnectionString02);
            try
            {
                con.Open();
                DataTable TBL = con.GetSchema("Tables");
                foreach (DataRow tbl in TBL.Rows)
                {
                    string tablename = (string)tbl[2];
                    if(tablename == "ThisMonth" || tablename == "LastMonth")
                    {
                        tList.Add(tablename);
                    }
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Das hat nicht funktioniert!");
            }
        }

        //Gets all Tables
        public static void GetListofTables()
        {


            con = new SqlConnection(ConnectionString02);
            try
            {
                con.Open();
                DataTable TBL = con.GetSchema("Tables");
                foreach (DataRow tbl in TBL.Rows)
                {
                    string tablename = (string)tbl[2];
                    
                        tList.Add(tablename);
                 
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Das hat nicht funktioniert!");
            }
        }

        //Orders Products and saves them in Storage
        public static void OrderProducts(string Product, decimal Quantity)
        {
            con = new SqlConnection(ConnectionString02);
            con.Open();
            cmd = new SqlCommand("Insert into Storage (Product, quantity) " +
               "values ('" + Product + "', '" + Quantity + "')", con);
            cmd.ExecuteNonQuery();

            con.Close();

        }

    }
}
