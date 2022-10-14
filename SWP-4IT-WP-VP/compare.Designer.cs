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
            this.dgv_Base = new System.Windows.Forms.DataGridView();
            this.dgv_compareBase = new System.Windows.Forms.DataGridView();
            this.cb_Base = new System.Windows.Forms.ComboBox();
            this.cb_compareBase = new System.Windows.Forms.ComboBox();
            this.btn_compare = new System.Windows.Forms.Button();
            this.lbl_inv1 = new System.Windows.Forms.Label();
            this.lbl_compareInv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compareBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Base
            // 
            this.dgv_Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Base.Location = new System.Drawing.Point(31, 96);
            this.dgv_Base.Name = "dgv_Base";
            this.dgv_Base.Size = new System.Drawing.Size(558, 304);
            this.dgv_Base.TabIndex = 0;
            // 
            // dgv_compareBase
            // 
            this.dgv_compareBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compareBase.Location = new System.Drawing.Point(613, 96);
            this.dgv_compareBase.Name = "dgv_compareBase";
            this.dgv_compareBase.Size = new System.Drawing.Size(578, 304);
            this.dgv_compareBase.TabIndex = 1;
            // 
            // cb_Base
            // 
            this.cb_Base.FormattingEnabled = true;
            this.cb_Base.Location = new System.Drawing.Point(42, 56);
            this.cb_Base.Name = "cb_Base";
            this.cb_Base.Size = new System.Drawing.Size(121, 21);
            this.cb_Base.TabIndex = 2;
            // 
            // cb_compareBase
            // 
            this.cb_compareBase.FormattingEnabled = true;
            this.cb_compareBase.Location = new System.Drawing.Point(627, 56);
            this.cb_compareBase.Name = "cb_compareBase";
            this.cb_compareBase.Size = new System.Drawing.Size(121, 21);
            this.cb_compareBase.TabIndex = 3;
            // 
            // btn_compare
            // 
            this.btn_compare.Location = new System.Drawing.Point(438, 406);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(310, 47);
            this.btn_compare.TabIndex = 4;
            this.btn_compare.Text = "compare";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click_1);
            // 
            // lbl_inv1
            // 
            this.lbl_inv1.AutoSize = true;
            this.lbl_inv1.Location = new System.Drawing.Point(28, 40);
            this.lbl_inv1.Name = "lbl_inv1";
            this.lbl_inv1.Size = new System.Drawing.Size(81, 13);
            this.lbl_inv1.TabIndex = 5;
            this.lbl_inv1.Text = "Base-Inventory:";
            // 
            // lbl_compareInv
            // 
            this.lbl_compareInv.AutoSize = true;
            this.lbl_compareInv.Location = new System.Drawing.Point(604, 40);
            this.lbl_compareInv.Name = "lbl_compareInv";
            this.lbl_compareInv.Size = new System.Drawing.Size(64, 13);
            this.lbl_compareInv.TabIndex = 6;
            this.lbl_compareInv.Text = "Compare to:";
            // 
            // compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 507);
            this.Controls.Add(this.lbl_compareInv);
            this.Controls.Add(this.lbl_inv1);
            this.Controls.Add(this.btn_compare);
            this.Controls.Add(this.cb_compareBase);
            this.Controls.Add(this.cb_Base);
            this.Controls.Add(this.dgv_compareBase);
            this.Controls.Add(this.dgv_Base);
            this.Name = "compare";
            this.Text = "Compare";
            this.Load += new System.EventHandler(this.Compare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compareBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Base;
        private System.Windows.Forms.DataGridView dgv_compareBase;
        private System.Windows.Forms.ComboBox cb_Base;
        private System.Windows.Forms.ComboBox cb_compareBase;
        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.Label lbl_inv1;
        private System.Windows.Forms.Label lbl_compareInv;
    }
}