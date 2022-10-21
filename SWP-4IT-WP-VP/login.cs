using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWP_4IT_WP_VP
{
    public partial class login : Form
    {
        public static string Salt;
        public static string Username;
        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            sqlmanager.createDatabase();
            sqlmanager.createTableProducts();
            


            //TODO
            //sqlmanager.InsertintoTable();
        }

        private static void GetRandomSalt()
        {
            Salt = BCrypt.GenerateSalt(12);
        }


        //Bcrypt hashes password
        public static string HashPassword(string Password, string Salt)
        {
            return BCrypt.HashPassword(Password, Salt);

            //string passwordHash = BCrypt.HashPassword(Password, GetRandomSalt());
            //ValidatePassword(Password, passwordHash);
                        
        }
        public static void ValidatePassword(string Password, string passwordHash)
        {
            bool verified = BCrypt.CheckPassword(Password, passwordHash);
            if(verified == true)
            {
                MessageBox.Show("Logged in successfully!");
            }
        }
        public static void GetUsername()
        {
            //string Username = sqlmanager.GetUsername();
        }
        public static void GetPassword()
        {
            string Password = sqlmanager.ReadPassword();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {

            //HashPassword(Password);
            Username = txtbox_username.Text;
            menu menu = new menu();
            menu.Show();
        }
    }
}
