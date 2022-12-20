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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_excel
            // 
            this.lbl_excel.AutoSize = true;
            this.lbl_excel.Location = new System.Drawing.Point(17, 27);
            this.lbl_excel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_excel.Name = "lbl_excel";
            this.lbl_excel.Size = new System.Drawing.Size(477, 17);
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
            this.cb_inventories.Location = new System.Drawing.Point(40, 92);
            this.cb_inventories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_inventories.Name = "cb_inventories";
            this.cb_inventories.Size = new System.Drawing.Size(460, 24);
            this.cb_inventories.TabIndex = 1;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(139, 167);
            this.btn_convert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(240, 46);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Save";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(524, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.cb_inventories);
            this.Controls.Add(this.lbl_excel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
    }
}