namespace SWP_4IT_WP_VP
{
    partial class NewPassword
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
            this.lbl_newPwd = new System.Windows.Forms.Label();
            this.txtbox_newPassword = new System.Windows.Forms.TextBox();
            this.txtbox_confirmation = new System.Windows.Forms.TextBox();
            this.lbl_confirmation = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_newPwd
            // 
            this.lbl_newPwd.AutoSize = true;
            this.lbl_newPwd.Location = new System.Drawing.Point(12, 39);
            this.lbl_newPwd.Name = "lbl_newPwd";
            this.lbl_newPwd.Size = new System.Drawing.Size(81, 13);
            this.lbl_newPwd.TabIndex = 0;
            this.lbl_newPwd.Text = "New Password:";
            // 
            // txtbox_newPassword
            // 
            this.txtbox_newPassword.Location = new System.Drawing.Point(15, 68);
            this.txtbox_newPassword.Name = "txtbox_newPassword";
            this.txtbox_newPassword.Size = new System.Drawing.Size(216, 20);
            this.txtbox_newPassword.TabIndex = 1;
            // 
            // txtbox_confirmation
            // 
            this.txtbox_confirmation.Location = new System.Drawing.Point(15, 162);
            this.txtbox_confirmation.Name = "txtbox_confirmation";
            this.txtbox_confirmation.Size = new System.Drawing.Size(216, 20);
            this.txtbox_confirmation.TabIndex = 2;
            // 
            // lbl_confirmation
            // 
            this.lbl_confirmation.AutoSize = true;
            this.lbl_confirmation.Location = new System.Drawing.Point(12, 131);
            this.lbl_confirmation.Name = "lbl_confirmation";
            this.lbl_confirmation.Size = new System.Drawing.Size(146, 13);
            this.lbl_confirmation.TabIndex = 3;
            this.lbl_confirmation.Text = "Type in new Password again:";
            // 
            // btn_recover
            // 
            this.btn_recover.Location = new System.Drawing.Point(64, 200);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(128, 23);
            this.btn_recover.TabIndex = 4;
            this.btn_recover.Text = "Recover Password";
            this.btn_recover.UseVisualStyleBackColor = true;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 235);
            this.Controls.Add(this.btn_recover);
            this.Controls.Add(this.lbl_confirmation);
            this.Controls.Add(this.txtbox_confirmation);
            this.Controls.Add(this.txtbox_newPassword);
            this.Controls.Add(this.lbl_newPwd);
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newPwd;
        private System.Windows.Forms.TextBox txtbox_newPassword;
        private System.Windows.Forms.TextBox txtbox_confirmation;
        private System.Windows.Forms.Label lbl_confirmation;
        private System.Windows.Forms.Button btn_recover;
    }
}