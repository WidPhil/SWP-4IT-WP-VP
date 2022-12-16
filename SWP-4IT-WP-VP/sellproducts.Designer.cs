namespace SWP_4IT_WP_VP
{
    partial class sellproducts
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
            this.lbl_minimum = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
            this.lbl_value2 = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.cb_chooseproduct = new System.Windows.Forms.ComboBox();
            this.lbl_product = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(135, 336);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(251, 39);
            this.btn_order.TabIndex = 0;
            this.btn_order.Text = "ORDER";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // lbl_minimum
            // 
            this.lbl_minimum.AutoSize = true;
            this.lbl_minimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimum.Location = new System.Drawing.Point(12, 69);
            this.lbl_minimum.Name = "lbl_minimum";
            this.lbl_minimum.Size = new System.Drawing.Size(49, 24);
            this.lbl_minimum.TabIndex = 1;
            this.lbl_minimum.Text = "MIN:";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max.Location = new System.Drawing.Point(304, 69);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(106, 24);
            this.lbl_max.TabIndex = 2;
            this.lbl_max.Text = "CURRENT:";
            // 
            // lbl_value2
            // 
            this.lbl_value2.AutoSize = true;
            this.lbl_value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value2.Location = new System.Drawing.Point(97, 69);
            this.lbl_value2.Name = "lbl_value2";
            this.lbl_value2.Size = new System.Drawing.Size(72, 24);
            this.lbl_value2.TabIndex = 3;
            this.lbl_value2.Text = "VALUE";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.Location = new System.Drawing.Point(416, 69);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(72, 24);
            this.lbl_value.TabIndex = 4;
            this.lbl_value.Text = "VALUE";
            // 
            // cb_chooseproduct
            // 
            this.cb_chooseproduct.FormattingEnabled = true;
            this.cb_chooseproduct.Location = new System.Drawing.Point(16, 31);
            this.cb_chooseproduct.Name = "cb_chooseproduct";
            this.cb_chooseproduct.Size = new System.Drawing.Size(328, 21);
            this.cb_chooseproduct.TabIndex = 5;
            this.cb_chooseproduct.SelectedIndexChanged += new System.EventHandler(this.cb_chooseproduct_SelectedIndexChanged);
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(16, 12);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(47, 13);
            this.lbl_product.TabIndex = 6;
            this.lbl_product.Text = "Product:";
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 409);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.cb_chooseproduct);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_value2);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.lbl_minimum);
            this.Controls.Add(this.btn_order);
            this.Name = "products";
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label lbl_minimum;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Label lbl_value2;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.ComboBox cb_chooseproduct;
        private System.Windows.Forms.Label lbl_product;
    }
}