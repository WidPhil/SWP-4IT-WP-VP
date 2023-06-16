
namespace SWP_4IT_WP_VP
{
    partial class createInventory
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
            this.components = new System.ComponentModel.Container();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerInventory = new System.Windows.Forms.DateTimePicker();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuePerPieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thisMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intersportDataSet = new SWP_4IT_WP_VP.IntersportDataSet();
            this.thisMonthTableAdapter = new SWP_4IT_WP_VP.IntersportDataSetTableAdapters.ThisMonthTableAdapter();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxValueTotal = new System.Windows.Forms.TextBox();
            this.textBoxValuePerPiece = new System.Windows.Forms.TextBox();
            this.textBoxMeasurement = new System.Windows.Forms.TextBox();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intersportDataSet1 = new SWP_4IT_WP_VP.IntersportDataSet1();
            this.storageTableAdapter = new SWP_4IT_WP_VP.IntersportDataSet1TableAdapters.StorageTableAdapter();
            this.labelName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelMeasurement = new System.Windows.Forms.Label();
            this.labelValuePerPiece = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonNewMonth = new System.Windows.Forms.Button();
            this.labelNewMonth = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelFill = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thisMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightGray;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Location = new System.Drawing.Point(163, 496);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 34);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightGray;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSave.Location = new System.Drawing.Point(17, 496);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 34);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerInventory
            // 
            this.dateTimePickerInventory.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInventory.Location = new System.Drawing.Point(106, 82);
            this.dateTimePickerInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerInventory.Name = "dateTimePickerInventory";
            this.dateTimePickerInventory.Size = new System.Drawing.Size(332, 29);
            this.dateTimePickerInventory.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // measurementDataGridViewTextBoxColumn
            // 
            this.measurementDataGridViewTextBoxColumn.DataPropertyName = "measurement";
            this.measurementDataGridViewTextBoxColumn.HeaderText = "measurement";
            this.measurementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measurementDataGridViewTextBoxColumn.Name = "measurementDataGridViewTextBoxColumn";
            this.measurementDataGridViewTextBoxColumn.Width = 125;
            // 
            // valuePerPieceDataGridViewTextBoxColumn
            // 
            this.valuePerPieceDataGridViewTextBoxColumn.DataPropertyName = "valuePerPiece";
            this.valuePerPieceDataGridViewTextBoxColumn.HeaderText = "valuePerPiece";
            this.valuePerPieceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valuePerPieceDataGridViewTextBoxColumn.Name = "valuePerPieceDataGridViewTextBoxColumn";
            this.valuePerPieceDataGridViewTextBoxColumn.Width = 125;
            // 
            // valueTotalDataGridViewTextBoxColumn
            // 
            this.valueTotalDataGridViewTextBoxColumn.DataPropertyName = "valueTotal";
            this.valueTotalDataGridViewTextBoxColumn.HeaderText = "valueTotal";
            this.valueTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valueTotalDataGridViewTextBoxColumn.Name = "valueTotalDataGridViewTextBoxColumn";
            this.valueTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // thisMonthBindingSource
            // 
            this.thisMonthBindingSource.DataMember = "ThisMonth";
            this.thisMonthBindingSource.DataSource = this.intersportDataSet;
            // 
            // intersportDataSet
            // 
            this.intersportDataSet.DataSetName = "IntersportDataSet";
            this.intersportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thisMonthTableAdapter
            // 
            this.thisMonthTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(16, 157);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 33);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxValueTotal
            // 
            this.textBoxValueTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValueTotal.Location = new System.Drawing.Point(16, 438);
            this.textBoxValueTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxValueTotal.Name = "textBoxValueTotal";
            this.textBoxValueTotal.ReadOnly = true;
            this.textBoxValueTotal.Size = new System.Drawing.Size(159, 33);
            this.textBoxValueTotal.TabIndex = 8;
            // 
            // textBoxValuePerPiece
            // 
            this.textBoxValuePerPiece.Enabled = false;
            this.textBoxValuePerPiece.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValuePerPiece.Location = new System.Drawing.Point(16, 365);
            this.textBoxValuePerPiece.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxValuePerPiece.Name = "textBoxValuePerPiece";
            this.textBoxValuePerPiece.Size = new System.Drawing.Size(159, 33);
            this.textBoxValuePerPiece.TabIndex = 9;
            this.textBoxValuePerPiece.Text = "0";
            this.textBoxValuePerPiece.TextChanged += new System.EventHandler(this.textBoxValuePerPiece_TextChanged);
            // 
            // textBoxMeasurement
            // 
            this.textBoxMeasurement.Enabled = false;
            this.textBoxMeasurement.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMeasurement.Location = new System.Drawing.Point(16, 296);
            this.textBoxMeasurement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMeasurement.Name = "textBoxMeasurement";
            this.textBoxMeasurement.Size = new System.Drawing.Size(159, 33);
            this.textBoxMeasurement.TabIndex = 10;
            this.textBoxMeasurement.TextChanged += new System.EventHandler(this.textBoxMeasurement_TextChanged);
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.intersportDataSet1;
            // 
            // intersportDataSet1
            // 
            this.intersportDataSet1.DataSetName = "IntersportDataSet1";
            this.intersportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 131);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(171, 22);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name of the product";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(12, 198);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 22);
            this.labelQuantity.TabIndex = 13;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelMeasurement
            // 
            this.labelMeasurement.AutoSize = true;
            this.labelMeasurement.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeasurement.Location = new System.Drawing.Point(12, 270);
            this.labelMeasurement.Name = "labelMeasurement";
            this.labelMeasurement.Size = new System.Drawing.Size(115, 22);
            this.labelMeasurement.TabIndex = 14;
            this.labelMeasurement.Text = "Measurement";
            // 
            // labelValuePerPiece
            // 
            this.labelValuePerPiece.AutoSize = true;
            this.labelValuePerPiece.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValuePerPiece.Location = new System.Drawing.Point(12, 339);
            this.labelValuePerPiece.Name = "labelValuePerPiece";
            this.labelValuePerPiece.Size = new System.Drawing.Size(128, 22);
            this.labelValuePerPiece.TabIndex = 15;
            this.labelValuePerPiece.Text = "Value per piece";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(12, 412);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(48, 22);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "Total";
            // 
            // buttonNewMonth
            // 
            this.buttonNewMonth.BackColor = System.Drawing.Color.LightGray;
            this.buttonNewMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewMonth.Location = new System.Drawing.Point(16, 36);
            this.buttonNewMonth.Name = "buttonNewMonth";
            this.buttonNewMonth.Size = new System.Drawing.Size(167, 29);
            this.buttonNewMonth.TabIndex = 17;
            this.buttonNewMonth.Text = "New month";
            this.buttonNewMonth.UseVisualStyleBackColor = false;
            this.buttonNewMonth.Click += new System.EventHandler(this.buttonNewMonth_Click);
            // 
            // labelNewMonth
            // 
            this.labelNewMonth.AutoSize = true;
            this.labelNewMonth.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewMonth.Location = new System.Drawing.Point(12, 9);
            this.labelNewMonth.Name = "labelNewMonth";
            this.labelNewMonth.Size = new System.Drawing.Size(611, 20);
            this.labelNewMonth.TabIndex = 18;
            this.labelNewMonth.Text = "Before you click on the button \"new month\", make sure you save last month\'s data!" +
    "\r\n";
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.LightGray;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Location = new System.Drawing.Point(436, 36);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(187, 29);
            this.buttonContinue.TabIndex = 19;
            this.buttonContinue.Text = "Continue inventory";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonContinue);
            this.panel1.Controls.Add(this.labelNewMonth);
            this.panel1.Controls.Add(this.buttonNewMonth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 72);
            this.panel1.TabIndex = 20;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Enabled = false;
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(16, 224);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(159, 33);
            this.textBoxQuantity.TabIndex = 11;
            this.textBoxQuantity.Text = "0";
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            // 
            // labelFill
            // 
            this.labelFill.AutoSize = true;
            this.labelFill.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFill.Location = new System.Drawing.Point(12, 87);
            this.labelFill.Name = "labelFill";
            this.labelFill.Size = new System.Drawing.Size(75, 24);
            this.labelFill.TabIndex = 21;
            this.labelFill.Text = "Fill in ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(171, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "* e.g. piece, ...";
            // 
            // createInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFill);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelValuePerPiece);
            this.Controls.Add(this.labelMeasurement);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxMeasurement);
            this.Controls.Add(this.textBoxValuePerPiece);
            this.Controls.Add(this.textBoxValueTotal);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dateTimePickerInventory);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "createInventory";
            this.Text = "Create new Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.thisMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerInventory;
        //private IntersportDataSet intersportDataSet;
        //private System.Windows.Forms.BindingSource thisMonthBindingSource;
        //private IntersportDataSetTableAdapters.ThisMonthTableAdapter thisMonthTableAdapter;
        //private System.Windows.Forms.Label labelCreateInventory;
        //private IntersportDataSet1 intersportDataSet1;
        //private System.Windows.Forms.BindingSource thisMonthBindingSource1;
        //private IntersportDataSet1TableAdapters.ThisMonthTableAdapter thisMonthTableAdapter1;
        //private IntersportDataSet2 intersportDataSet2;
        //private System.Windows.Forms.BindingSource thisMonthBindingSource2;
        //private IntersportDataSet2TableAdapters.ThisMonthTableAdapter thisMonthTableAdapter2;
        //private IntersportDataSet3 intersportDataSet3;
        //private System.Windows.Forms.BindingSource thisMonthBindingSource3;
        //private IntersportDataSet3TableAdapters.ThisMonthTableAdapter thisMonthTableAdapter3;
        //private IntersportDataSet4 intersportDataSet4;
        //private System.Windows.Forms.BindingSource thisMonthBindingSource4;
        //private IntersportDataSet4TableAdapters.ThisMonthTableAdapter thisMonthTableAdapter4;
        //private System.Windows.Forms.DataGridView dataGridViewInventory;
        //private IntersportDataSet5 intersportDataSet5;
        //private System.Windows.Forms.BindingSource thisMonthBindingSource5;
        //private IntersportDataSet5TableAdapters.ThisMonthTableAdapter thisMonthTableAdapter5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuePerPieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTotalDataGridViewTextBoxColumn;
        private IntersportDataSet intersportDataSet;
        private System.Windows.Forms.BindingSource thisMonthBindingSource;
        private IntersportDataSetTableAdapters.ThisMonthTableAdapter thisMonthTableAdapter;
        private IntersportDataSet1 intersportDataSet1;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private IntersportDataSet1TableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxValueTotal;
        private System.Windows.Forms.TextBox textBoxValuePerPiece;
        private System.Windows.Forms.TextBox textBoxMeasurement;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelMeasurement;
        private System.Windows.Forms.Label labelValuePerPiece;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonNewMonth;
        private System.Windows.Forms.Label labelNewMonth;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelFill;
        private System.Windows.Forms.Label label1;
    }
}