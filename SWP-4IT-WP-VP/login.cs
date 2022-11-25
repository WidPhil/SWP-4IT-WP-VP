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
        public static string password;
        public static string name;
        public static string mySalt;
        public static string myHash;
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
                string username = textBoxUser.Text;
                string Password = textBoxPassword.Text;
                
                //BCrypt.CheckPassword(Password, )
                sqlmanager.ReadPassword(username, Password);

                bool doesPasswordMatch = BCrypt.CheckPassword(password, myHash);
                if (doesPasswordMatch == true)
                {
                    MessageBox.Show("Successfully logged in!");
                }
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
            name = textBoxUser.Text;
            password = textBoxPassword.Text;
            mySalt = BCrypt.GenerateSalt();
            myHash = BCrypt.HashPassword(password, mySalt);

            sqlmanager.AddUser(name, password, myHash);
        }

        private void textBoxUserEnter(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Equals("Username"))
            {
                textBoxUser.Text = "";
            }
            textBoxUser.ForeColor = Color.Black;
        }

        private void textBoxUserLeave(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Equals(""))
            {
                textBoxUser.Text = "Username";
            }
            textBoxUser.ForeColor = Color.Silver;
        }

        private void textBoxPasswordEnter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals("Password"))
            {
                textBoxPassword.Text = "";
            }
            textBoxPassword.ForeColor = Color.Black;
        }

        private void textBoxPasswordLeave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals(""))
            {
                textBoxPassword.Text = "Password";
            }
            textBoxPassword.ForeColor = Color.Silver;
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
