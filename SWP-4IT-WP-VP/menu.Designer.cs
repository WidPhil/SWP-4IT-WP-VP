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
            this.btn_NewInv = new System.Windows.Forms.Button();
            this.btn_CompareInv = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_requirements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewInv
            // 
            this.btn_NewInv.Location = new System.Drawing.Point(57, 95);
            this.btn_NewInv.Name = "btn_NewInv";
            this.btn_NewInv.Size = new System.Drawing.Size(167, 50);
            this.btn_NewInv.TabIndex = 0;
            this.btn_NewInv.Text = "New Inventory";
            this.btn_NewInv.UseVisualStyleBackColor = true;
            // 
            // btn_CompareInv
            // 
            this.btn_CompareInv.Location = new System.Drawing.Point(57, 212);
            this.btn_CompareInv.Name = "btn_CompareInv";
            this.btn_CompareInv.Size = new System.Drawing.Size(167, 49);
            this.btn_CompareInv.TabIndex = 1;
            this.btn_CompareInv.Text = "Compare Inventorys";
            this.btn_CompareInv.UseVisualStyleBackColor = true;
            // 
            // btn_orders
            // 
            this.btn_orders.Location = new System.Drawing.Point(57, 267);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(167, 52);
            this.btn_orders.TabIndex = 2;
            this.btn_orders.Text = "Order Items";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_requirements
            // 
            this.btn_requirements.Location = new System.Drawing.Point(57, 152);
            this.btn_requirements.Name = "btn_requirements";
            this.btn_requirements.Size = new System.Drawing.Size(167, 54);
            this.btn_requirements.TabIndex = 3;
            this.btn_requirements.Text = "Requirements";
            this.btn_requirements.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 450);
            this.Controls.Add(this.btn_requirements);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.btn_CompareInv);
            this.Controls.Add(this.btn_NewInv);
            this.Name = "menu";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewInv;
        private System.Windows.Forms.Button btn_CompareInv;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button btn_requirements;
    }
}