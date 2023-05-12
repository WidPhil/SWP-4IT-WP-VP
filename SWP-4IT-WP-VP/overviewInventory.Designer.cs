
namespace SWP_4IT_WP_VP
{
    partial class overviewInventory
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
            this.dgv_Overview = new System.Windows.Forms.DataGridView();
            this.cb_chooseTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Overview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Overview
            // 
            this.dgv_Overview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Overview.Location = new System.Drawing.Point(27, 101);
            this.dgv_Overview.Name = "dgv_Overview";
            this.dgv_Overview.Size = new System.Drawing.Size(794, 385);
            this.dgv_Overview.TabIndex = 0;
            // 
            // cb_chooseTable
            // 
            this.cb_chooseTable.FormattingEnabled = true;
            this.cb_chooseTable.Items.AddRange(new object[] {
            "ThisMonth",
            "LastMonth"});
            this.cb_chooseTable.Location = new System.Drawing.Point(37, 59);
            this.cb_chooseTable.Name = "cb_chooseTable";
            this.cb_chooseTable.Size = new System.Drawing.Size(121, 21);
            this.cb_chooseTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "diese Form braucht man eig nicht";
            // 
            // overviewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_chooseTable);
            this.Controls.Add(this.dgv_Overview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "overviewInventory";
            this.Text = "overviewInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Overview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Overview;
        private System.Windows.Forms.ComboBox cb_chooseTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}