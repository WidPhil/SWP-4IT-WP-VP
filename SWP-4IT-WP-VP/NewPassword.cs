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
    public partial class NewPassword : Form
    {
        public static string Username = login.name;
        public static string Email = sendcode.Email;
        //public static string myHash = login.myHash;
        public NewPassword()
        {
            InitializeComponent();
        }

        //Update Password in Table
        private void btn_recover_Click(object sender, EventArgs e)
        {
            string newPassword = txtbox_newPassword.Text;
            string confirmation = txtbox_confirmation.Text;
            try
            {
                if (newPassword == confirmation)
                {
                    string mySalt = BCrypt.GenerateSalt();
                    string newHash = BCrypt.HashPassword(newPassword, mySalt);

                 

                    sqlmanager.NewPassword(newPassword, Username, newHash);
                    MessageBox.Show("worked!");
                    //login l = new login();
                    //l.Show();
                }

               
                //else
                //    sqlmanager.AddUser(Username, Email, newPassword, myHash);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
