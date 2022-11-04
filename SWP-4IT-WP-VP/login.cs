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

        public static string Username;
        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            sqlmanager.createDatabase("Intersport");
            sqlmanager.createTableProducts("Products");

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            menu m = new menu();
            login l = new login();

            try
            {
                //User and Password are right
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong!");
                throw;
            }

            m.Show();
            l.Hide();

        }

        private void buttonForgetPassword_Click(object sender, EventArgs e)
        {

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
