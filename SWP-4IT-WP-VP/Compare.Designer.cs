namespace SWP_4IT_WP_VP
{
    partial class Compare
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
            this.btn_compare = new System.Windows.Forms.Button();
            this.lbl_chooseINV = new System.Windows.Forms.Label();
            this.cb_chooseTable = new System.Windows.Forms.ComboBox();
            this.lbl_Compare = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_compare
            // 
            this.btn_compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compare.Location = new System.Drawing.Point(19, 199);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(259, 51);
            this.btn_compare.TabIndex = 1;
            this.btn_compare.Text = "Compare";
            this.btn_compare.UseVisualStyleBackColor = true;
            // 
            // lbl_chooseINV
            // 
            this.lbl_chooseINV.AutoSize = true;
            this.lbl_chooseINV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chooseINV.Location = new System.Drawing.Point(68, 9);
            this.lbl_chooseINV.Name = "lbl_chooseINV";
            this.lbl_chooseINV.Size = new System.Drawing.Size(154, 24);
            this.lbl_chooseINV.TabIndex = 2;
            this.lbl_chooseINV.Text = "choose Inventory";
            // 
            // cb_chooseTable
            // 
            this.cb_chooseTable.FormattingEnabled = true;
            this.cb_chooseTable.Location = new System.Drawing.Point(16, 36);
            this.cb_chooseTable.Name = "cb_chooseTable";
            this.cb_chooseTable.Size = new System.Drawing.Size(263, 21);
            this.cb_chooseTable.TabIndex = 3;
            this.cb_chooseTable.SelectedIndexChanged += new System.EventHandler(this.cb_chooseTable_SelectedIndexChanged);
            // 
            // lbl_Compare
            // 
            this.lbl_Compare.AutoSize = true;
            this.lbl_Compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compare.Location = new System.Drawing.Point(90, 124);
            this.lbl_Compare.Name = "lbl_Compare";
            this.lbl_Compare.Size = new System.Drawing.Size(121, 24);
            this.lbl_Compare.TabIndex = 4;
            this.lbl_Compare.Text = "Compare To:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 275);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_Compare);
            this.Controls.Add(this.cb_chooseTable);
            this.Controls.Add(this.lbl_chooseINV);
            this.Controls.Add(this.btn_compare);
            this.Name = "Compare";
            this.Text = "Compare";
            this.Load += new System.EventHandler(this.Compare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.Label lbl_chooseINV;
        private System.Windows.Forms.ComboBox cb_chooseTable;
        private System.Windows.Forms.Label lbl_Compare;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}