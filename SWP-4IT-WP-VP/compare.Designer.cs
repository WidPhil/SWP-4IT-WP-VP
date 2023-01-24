
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_BaseInventory = new System.Windows.Forms.Label();
            this.lbl_compareTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_compare
            // 
            this.btn_compare.Location = new System.Drawing.Point(256, 429);
            this.btn_compare.Margin = new System.Windows.Forms.Padding(2);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(238, 32);
            this.btn_compare.TabIndex = 0;
            this.btn_compare.Text = "Compare";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 255);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(496, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(469, 255);
            this.dataGridView2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(496, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
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
            // compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 507);
            this.Controls.Add(this.lbl_compareTo);
            this.Controls.Add(this.lbl_BaseInventory);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_compare);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "compare";
            this.Text = "compare";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_BaseInventory;
        private System.Windows.Forms.Label lbl_compareTo;
    }
}