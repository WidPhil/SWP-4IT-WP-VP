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
        //Name der Datenbank: philip.widauer Benutzer für die Datenbank:   philip.widauer Kennwort für die Datenbank:   MyDatabase017 

        public static string DbName = "Intersport";
        public static string TInvTM = "ThisMonth";
        public static string TInvLM = "LastMonth";

        public static string TU = "Users";

        public static string TUpperCategory = "uppercategory";
        public static string TLowerCategory = "LowerCategorie";

        public static bool toReturnDB = false;
        public static bool toReturnT = false;

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
                        "measurement varchar(100), valuePerPiece varchar(100), valueTotal varchar(100))", con);
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
            MessageBox.Show(toReturnT.ToString());
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

        //create table Requirements
        public static void CreateTableUpperCategory()
        {
           
            CheckT(TUpperCategory);

            if (toReturnT.Equals(false))
            {
                MessageBox.Show("worked!");
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
        public static void CreateTableLowerCategory()
        {
            CheckT(TLowerCategory);

            if (toReturnT.Equals(false))
            {
                try
                {
                    con = new SqlConnection(ConnectionString02);
                    con.Open();


                    SqlCommand com = new SqlCommand("Create Table " + TLowerCategory + "(id int primary key IDENTITY (1, 1), Uc int FOREIGN KEY REFERENCES (uppercategory)(Uc), category varchar(100), lowercategory varchar(100), Product varchar(100), Size varchar(100), color varchar(100))", con);
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
        

        //Update the table in the database from gridView
        public static void UpdateInventoryTableTM(int id, string n, int q, string m, string vp, string vt)
        {
            con = new SqlConnection(ConnectionString02);
            SqlCommand com = new SqlCommand("UPDATE Intersport SET id = @id, name = @value1, quantity = @value2, measurement = @value3, valuePerPiece = @value4, valueTotal = @value5 WHERE id = @id", con);

            com.Parameters.AddWithValue("@id", "");
            com.Parameters.AddWithValue("@value1", "");
            com.Parameters.AddWithValue("@value2", "");
            com.Parameters.AddWithValue("@value3", "");
            com.Parameters.AddWithValue("@value4", "");
            com.Parameters.AddWithValue("@value5", "");

            com.Parameters["@id"].Value = id;
            com.Parameters["@value1"].Value = n;
            com.Parameters["@value2"].Value = q;
            com.Parameters["@value3"].Value = m;
            com.Parameters["@value4"].Value = vp;
            com.Parameters["@value5"].Value = vt;
            
            com.ExecuteNonQuery();
                
            con.Close();
        }


    }
}
