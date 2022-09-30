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
    public partial class Login : Form
    {
        public static string Username;
        public static string Password;


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Username = txtbox_username.Text;
            Password = txtbox_password.Text;

        }

        //Bcrypt hashes password
        public static void password()
        {
            
                        
        }

    }
}
