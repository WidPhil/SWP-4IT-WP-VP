
namespace SWP_4IT_WP_VP
{
    partial class sendcode
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
            this.btn_sendcode = new System.Windows.Forms.Button();
            this.txtbox_Email = new System.Windows.Forms.TextBox();
            this.btn_recover = new System.Windows.Forms.Button();
            this.txtbox_verificationcode = new System.Windows.Forms.TextBox();
            this.lbl_verify = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sendcode
            // 
            this.btn_sendcode.Location = new System.Drawing.Point(12, 63);
            this.btn_sendcode.Name = "btn_sendcode";
            this.btn_sendcode.Size = new System.Drawing.Size(162, 27);
            this.btn_sendcode.TabIndex = 2;
            this.btn_sendcode.Text = "send Code";
            this.btn_sendcode.UseVisualStyleBackColor = true;
            this.btn_sendcode.Click += new System.EventHandler(this.btn_SendCode_Click);
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.Location = new System.Drawing.Point(12, 26);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(204, 20);
            this.txtbox_Email.TabIndex = 1;
            // 
            // btn_recover
            // 
            this.btn_recover.Location = new System.Drawing.Point(12, 183);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(162, 31);
            this.btn_recover.TabIndex = 4;
            this.btn_recover.Text = "recover Password";
            this.btn_recover.UseVisualStyleBackColor = true;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            // 
            // txtbox_verificationcode
            // 
            this.txtbox_verificationcode.Location = new System.Drawing.Point(12, 146);
            this.txtbox_verificationcode.Name = "txtbox_verificationcode";
            this.txtbox_verificationcode.Size = new System.Drawing.Size(204, 20);
            this.txtbox_verificationcode.TabIndex = 3;
            // 
            // lbl_verify
            // 
            this.lbl_verify.AutoSize = true;
            this.lbl_verify.Location = new System.Drawing.Point(13, 127);
            this.lbl_verify.Name = "lbl_verify";
            this.lbl_verify.Size = new System.Drawing.Size(88, 13);
            this.lbl_verify.TabIndex = 4;
            this.lbl_verify.Text = "Verfication Code:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(12, 7);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(35, 13);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "Email:";
            // 
            // sendcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 247);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_verify);
            this.Controls.Add(this.txtbox_verificationcode);
            this.Controls.Add(this.btn_recover);
            this.Controls.Add(this.txtbox_Email);
            this.Controls.Add(this.btn_sendcode);
            this.Name = "sendcode";
            this.Text = "sendcode";
            this.Load += new System.EventHandler(this.sendcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sendcode;
        private System.Windows.Forms.TextBox txtbox_Email;
        private System.Windows.Forms.Button btn_recover;
        private System.Windows.Forms.TextBox txtbox_verificationcode;
        private System.Windows.Forms.Label lbl_verify;
        private System.Windows.Forms.Label lbl_Email;
    }
}