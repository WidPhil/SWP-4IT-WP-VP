namespace SWP_4IT_WP_VP
{
    partial class orders
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
            this.cb_productgroup = new System.Windows.Forms.ComboBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbl_productgroup = new System.Windows.Forms.Label();
            this.NUD__Amount = new System.Windows.Forms.NumericUpDown();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NUD__Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_productgroup
            // 
            this.cb_productgroup.FormattingEnabled = true;
            this.cb_productgroup.Items.AddRange(new object[] {
            "Schuhe",
            "T-Shirt",
            "Jeans"});
            this.cb_productgroup.Location = new System.Drawing.Point(55, 39);
            this.cb_productgroup.Name = "cb_productgroup";
            this.cb_productgroup.Size = new System.Drawing.Size(121, 21);
            this.cb_productgroup.TabIndex = 5;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(55, 319);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(120, 23);
            this.btn_order.TabIndex = 6;
            this.btn_order.Text = "order products";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(55, 153);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kid";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(55, 177);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Men";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lbl_productgroup
            // 
            this.lbl_productgroup.AutoSize = true;
            this.lbl_productgroup.Location = new System.Drawing.Point(42, 13);
            this.lbl_productgroup.Name = "lbl_productgroup";
            this.lbl_productgroup.Size = new System.Drawing.Size(77, 13);
            this.lbl_productgroup.TabIndex = 9;
            this.lbl_productgroup.Text = "Product group:";
            // 
            // NUD__Amount
            // 
            this.NUD__Amount.Location = new System.Drawing.Point(55, 250);
            this.NUD__Amount.Name = "NUD__Amount";
            this.NUD__Amount.Size = new System.Drawing.Size(120, 20);
            this.NUD__Amount.TabIndex = 10;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(45, 231);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(46, 13);
            this.lbl_amount.TabIndex = 11;
            this.lbl_amount.Text = "Amount:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(55, 200);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Women";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 422);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.NUD__Amount);
            this.Controls.Add(this.lbl_productgroup);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.cb_productgroup);
            this.Name = "orders";
            this.Text = "orders";
            this.Load += new System.EventHandler(this.orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD__Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_productgroup;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbl_productgroup;
        private System.Windows.Forms.NumericUpDown NUD__Amount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}