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
            this.cb_tables = new System.Windows.Forms.ComboBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.dgv_convert = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_convert)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_excel
            // 
            this.lbl_excel.AutoSize = true;
            this.lbl_excel.Location = new System.Drawing.Point(13, 22);
            this.lbl_excel.Name = "lbl_excel";
            this.lbl_excel.Size = new System.Drawing.Size(309, 13);
            this.lbl_excel.TabIndex = 0;
            this.lbl_excel.Text = "To convert a table into excel, select a table and Click the button";
            // 
            // cb_tables
            // 
            this.cb_tables.FormattingEnabled = true;
            this.cb_tables.Location = new System.Drawing.Point(30, 75);
            this.cb_tables.Name = "cb_tables";
            this.cb_tables.Size = new System.Drawing.Size(346, 21);
            this.cb_tables.TabIndex = 1;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(30, 162);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(180, 37);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Save";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // dgv_convert
            // 
            this.dgv_convert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_convert.Location = new System.Drawing.Point(382, 75);
            this.dgv_convert.Name = "dgv_convert";
            this.dgv_convert.Size = new System.Drawing.Size(320, 142);
            this.dgv_convert.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(647, 334);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit Form";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(30, 133);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 5;
            this.btn_preview.Text = "preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 369);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgv_convert);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.cb_tables);
            this.Controls.Add(this.lbl_excel);
            this.Name = "converter";
            this.Text = "converter";
            this.Load += new System.EventHandler(this.converter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_convert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_excel;
        private System.Windows.Forms.ComboBox cb_tables;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.DataGridView dgv_convert;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_preview;
    }
}