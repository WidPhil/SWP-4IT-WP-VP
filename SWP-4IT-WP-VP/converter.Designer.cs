namespace SWP_4IT_WP_VP
{
    partial class converter
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
            this.lbl_excel = new System.Windows.Forms.Label();
            this.cb_inventories = new System.Windows.Forms.ComboBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_excel
            // 
            this.lbl_excel.AutoSize = true;
            this.lbl_excel.Location = new System.Drawing.Point(13, 22);
            this.lbl_excel.Name = "lbl_excel";
            this.lbl_excel.Size = new System.Drawing.Size(363, 13);
            this.lbl_excel.TabIndex = 0;
            this.lbl_excel.Text = "To convert an Inventory into excel, select an Inventory and Click the button";
            // 
            // cb_inventories
            // 
            this.cb_inventories.FormattingEnabled = true;
            this.cb_inventories.Items.AddRange(new object[] {
            "Products",
            "Users",
            "Inventory"});
            this.cb_inventories.Location = new System.Drawing.Point(30, 75);
            this.cb_inventories.Name = "cb_inventories";
            this.cb_inventories.Size = new System.Drawing.Size(346, 21);
            this.cb_inventories.TabIndex = 1;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(104, 136);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(180, 37);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Save";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(393, 258);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.cb_inventories);
            this.Controls.Add(this.lbl_excel);
            this.Name = "converter";
            this.Text = "converter";
            this.Load += new System.EventHandler(this.converter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_excel;
        private System.Windows.Forms.ComboBox cb_inventories;
        private System.Windows.Forms.Button btn_convert;
    }
}