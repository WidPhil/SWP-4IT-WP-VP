namespace SWP_4IT_WP_VP
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.labelLoginLogo = new System.Windows.Forms.Label();
            this.labelDeveloped = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.pictureBoxUserIcon = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxLocerIcon = new System.Windows.Forms.PictureBox();
            this.buttonForgetPassword = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(23, 31);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(289, 64);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(339, 450);
            this.pictureBoxLogin.TabIndex = 1;
            this.pictureBoxLogin.TabStop = false;
            // 
            // labelLoginLogo
            // 
            this.labelLoginLogo.AutoSize = true;
            this.labelLoginLogo.BackColor = System.Drawing.Color.White;
            this.labelLoginLogo.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginLogo.Location = new System.Drawing.Point(44, 161);
            this.labelLoginLogo.Name = "labelLoginLogo";
            this.labelLoginLogo.Size = new System.Drawing.Size(269, 64);
            this.labelLoginLogo.TabIndex = 2;
            this.labelLoginLogo.Text = "Welcome to \r\nthe inventory system";
            this.labelLoginLogo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDeveloped
            // 
            this.labelDeveloped.AutoSize = true;
            this.labelDeveloped.BackColor = System.Drawing.Color.White;
            this.labelDeveloped.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloped.Location = new System.Drawing.Point(111, 394);
            this.labelDeveloped.Name = "labelDeveloped";
            this.labelDeveloped.Size = new System.Drawing.Size(218, 32);
            this.labelDeveloped.TabIndex = 3;
            this.labelDeveloped.Text = "Developed By\r\nPayr Vanessa and Philip Widauer";
            this.labelDeveloped.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.SystemColors.Control;
            this.labelLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(351, 92);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(244, 27);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login to your account";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUser.Location = new System.Drawing.Point(384, 183);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(369, 25);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.Text = "Username";
            this.textBoxUser.MouseEnter += new System.EventHandler(this.textBoxUserEnter);
            this.textBoxUser.MouseLeave += new System.EventHandler(this.textBoxUserLeave);
            // 
            // pictureBoxUserIcon
            // 
            this.pictureBoxUserIcon.BackColor = System.Drawing.Color.White;
            this.pictureBoxUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserIcon.Image")));
            this.pictureBoxUserIcon.Location = new System.Drawing.Point(355, 153);
            this.pictureBoxUserIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUserIcon.Name = "pictureBoxUserIcon";
            this.pictureBoxUserIcon.Size = new System.Drawing.Size(31, 25);
            this.pictureBoxUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserIcon.TabIndex = 6;
            this.pictureBoxUserIcon.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPassword.Location = new System.Drawing.Point(385, 226);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(369, 25);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.MouseEnter += new System.EventHandler(this.textBoxPasswordEnter);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.textBoxPasswordLeave);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(361, 305);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(188, 33);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxLocerIcon
            // 
            this.pictureBoxLocerIcon.BackColor = System.Drawing.Color.White;
            this.pictureBoxLocerIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLocerIcon.Image")));
            this.pictureBoxLocerIcon.Location = new System.Drawing.Point(356, 226);
            this.pictureBoxLocerIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLocerIcon.Name = "pictureBoxLocerIcon";
            this.pictureBoxLocerIcon.Size = new System.Drawing.Size(29, 25);
            this.pictureBoxLocerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLocerIcon.TabIndex = 10;
            this.pictureBoxLocerIcon.TabStop = false;
            // 
            // buttonForgetPassword
            // 
            this.buttonForgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForgetPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForgetPassword.ForeColor = System.Drawing.Color.Gray;
            this.buttonForgetPassword.Location = new System.Drawing.Point(581, 305);
            this.buttonForgetPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonForgetPassword.Name = "buttonForgetPassword";
            this.buttonForgetPassword.Size = new System.Drawing.Size(172, 33);
            this.buttonForgetPassword.TabIndex = 5;
            this.buttonForgetPassword.Text = "Forget Password?";
            this.buttonForgetPassword.UseVisualStyleBackColor = true;
            this.buttonForgetPassword.Click += new System.EventHandler(this.buttonForgetPassword_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_signup.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Location = new System.Drawing.Point(361, 345);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(188, 30);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // textboxEmail
            // 
            this.textboxEmail.Font = new System.Drawing.Font("Arial", 9F);
            this.textboxEmail.ForeColor = System.Drawing.Color.Silver;
            this.textboxEmail.Location = new System.Drawing.Point(384, 153);
            this.textboxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(369, 25);
            this.textboxEmail.TabIndex = 1;
            this.textboxEmail.Text = "E-Mail";
            this.textboxEmail.Enter += new System.EventHandler(this.textboxEmailEnter);
            this.textboxEmail.Leave += new System.EventHandler(this.textboxEmailLeave);
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.Color.DarkGray;
            this.labelSignUp.Location = new System.Drawing.Point(499, 133);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(259, 16);
            this.labelSignUp.TabIndex = 14;
            this.labelSignUp.Text = "*E-Mail only neccessary at the first login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.textboxEmail);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.buttonForgetPassword);
            this.Controls.Add(this.pictureBoxLocerIcon);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.pictureBoxUserIcon);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelDeveloped);
            this.Controls.Add(this.labelLoginLogo);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.Text = "Intersport Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocerIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label labelLoginLogo;
        private System.Windows.Forms.Label labelDeveloped;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxUserIcon;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxLocerIcon;
        private System.Windows.Forms.Button buttonForgetPassword;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.TextBox textboxEmail;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Button button1;
    }
}