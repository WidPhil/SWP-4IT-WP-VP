
namespace SWP_4IT_WP_VP
{
    partial class info
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Excel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(44, 52);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(905, 24);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "This Software uses Databases and Tables to manage your Inventories, you can compa" +
    "re them to eachother";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1037, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "You can also edit the products and order them, if needed, if you don\'t order the " +
    "Products, they will get ordered automatically";
            // 
            // lbl_Excel
            // 
            this.lbl_Excel.AutoSize = true;
            this.lbl_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Excel.Location = new System.Drawing.Point(47, 149);
            this.lbl_Excel.Name = "lbl_Excel";
            this.lbl_Excel.Size = new System.Drawing.Size(508, 24);
            this.lbl_Excel.TabIndex = 2;
            this.lbl_Excel.Text = "Another possibility is that you export the Inventory into Excel";
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 223);
            this.Controls.Add(this.lbl_Excel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_info);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "info";
            this.Text = "info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Excel;
    }
}