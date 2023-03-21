
namespace SWP_4IT_WP_VP
{
    partial class order
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
            this.btn_order = new System.Windows.Forms.Button();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.nud_product = new System.Windows.Forms.NumericUpDown();
            this.cb_productcolour = new System.Windows.Forms.ComboBox();
            this.lbl_colour = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.cb_productsize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_product)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(93, 374);
            this.btn_order.Margin = new System.Windows.Forms.Padding(2);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(181, 28);
            this.btn_order.TabIndex = 0;
            this.btn_order.Text = "Order Products";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // cb_product
            // 
            this.cb_product.FormattingEnabled = true;
            this.cb_product.Location = new System.Drawing.Point(51, 83);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(248, 21);
            this.cb_product.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Products you want to order";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(48, 111);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(49, 13);
            this.lbl_quantity.TabIndex = 6;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // nud_product
            // 
            this.nud_product.Location = new System.Drawing.Point(51, 127);
            this.nud_product.Name = "nud_product";
            this.nud_product.Size = new System.Drawing.Size(248, 20);
            this.nud_product.TabIndex = 10;
            // 
            // cb_productcolour
            // 
            this.cb_productcolour.FormattingEnabled = true;
            this.cb_productcolour.Location = new System.Drawing.Point(50, 177);
            this.cb_productcolour.Name = "cb_productcolour";
            this.cb_productcolour.Size = new System.Drawing.Size(249, 21);
            this.cb_productcolour.TabIndex = 14;
            // 
            // lbl_colour
            // 
            this.lbl_colour.AutoSize = true;
            this.lbl_colour.Location = new System.Drawing.Point(48, 150);
            this.lbl_colour.Name = "lbl_colour";
            this.lbl_colour.Size = new System.Drawing.Size(39, 13);
            this.lbl_colour.TabIndex = 20;
            this.lbl_colour.Text = "colour:";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(53, 211);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(28, 13);
            this.lbl_size.TabIndex = 22;
            this.lbl_size.Text = "size:";
            // 
            // cb_productsize
            // 
            this.cb_productsize.FormattingEnabled = true;
            this.cb_productsize.Location = new System.Drawing.Point(50, 237);
            this.cb_productsize.Name = "cb_productsize";
            this.cb_productsize.Size = new System.Drawing.Size(249, 21);
            this.cb_productsize.TabIndex = 28;
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 428);
            this.Controls.Add(this.cb_productsize);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.lbl_colour);
            this.Controls.Add(this.cb_productcolour);
            this.Controls.Add(this.nud_product);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_product);
            this.Controls.Add(this.btn_order);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "order";
            this.Text = "order";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.ComboBox cb_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.NumericUpDown nud_product;
        private System.Windows.Forms.ComboBox cb_productcolour;
        private System.Windows.Forms.Label lbl_colour;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.ComboBox cb_productsize;
    }
}