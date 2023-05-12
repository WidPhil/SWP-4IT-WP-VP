
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
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intersportDataSet1 = new SWP_4IT_WP_VP.IntersportDataSet1();
            this.thisMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intersportDataSet = new SWP_4IT_WP_VP.IntersportDataSet();
            this.thisMonthTableAdapter = new SWP_4IT_WP_VP.IntersportDataSetTableAdapters.ThisMonthTableAdapter();
            this.storageTableAdapter = new SWP_4IT_WP_VP.IntersportDataSet1TableAdapters.StorageTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuePerPieceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thisMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(738, 498);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 33);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(34, 498);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 33);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerInventory
            // 
            this.dateTimePickerInventory.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInventory.Location = new System.Drawing.Point(34, 21);
            this.dateTimePickerInventory.Name = "dateTimePickerInventory";
            this.dateTimePickerInventory.Size = new System.Drawing.Size(296, 29);
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
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AutoGenerateColumns = false;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.measurementDataGridViewTextBoxColumn1,
            this.valuePerPieceDataGridViewTextBoxColumn1,
            this.valueTotalDataGridViewTextBoxColumn1});
            this.dataGridViewInventory.DataSource = this.thisMonthBindingSource;
            this.dataGridViewInventory.Location = new System.Drawing.Point(34, 93);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.RowTemplate.Height = 24;
            this.dataGridViewInventory.Size = new System.Drawing.Size(812, 388);
            this.dataGridViewInventory.TabIndex = 6;
            this.dataGridViewInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventory_CellContentClick);
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
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // measurementDataGridViewTextBoxColumn1
            // 
            this.measurementDataGridViewTextBoxColumn1.DataPropertyName = "measurement";
            this.measurementDataGridViewTextBoxColumn1.HeaderText = "measurement";
            this.measurementDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.measurementDataGridViewTextBoxColumn1.Name = "measurementDataGridViewTextBoxColumn1";
            this.measurementDataGridViewTextBoxColumn1.Width = 125;
            // 
            // valuePerPieceDataGridViewTextBoxColumn1
            // 
            this.valuePerPieceDataGridViewTextBoxColumn1.DataPropertyName = "valuePerPiece";
            this.valuePerPieceDataGridViewTextBoxColumn1.HeaderText = "valuePerPiece";
            this.valuePerPieceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.valuePerPieceDataGridViewTextBoxColumn1.Name = "valuePerPieceDataGridViewTextBoxColumn1";
            this.valuePerPieceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // valueTotalDataGridViewTextBoxColumn1
            // 
            this.valueTotalDataGridViewTextBoxColumn1.DataPropertyName = "valueTotal";
            this.valueTotalDataGridViewTextBoxColumn1.HeaderText = "valueTotal";
            this.valueTotalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.valueTotalDataGridViewTextBoxColumn1.Name = "valueTotalDataGridViewTextBoxColumn1";
            this.valueTotalDataGridViewTextBoxColumn1.Width = 125;
            // 
            // createInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.dateTimePickerInventory);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "createInventory";
            this.Text = "Create new Inventory";
            this.Load += new System.EventHandler(this.createInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thisMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private IntersportDataSet intersportDataSet;
        private System.Windows.Forms.BindingSource thisMonthBindingSource;
        private IntersportDataSetTableAdapters.ThisMonthTableAdapter thisMonthTableAdapter;
        private IntersportDataSet1 intersportDataSet1;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private IntersportDataSet1TableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuePerPieceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTotalDataGridViewTextBoxColumn1;
    }
}