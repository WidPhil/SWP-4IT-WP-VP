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

        
        public static string password;
        public static string name;
        public static string Email;
        public static string mySalt;
        public static string FirstHash;
        public static string checkHash;
        public static string PlainText;
        public login()
        {
            InitializeComponent();
        }

        //Creates Databases and Tables
        private void Login_Load(object sender, EventArgs e)
        {
            sqlmanager.createDatabase("Intersport");
            //sqlmanager.createTableInventory("Inventory");
            sqlmanager.createTableUsers("Users");
            sqlmanager.createTableRequirements("Requirements");
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
                FirstHash = BCrypt.HashPassword(password, mySalt);

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
                    sqlmanager.AddUser(name, Email, FirstHash);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Opens Forms
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            name = textBoxUser.Text;
            PlainText = textBoxPassword.Text;
            checkHash = sqlmanager.ReadPassword(name);

            bool isValid = BCrypt.CheckPassword(PlainText, checkHash);
            if (isValid == true)
            {
                MessageBox.Show("Valid Password!");
                
                menu m = new menu();
                m.Show();
                converter excel = new converter();
                excel.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password!");
            }
        }

        #region Textboxbehavior
        //If User hovers over Username-Textbox the Text is cleared
        private void textBoxUserEnter(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Equals("Username"))
            {
                textBoxUser.Text = "";
            }
            textBoxUser.ForeColor = Color.Black;
        }

        //If User doesn't hover over Username-textbox anymore the Text shows up
        private void textBoxUserLeave(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Equals(""))
            {
                textBoxUser.Text = "Username";
            }
            textBoxUser.ForeColor = Color.Silver;
        }

        //If User hovers over Password the text is cleared
        private void textBoxPasswordEnter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals("Password"))
            {
                textBoxPassword.Text = "";
            }
            textBoxPassword.ForeColor = Color.Black;
        }

        //If User doesn't hover over Password anymore the text shows up
        private void textBoxPasswordLeave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals(""))
            {
                textBoxPassword.Text = "Password";
            }
            textBoxPassword.ForeColor = Color.Silver;
        }
        
        //If User hovers over Email the text gets cleared
        private void textboxEmailEnter(object sender, EventArgs e)
        {
            if (textboxEmail.Text.Equals("E-Mail"))
            {
                textboxEmail.Text = "";
            }
            textboxEmail.ForeColor = Color.Black;
        }

        //If User doesn't hover over Email anymore the text shows up
        private void textboxEmailLeave(object sender, EventArgs e)
        {
            if (textboxEmail.Text.Equals(""))
            {
                textboxEmail.Text = "E-Mail";
            }
            textboxEmail.ForeColor = Color.Silver;
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
        }
    }
}
