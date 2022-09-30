using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SWP_4IT_WP_VP
{
    internal class Manager
    {
        public static string ConnectionString = "server = (localdb)\\MSSQLLocalDB;Database =" + NameofDB + ";Integrated Security = true";

        public static int iForDatabases;
        public static int iForTables;




        public static int ID;
        //df



        public static string NameofDB;
        public static string NameofTBL;
        public static SqlConnection con;


        //Testpush



        //Datenbank erstellen, löschen und verändern
        //Wir brauchen Tabelle Veranstaltung und Tabelle Gäste
        public static void createDatabase()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("CREATE DATABASE INVSOFTWARE", con);
                cmd.ExecuteNonQuery();
                iForDatabases++;
            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            con.Close();
            MessageBox.Show("Database Successfully created!");
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


        //Tabelle
        public static void createTBL() { }


        //Tabelle
        public static void createTable()
        {
            //Funktioniert nicht
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();

                SqlCommand com = new SqlCommand("CREATE TABLE INVENTORY(PID varchar(200), description varchar(20), colour varchar(20), Orderdate varchar(20), delivery date varchar(20)", con);
                com.ExecuteNonQuery();
                //SqlCommand cmd = new SqlCommand("CREATE TABLE event(ID varchar(200), NamedesEvents varchar(50), AnzahlderGaeste varchar(50), Chef varchar(50)", con);
                //cmd.ExecuteNonQuery();
                iForTables++;

            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            con.Close();
            MessageBox.Show("Table Successfully created!");

        }

        public static void InsertintoTable(string nameofTable)

        {
            try
            {
                //if ()
                con = new SqlConnection(ConnectionString);
                con.Open();

                //SqlCommand cmd = new SqlCommand("CREATE TABLE " + NameofTBL + " (" + "'" + ID + "' " + "INT PRIMARY KEY," + " '" + nameofEvent + "' " + "VARCHAR NOT NULL," + " '" + street + "' " + "VARCHAR NOT NULL," + " '" + house + "' " + "VARCHAR NOT NULL" + ");", con);
                //cmd.ExecuteNonQuery();
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
