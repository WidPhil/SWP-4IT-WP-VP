
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
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.thisMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(846, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 45);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(25, 280);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 45);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerInventory
            // 
            this.dateTimePickerInventory.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInventory.Location = new System.Drawing.Point(38, 29);
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
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(38, 162);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 33);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxValueTotal
            // 
            this.textBoxValueTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValueTotal.Location = new System.Drawing.Point(777, 162);
            this.textBoxValueTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxValueTotal.Name = "textBoxValueTotal";
            this.textBoxValueTotal.ReadOnly = true;
            this.textBoxValueTotal.Size = new System.Drawing.Size(159, 33);
            this.textBoxValueTotal.TabIndex = 8;
            // 
            // textBoxValuePerPiece
            // 
            this.textBoxValuePerPiece.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValuePerPiece.Location = new System.Drawing.Point(594, 162);
            this.textBoxValuePerPiece.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxValuePerPiece.Name = "textBoxValuePerPiece";
            this.textBoxValuePerPiece.Size = new System.Drawing.Size(159, 33);
            this.textBoxValuePerPiece.TabIndex = 9;
            this.textBoxValuePerPiece.Text = "0";
            this.textBoxValuePerPiece.TextChanged += new System.EventHandler(this.textBoxValuePerPiece_TextChanged);
            // 
            // textBoxMeasurement
            // 
            this.textBoxMeasurement.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMeasurement.Location = new System.Drawing.Point(410, 162);
            this.textBoxMeasurement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMeasurement.Name = "textBoxMeasurement";
            this.textBoxMeasurement.Size = new System.Drawing.Size(159, 33);
            this.textBoxMeasurement.TabIndex = 10;
            this.textBoxMeasurement.TextChanged += new System.EventHandler(this.textBoxMeasurement_TextChanged);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(223, 162);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(159, 33);
            this.textBoxQuantity.TabIndex = 11;
            this.textBoxQuantity.Text = "0";
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
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
            this.labelName.Location = new System.Drawing.Point(38, 131);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(171, 22);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name of the product";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(219, 131);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 22);
            this.labelQuantity.TabIndex = 13;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelMeasurement
            // 
            this.labelMeasurement.AutoSize = true;
            this.labelMeasurement.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeasurement.Location = new System.Drawing.Point(406, 131);
            this.labelMeasurement.Name = "labelMeasurement";
            this.labelMeasurement.Size = new System.Drawing.Size(115, 22);
            this.labelMeasurement.TabIndex = 14;
            this.labelMeasurement.Text = "Measurement";
            // 
            // labelValuePerPiece
            // 
            this.labelValuePerPiece.AutoSize = true;
            this.labelValuePerPiece.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValuePerPiece.Location = new System.Drawing.Point(591, 131);
            this.labelValuePerPiece.Name = "labelValuePerPiece";
            this.labelValuePerPiece.Size = new System.Drawing.Size(128, 22);
            this.labelValuePerPiece.TabIndex = 15;
            this.labelValuePerPiece.Text = "Value per piece";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(774, 131);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(48, 22);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "Total";
            // 
            // buttonNewMonth
            // 
            this.buttonNewMonth.Location = new System.Drawing.Point(42, 66);
            this.buttonNewMonth.Name = "buttonNewMonth";
            this.buttonNewMonth.Size = new System.Drawing.Size(129, 36);
            this.buttonNewMonth.TabIndex = 17;
            this.buttonNewMonth.Text = "New month";
            this.buttonNewMonth.UseVisualStyleBackColor = true;
            this.buttonNewMonth.Click += new System.EventHandler(this.buttonNewMonth_Click);
            // 
            // labelNewMonth
            // 
            this.labelNewMonth.AutoSize = true;
            this.labelNewMonth.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewMonth.Location = new System.Drawing.Point(177, 73);
            this.labelNewMonth.Name = "labelNewMonth";
            this.labelNewMonth.Size = new System.Drawing.Size(520, 18);
            this.labelNewMonth.TabIndex = 18;
            this.labelNewMonth.Text = "Before you click on the button, make sure you have saved the data from last month" +
    "";
            // 
            // createInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 500);
            this.Controls.Add(this.labelNewMonth);
            this.Controls.Add(this.buttonNewMonth);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelValuePerPiece);
            this.Controls.Add(this.labelMeasurement);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxQuantity);
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
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelMeasurement;
        private System.Windows.Forms.Label labelValuePerPiece;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonNewMonth;
        private System.Windows.Forms.Label labelNewMonth;
    }
}