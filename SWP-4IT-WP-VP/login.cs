﻿using System;
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
        public static string Password;
        

        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Manager.createTable();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Username = txtbox_username.Text;
            Password = txtbox_password.Text;
            menu menu = new menu();
            menu.Show();
        }

        //Bcrypt hashes password
        public static void password()
        {
            Random rnd = new Random();
            int salt = rnd.Next(5);
            string stringsalt = Convert.ToString(salt);
            BCrypt.HashPassword(Password, stringsalt);
                        
        }

    }
}
