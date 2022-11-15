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
       
        public sendcode()
        {
            InitializeComponent();
        }

        private void btn_SendCode_Click(object sender, EventArgs e)
        {
            string from;
            string to;
            string randomCode;

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

            //recovery Code in Datenbank speichern
        }
    }
}
