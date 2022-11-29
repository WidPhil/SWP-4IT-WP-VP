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
        public static string Username = sendcode.Username;
        public static string Email = sendcode.Email;
        public NewPassword()
        {
            InitializeComponent();
        }

        private void btn_recover_Click(object sender, EventArgs e)
        {
            string newPassword = txtbox_newPassword.Text;
            if (newPassword == txtbox_confirmation.Text)
            {
                sqlmanager.NewPassword(newPassword, Username, Email);
                login l = new login();
                l.Show();
            }
            MessageBox.Show("Password changed successfully");
        }
    }
}
