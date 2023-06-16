using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data;

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
        public static string TUpperCategory = "uppercategory";
        public static string TLowerCategory = "LowerCategorie";

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

                    SqlCommand com = new SqlCommand("Create Table " + TInvStorage + "(id int NOT NULL IDENTITY (1, 1) primary key, name varchar(100), quantity varchar(100), measurement varchar(100), valuePerPiece varchar(100), valueTotal varchar(100))", con);
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

        //creates table Requirements
        public static void CreateTableUpperCategory()
        {
           
            CheckT(TUpperCategory);

            if (toReturnT.Equals(false))
            {
                try
                {
                    con = new SqlConnection(ConnectionString02);
                    con.Open();

                    SqlCommand com = new SqlCommand("Create Table " + TUpperCategory + "(id int primary key IDENTITY (1, 1), Uc varchar(100))", con);
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

        //creates table LowerCategory 
        public static void CreateTableLowerCategory()
        {
            CheckT(TLowerCategory);

            if (toReturnT.Equals(false))
            {
                try
                {
                    con = new SqlConnection(ConnectionString02);
                    con.Open();

                    //SqlCommand com = new SqlCommand("Create Table " + TLowerCategory + "(id int primary key IDENTITY (1, 1), Uc int FOREIGN KEY REFERENCES (uppercategory)(Uc), category varchar(100), lowercategory varchar(100), Product varchar(100), Size varchar(100), color varchar(100))", con);
                    //com.ExecuteNonQuery();

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

        //inserts data into table requirements
        public static void FillRequirements()

        {            
            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();
                cmd = new SqlCommand("Insert into Requirements (Name, Color, Type, Brand, MinStock, Price) values (");
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
            Users users = new Users();
            users.name = name;
            users.Email = Email;
            users.hashedPassword = Hash;
            Entities.Users.Add(users);
            Entities.SaveChanges();
        }

        //updates password in table
        public static void NewPassword(string Username, string newHash)
        {
            //Users Users = new Users();

            //if (Users.name == Username)
            //{
            //    Users.hashedPassword = newHash;
            //}
            //Entities.SaveChanges();

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
                Users users = new Users();
                Users user1 = Entities.Users.FirstOrDefault(n => n.name.Equals(username));
                if (user1 == null)
                {
                    MessageBox.Show("No one found");
                    return null;
                 
                }
                else
                {
                    return user1.hashedPassword;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //this method querys all the data 
        //this method checks if the Products are low in Quantity
        public static void AutomaticOrderProducts()
        {
            try
            {
                con = new SqlConnection(ConnectionString02);
                con.Open();


                cmd = new SqlCommand("Select * from ThisMonth");
                cmd.ExecuteNonQuery();
                SqlDataReader checkTable = cmd.ExecuteReader();

                while (checkTable.Read())
                {
                    if (checkTable.GetString(0).ToLower().Equals(3))
                    {
                        bool OrderProduct1 = true;
                    }
                    else if (checkTable.GetString(2).ToLower().Equals(3))
                    {
                        bool OrderProduct2 = true;
                    }
                    else if (checkTable.GetString(3).ToLower().Equals(3))
                    {
                        bool OrderProduct3 = true;
                    }
                    else if (checkTable.GetString(4).ToLower().Equals(3))
                    {
                        bool OrderProduct4 = true;
                    }

                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //This Method orders Products
            public static IEnumerable<Product> OrderProducts()
            {
                
                var query = "SELECT * FROM Products ORDER BY Name"; using (var connection = new SqlConnection(ConnectionString02))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            var products = new List<Product>();
                            while (reader.Read())
                            {
                            var product = new Product
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                Price = (decimal)reader["Price"],
                                    Color = (string)reader["Color"],
                                    Brand = (string)reader["Brand"],
                                    MinStock = (decimal)reader["MinStock"]
                                };
                                products.Add(product);
                            }
                            return products;
                        }
                    }
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

    }
}
