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
        public sendcode()
        {
            InitializeComponent();
        }

        private void btn_SendCode_Click(object sender, EventArgs e)
        {
            string from;
            string to;
            

            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            
            from = "Inventurprogramm-Widauer-Payr@outlook.com";
            to = txtbox_Email.Text;

            SmtpClient client = new SmtpClient("smtp-mail.outlook.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("Inventurprogramm-Widauer-Payr@outlook.com", "INV12345?!"),
                EnableSsl = true
            };
            client.Send(from, to, "Recovery Code", "Your recovery Code is: " + randomCode);

            Email = txtbox_Email.Text;
            //recovery Code in Datenbank speichern
        }

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
    }
}
