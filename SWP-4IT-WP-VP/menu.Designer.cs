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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain02 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelMenuLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.panelInventory = new System.Windows.Forms.Panel();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelMain02.SuspendLayout();
            this.panelMenuLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInventory.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMain.Controls.Add(this.panelMain02);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(306, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1117, 724);
            this.panelMain.TabIndex = 7;
            // 
            // panelMain02
            // 
            this.panelMain02.BackColor = System.Drawing.Color.Gray;
            this.panelMain02.Controls.Add(this.buttonExit);
            this.panelMain02.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain02.Location = new System.Drawing.Point(0, 688);
            this.panelMain02.Name = "panelMain02";
            this.panelMain02.Size = new System.Drawing.Size(1117, 36);
            this.panelMain02.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonExit.Location = new System.Drawing.Point(1047, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(70, 36);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelMenuLogo
            // 
            this.panelMenuLogo.Controls.Add(this.pictureBox1);
            this.panelMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLogo.Name = "panelMenuLogo";
            this.panelMenuLogo.Size = new System.Drawing.Size(306, 100);
            this.panelMenuLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInventory.FlatAppearance.BorderSize = 0;
            this.buttonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventory.ForeColor = System.Drawing.Color.White;
            this.buttonInventory.Location = new System.Drawing.Point(0, 100);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonInventory.Size = new System.Drawing.Size(306, 45);
            this.buttonInventory.TabIndex = 1;
            this.buttonInventory.Text = "Inventory";
            this.buttonInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // panelInventory
            // 
            this.panelInventory.BackColor = System.Drawing.Color.White;
            this.panelInventory.Controls.Add(this.buttonCompare);
            this.panelInventory.Controls.Add(this.buttonConvert);
            this.panelInventory.Controls.Add(this.buttonCreate);
            this.panelInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventory.ForeColor = System.Drawing.Color.Black;
            this.panelInventory.Location = new System.Drawing.Point(0, 145);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(306, 166);
            this.panelInventory.TabIndex = 2;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCompare.FlatAppearance.BorderSize = 0;
            this.buttonCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompare.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompare.ForeColor = System.Drawing.Color.Black;
            this.buttonCompare.Location = new System.Drawing.Point(0, 80);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonCompare.Size = new System.Drawing.Size(306, 40);
            this.buttonCompare.TabIndex = 3;
            this.buttonCompare.Text = "compare ";
            this.buttonCompare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConvert.FlatAppearance.BorderSize = 0;
            this.buttonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.ForeColor = System.Drawing.Color.Black;
            this.buttonConvert.Location = new System.Drawing.Point(0, 40);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonConvert.Size = new System.Drawing.Size(306, 40);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "convert ";
            this.buttonConvert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreate.FlatAppearance.BorderSize = 0;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.Black;
            this.buttonCreate.Location = new System.Drawing.Point(0, 0);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonCreate.Size = new System.Drawing.Size(306, 40);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "create ";
            this.buttonCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.ForeColor = System.Drawing.Color.White;
            this.buttonProducts.Location = new System.Drawing.Point(0, 311);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonProducts.Size = new System.Drawing.Size(306, 45);
            this.buttonProducts.TabIndex = 3;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // panelProducts
            // 
            this.panelProducts.BackColor = System.Drawing.Color.White;
            this.panelProducts.Controls.Add(this.buttonProduct);
            this.panelProducts.Controls.Add(this.buttonOrder);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProducts.ForeColor = System.Drawing.Color.Black;
            this.panelProducts.Location = new System.Drawing.Point(0, 356);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(306, 124);
            this.panelProducts.TabIndex = 4;
            // 
            // buttonProduct
            // 
            this.buttonProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProduct.FlatAppearance.BorderSize = 0;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduct.ForeColor = System.Drawing.Color.Black;
            this.buttonProduct.Location = new System.Drawing.Point(0, 40);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonProduct.Size = new System.Drawing.Size(306, 40);
            this.buttonProduct.TabIndex = 2;
            this.buttonProduct.Text = "products";
            this.buttonProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.ForeColor = System.Drawing.Color.Black;
            this.buttonOrder.Location = new System.Drawing.Point(0, 0);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonOrder.Size = new System.Drawing.Size(306, 40);
            this.buttonOrder.TabIndex = 0;
            this.buttonOrder.Text = "order";
            this.buttonOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMainMenu.Controls.Add(this.buttonInfo);
            this.panelMainMenu.Controls.Add(this.panelProducts);
            this.panelMainMenu.Controls.Add(this.buttonProducts);
            this.panelMainMenu.Controls.Add(this.panelInventory);
            this.panelMainMenu.Controls.Add(this.buttonInventory);
            this.panelMainMenu.Controls.Add(this.panelMenuLogo);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(306, 724);
            this.panelMainMenu.TabIndex = 5;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Location = new System.Drawing.Point(0, 480);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonInfo.Size = new System.Drawing.Size(306, 45);
            this.buttonInfo.TabIndex = 5;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1423, 724);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu";
            this.Text = "Intersport Home";
            this.Load += new System.EventHandler(this.menu_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain02.ResumeLayout(false);
            this.panelMenuLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInventory.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMain02;
        private System.Windows.Forms.Panel panelMenuLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Panel panelInventory;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonExit;
    }
}