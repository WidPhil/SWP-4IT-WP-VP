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
        public static string Email;
        public static string mySalt;
        public static string myHash;
        public login()
        {
            InitializeComponent();
        }

        //Creates Databases and Tables
        private void Login_Load(object sender, EventArgs e)
        {
            sqlmanager.createDatabase("Intersport");
            sqlmanager.createTableProducts("Products");
            sqlmanager.createTableUsers("Users");

        }

        //Opens Forms
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            menu m = new menu();
            login l = new login();
            m.Show();
            l.Hide();

            converter excel = new converter();
            excel.Show();

            //try
            //{
            //    string username = textBoxUser.Text;
            //    string Password = textBoxPassword.Text;
                
            //    //BCrypt.CheckPassword(Password, )
            //    sqlmanager.ReadPassword(username, Password);

            //    bool doesPasswordMatch = BCrypt.CheckPassword(password, myHash);
            //    if (doesPasswordMatch == true)
            //    {
            //        MessageBox.Show("Successfully logged in!");
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Wrong!");
            //    throw;
            //}


            //if (textBoxUser.Text ==)
            
        }

        //Opens Form for sending Recovery Code
        private void buttonForgetPassword_Click(object sender, EventArgs e)
        {
            Email = textboxEmail.Text;
            sendcode sendcode = new sendcode();
            sendcode.Show();
        }

        //Adds User to Table
        private void btn_signup_Click(object sender, EventArgs e)
        {
            try
            {
                name = textBoxUser.Text;
                password = textBoxPassword.Text;
                Email = textboxEmail.Text;
                mySalt = BCrypt.GenerateSalt();
                myHash = BCrypt.HashPassword(password, mySalt);

                if (name == "" || name == "Username")
                {
                    MessageBox.Show("Please type in a Username!");
                }
                else if (password == "" || password == "Password")
                {
                    MessageBox.Show("Please type in a Password!");
                }
                else if (Email == "" || Email == "Email")
                {
                    MessageBox.Show("Please type in an Email!");
                }
                else
                    sqlmanager.AddUser(name, Email, password, myHash);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //If User hovers over Textbox the Text is invisible
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

        private void pictureBoxUserIcon_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxEmailEnter(object sender, EventArgs e)
        {
            if (textboxEmail.Text.Equals("E-Mail"))
            {
                textboxEmail.Text = "";
            }
            textboxEmail.ForeColor = Color.Black;
        }

        private void textboxEmailLeave(object sender, EventArgs e)
        {
            if (textboxEmail.Text.Equals(""))
            {
                textboxEmail.Text = "E-Mail";
            }
            textboxEmail.ForeColor = Color.Silver;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            login l = new login();
            m.Show();
            l.Hide();
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
