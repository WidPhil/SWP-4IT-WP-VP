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
            this.btn_preview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_convert)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_excel
            // 
            this.lbl_excel.AutoSize = true;
            this.lbl_excel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_excel.Location = new System.Drawing.Point(4, 9);
            this.lbl_excel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_excel.Name = "lbl_excel";
            this.lbl_excel.Size = new System.Drawing.Size(324, 22);
            this.lbl_excel.TabIndex = 0;
            this.lbl_excel.Text = "Save a table. Convert into an excel sheet!\r\n";
            // 
            // cb_tables
            // 
            this.cb_tables.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tables.FormattingEnabled = true;
            this.cb_tables.Location = new System.Drawing.Point(8, 83);
            this.cb_tables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_tables.Name = "cb_tables";
            this.cb_tables.Size = new System.Drawing.Size(460, 27);
            this.cb_tables.TabIndex = 1;
            // 
            // btn_convert
            // 
            this.btn_convert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.Location = new System.Drawing.Point(8, 602);
            this.btn_convert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(169, 31);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Save";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // dgv_convert
            // 
            this.dgv_convert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_convert.Location = new System.Drawing.Point(8, 165);
            this.dgv_convert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_convert.Name = "dgv_convert";
            this.dgv_convert.RowHeadersWidth = 51;
            this.dgv_convert.Size = new System.Drawing.Size(774, 418);
            this.dgv_convert.TabIndex = 3;
            // 
            // btn_preview
            // 
            this.btn_preview.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.Location = new System.Drawing.Point(8, 118);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(109, 29);
            this.btn_preview.TabIndex = 5;
            this.btn_preview.Text = "preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_excel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 45);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Choose table";
            // 
            // converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(979, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.dgv_convert);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.cb_tables);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "converter";
            this.Text = "converter";
            this.Load += new System.EventHandler(this.converter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_convert)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_excel;
        private System.Windows.Forms.ComboBox cb_tables;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.DataGridView dgv_convert;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}