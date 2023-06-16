
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compareTo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_compare
            // 
            this.btn_compare.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compare.Location = new System.Drawing.Point(17, 522);
            this.btn_compare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(193, 35);
            this.btn_compare.TabIndex = 0;
            this.btn_compare.Text = "Ready";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            // 
            // dgv_Base
            // 
            this.dgv_Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Base.Location = new System.Drawing.Point(17, 156);
            this.dgv_Base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Base.Name = "dgv_Base";
            this.dgv_Base.RowHeadersWidth = 51;
            this.dgv_Base.Size = new System.Drawing.Size(515, 351);
            this.dgv_Base.TabIndex = 2;
            // 
            // dgv_compareTo
            // 
            this.dgv_compareTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compareTo.Location = new System.Drawing.Point(550, 156);
            this.dgv_compareTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_compareTo.Name = "dgv_compareTo";
            this.dgv_compareTo.RowHeadersWidth = 51;
            this.dgv_compareTo.Size = new System.Drawing.Size(539, 351);
            this.dgv_compareTo.TabIndex = 3;
            // 
            // cb_base
            // 
            this.cb_base.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_base.FormattingEnabled = true;
            this.cb_base.Location = new System.Drawing.Point(17, 115);
            this.cb_base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_base.Name = "cb_base";
            this.cb_base.Size = new System.Drawing.Size(160, 30);
            this.cb_base.TabIndex = 4;
            // 
            // cb_compare
            // 
            this.cb_compare.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_compare.FormattingEnabled = true;
            this.cb_compare.Location = new System.Drawing.Point(550, 115);
            this.cb_compare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_compare.Name = "cb_compare";
            this.cb_compare.Size = new System.Drawing.Size(160, 30);
            this.cb_compare.TabIndex = 5;
            // 
            // lbl_BaseInventory
            // 
            this.lbl_BaseInventory.AutoSize = true;
            this.lbl_BaseInventory.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BaseInventory.Location = new System.Drawing.Point(13, 89);
            this.lbl_BaseInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BaseInventory.Name = "lbl_BaseInventory";
            this.lbl_BaseInventory.Size = new System.Drawing.Size(88, 22);
            this.lbl_BaseInventory.TabIndex = 6;
            this.lbl_BaseInventory.Text = "First table:";
            // 
            // lbl_compareTo
            // 
            this.lbl_compareTo.AutoSize = true;
            this.lbl_compareTo.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compareTo.Location = new System.Drawing.Point(546, 89);
            this.lbl_compareTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_compareTo.Name = "lbl_compareTo";
            this.lbl_compareTo.Size = new System.Drawing.Size(113, 22);
            this.lbl_compareTo.TabIndex = 7;
            this.lbl_compareTo.Text = "Second table:";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(4, 9);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(322, 22);
            this.lbl_info.TabIndex = 9;
            this.lbl_info.Text = "Compare / View tables in your databank!\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 73);
            this.panel1.TabIndex = 10;
            // 
            // compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_compareTo);
            this.Controls.Add(this.lbl_BaseInventory);
            this.Controls.Add(this.cb_compare);
            this.Controls.Add(this.cb_base);
            this.Controls.Add(this.dgv_compareTo);
            this.Controls.Add(this.dgv_Base);
            this.Controls.Add(this.btn_compare);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "compare";
            this.Text = "compare";
            this.Load += new System.EventHandler(this.compare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compareTo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Panel panel1;
    }
}