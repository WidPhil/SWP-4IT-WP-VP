namespace SWP_4IT_WP_VP
{
    partial class menu
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
            this.btn_compare = new System.Windows.Forms.Button();
            this.btn_requirements = new System.Windows.Forms.Button();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_showInv = new System.Windows.Forms.Button();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(12, 95);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(260, 24);
            this.btn_order.TabIndex = 0;
            this.btn_order.Text = "Order Products";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_compare
            // 
            this.btn_compare.Location = new System.Drawing.Point(12, 135);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(260, 23);
            this.btn_compare.TabIndex = 1;
            this.btn_compare.Text = "Compare Inventories";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            // 
            // btn_requirements
            // 
            this.btn_requirements.Location = new System.Drawing.Point(12, 182);
            this.btn_requirements.Name = "btn_requirements";
            this.btn_requirements.Size = new System.Drawing.Size(260, 24);
            this.btn_requirements.TabIndex = 2;
            this.btn_requirements.Text = "Requirements";
            this.btn_requirements.UseVisualStyleBackColor = true;
            this.btn_requirements.Click += new System.EventHandler(this.btn_requirements_Click);
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(13, 13);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(49, 20);
            this.lbl_menu.TabIndex = 3;
            this.lbl_menu.Text = "Menu";
            // 
            // btn_showInv
            // 
            this.btn_showInv.Location = new System.Drawing.Point(12, 228);
            this.btn_showInv.Name = "btn_showInv";
            this.btn_showInv.Size = new System.Drawing.Size(260, 26);
            this.btn_showInv.TabIndex = 4;
            this.btn_showInv.Text = "Show Inventory";
            this.btn_showInv.UseVisualStyleBackColor = true;
            this.btn_showInv.Click += new System.EventHandler(this.btn_showInv_Click);
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Location = new System.Drawing.Point(17, 54);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(34, 13);
            this.lbl_hello.TabIndex = 5;
            this.lbl_hello.Text = "Hello:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(55, 54);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(294, 372);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.btn_showInv);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.btn_requirements);
            this.Controls.Add(this.btn_compare);
            this.Controls.Add(this.btn_order);
            this.Name = "menu";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.Button btn_requirements;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_showInv;
        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.Label lbl_name;
    }
}