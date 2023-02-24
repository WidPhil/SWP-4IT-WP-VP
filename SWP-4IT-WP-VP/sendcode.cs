using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SWP_4IT_WP_VP
{
    public partial class sendcode : Form
    {
        public static string randomCode;
        public static string Username;
        public static string Email;
        public static string from;
        public static string to;
        public sendcode()
        {
            InitializeComponent();
        }

        //Sends Recovery Code to Email
        private void btn_SendCode_Click(object sender, EventArgs e)
        {
           
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            
            from = "Inventurprogramm-Widauer-Payr@outlook.com";
            to = txtbox_Email.Text;
            string user = txtbox_user.Text;

            try
            {
                if (txtbox_Email.Text == "" || txtbox_user.Text == "")
                {
                    MessageBox.Show("Email or Username is missing");
                }
                else
                {
                    SmtpClient client = new SmtpClient("smtp-mail.outlook.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential("Inventurprogramm-Widauer-Payr@outlook.com", "INV12345?!"),
                        EnableSsl = true
                    };
                    client.Send(from, to, "Recovery Code", "Dear " + user + ", your recovery Code is: " + randomCode);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Opens NewPassword Form if the verification-Code is correct
        private void btn_recover_Click(object sender, EventArgs e)
        {
            if (txtbox_verificationcode.Text == randomCode)
            {
                NewPassword newPassword = new NewPassword();
                newPassword.Show();
            }
            else
            {
                MessageBox.Show("Wrong verification Code");
            }
        }

        //Email wird übertragen
        private void sendcode_Load(object sender, EventArgs e)
        {
            txtbox_Email.Text = login.Email;
        }
    }
}
