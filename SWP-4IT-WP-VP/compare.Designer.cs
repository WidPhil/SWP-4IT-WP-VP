
namespace SWP_4IT_WP_VP
{
    partial class compare
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
            this.dgv_Base = new System.Windows.Forms.DataGridView();
            this.dgv_compareTo = new System.Windows.Forms.DataGridView();
            this.cb_base = new System.Windows.Forms.ComboBox();
            this.cb_compare = new System.Windows.Forms.ComboBox();
            this.lbl_BaseInventory = new System.Windows.Forms.Label();
            this.lbl_compareTo = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compareTo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_compare
            // 
            this.btn_compare.Location = new System.Drawing.Point(348, 417);
            this.btn_compare.Margin = new System.Windows.Forms.Padding(2);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(238, 32);
            this.btn_compare.TabIndex = 0;
            this.btn_compare.Text = "Compare";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            // 
            // dgv_Base
            // 
            this.dgv_Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Base.Location = new System.Drawing.Point(26, 119);
            this.dgv_Base.Name = "dgv_Base";
            this.dgv_Base.Size = new System.Drawing.Size(425, 255);
            this.dgv_Base.TabIndex = 2;
            // 
            // dgv_compareTo
            // 
            this.dgv_compareTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compareTo.Location = new System.Drawing.Point(496, 119);
            this.dgv_compareTo.Name = "dgv_compareTo";
            this.dgv_compareTo.Size = new System.Drawing.Size(469, 255);
            this.dgv_compareTo.TabIndex = 3;
            // 
            // cb_base
            // 
            this.cb_base.FormattingEnabled = true;
            this.cb_base.Location = new System.Drawing.Point(26, 92);
            this.cb_base.Name = "cb_base";
            this.cb_base.Size = new System.Drawing.Size(121, 21);
            this.cb_base.TabIndex = 4;
            // 
            // cb_compare
            // 
            this.cb_compare.FormattingEnabled = true;
            this.cb_compare.Location = new System.Drawing.Point(496, 92);
            this.cb_compare.Name = "cb_compare";
            this.cb_compare.Size = new System.Drawing.Size(121, 21);
            this.cb_compare.TabIndex = 5;
            // 
            // lbl_BaseInventory
            // 
            this.lbl_BaseInventory.AutoSize = true;
            this.lbl_BaseInventory.Location = new System.Drawing.Point(23, 76);
            this.lbl_BaseInventory.Name = "lbl_BaseInventory";
            this.lbl_BaseInventory.Size = new System.Drawing.Size(81, 13);
            this.lbl_BaseInventory.TabIndex = 6;
            this.lbl_BaseInventory.Text = "Base Inventory:";
            // 
            // lbl_compareTo
            // 
            this.lbl_compareTo.AutoSize = true;
            this.lbl_compareTo.Location = new System.Drawing.Point(493, 76);
            this.lbl_compareTo.Name = "lbl_compareTo";
            this.lbl_compareTo.Size = new System.Drawing.Size(64, 13);
            this.lbl_compareTo.TabIndex = 7;
            this.lbl_compareTo.Text = "Compare to:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(917, 472);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(69, 19);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(149, 13);
            this.lbl_info.TabIndex = 9;
            this.lbl_info.Text = "In this form, you can compare ";
            // 
            // compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 507);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_compareTo);
            this.Controls.Add(this.lbl_BaseInventory);
            this.Controls.Add(this.cb_compare);
            this.Controls.Add(this.cb_base);
            this.Controls.Add(this.dgv_compareTo);
            this.Controls.Add(this.dgv_Base);
            this.Controls.Add(this.btn_compare);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "compare";
            this.Text = "compare";
            this.Load += new System.EventHandler(this.compare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compareTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.DataGridView dgv_Base;
        private System.Windows.Forms.DataGridView dgv_compareTo;
        private System.Windows.Forms.ComboBox cb_base;
        private System.Windows.Forms.ComboBox cb_compare;
        private System.Windows.Forms.Label lbl_BaseInventory;
        private System.Windows.Forms.Label lbl_compareTo;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_info;
    }
}