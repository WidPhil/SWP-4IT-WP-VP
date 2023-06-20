
namespace SWP_4IT_WP_VP
{
    partial class editProducts
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_Brand = new System.Windows.Forms.TextBox();
            this.txtbox_Size = new System.Windows.Forms.TextBox();
            this.txtbox_product = new System.Windows.Forms.TextBox();
            this.txtbox_color = new System.Windows.Forms.TextBox();
            this.NUD_Price = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(27, 367);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 35);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name of the Product:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Size:";
            // 
            // txtbox_Brand
            // 
            this.txtbox_Brand.Location = new System.Drawing.Point(27, 154);
            this.txtbox_Brand.Name = "txtbox_Brand";
            this.txtbox_Brand.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Brand.TabIndex = 11;
            // 
            // txtbox_Size
            // 
            this.txtbox_Size.Location = new System.Drawing.Point(27, 116);
            this.txtbox_Size.Name = "txtbox_Size";
            this.txtbox_Size.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Size.TabIndex = 12;
            // 
            // txtbox_product
            // 
            this.txtbox_product.Location = new System.Drawing.Point(27, 75);
            this.txtbox_product.Name = "txtbox_product";
            this.txtbox_product.Size = new System.Drawing.Size(100, 20);
            this.txtbox_product.TabIndex = 13;
            // 
            // txtbox_color
            // 
            this.txtbox_color.Location = new System.Drawing.Point(27, 192);
            this.txtbox_color.Name = "txtbox_color";
            this.txtbox_color.Size = new System.Drawing.Size(100, 20);
            this.txtbox_color.TabIndex = 14;
            // 
            // NUD_Price
            // 
            this.NUD_Price.Location = new System.Drawing.Point(27, 233);
            this.NUD_Price.Name = "NUD_Price";
            this.NUD_Price.Size = new System.Drawing.Size(120, 20);
            this.NUD_Price.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 323);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(537, 441);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 17;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // editProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 516);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NUD_Price);
            this.Controls.Add(this.txtbox_color);
            this.Controls.Add(this.txtbox_product);
            this.Controls.Add(this.txtbox_Size);
            this.Controls.Add(this.txtbox_Brand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "editProducts";
            this.Text = "editProducts";
            this.Load += new System.EventHandler(this.editProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_Brand;
        private System.Windows.Forms.TextBox txtbox_Size;
        private System.Windows.Forms.TextBox txtbox_product;
        private System.Windows.Forms.TextBox txtbox_color;
        private System.Windows.Forms.NumericUpDown NUD_Price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_preview;
    }
}