using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SWP_4IT_WP_VP
{
    public partial class login : Form
    {

        public static string Username;
        public static string Password;
        
        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            sqlmanager.createDatabase("Intersport");
            sqlmanager.createTableProducts("Products");
            sqlmanager.createTableUsers("Users");

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            menu m = new menu();
            login l = new login();

            try
            {
                string name = textBoxUser.Text;
                //sqlmanager.Readpwd(username);
                
                //bool doesPasswordMatch = BCrypt.CheckPassword(password, myHash);
                //if(doesPasswordMatch == true)
                //{
                //    MessageBox.Show("Successfully logged in!");
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong!");
                throw;
            }

            



            //if (textBoxUser.Text ==)






            m.Show();
            l.Hide();

        }

        private void buttonForgetPassword_Click(object sender, EventArgs e)
        {
            sendcode sendcode = new sendcode();
            sendcode.Show();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string name = textBoxUser.Text;
            string password = textBoxPassword.Text;
            string mySalt = BCrypt.GenerateSalt();
            string myHash = BCrypt.HashPassword(password, mySalt);

            sqlmanager.AddUser(name, password, myHash);
        }

        //private static string GetRandomSalt()
        //{
        //    return BCrypt.GenerateSalt(12);
        //}

        //public static string HashPassword(string Password)
        //{
        //    return BCrypt.HashPassword(Password, GetRandomSalt());

        //}
        //public static void ValidatePassword(string Password, string passwordHash)
        //{
        //    bool verified = BCrypt.CheckPassword(Password, passwordHash);
        //    if (verified == true)
        //    {
        //        MessageBox.Show("Logged in successfully!");
        //    }
        //}

        //public static void GetPassword()
        //{
        //    string Password = sqlmanager.ReadPassword();
        //}

    }
}
