
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
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuePerPieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thisMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intersportDataSet = new SWP_4IT_WP_VP.IntersportDataSet();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerInventory = new System.Windows.Forms.DateTimePicker();
            this.thisMonthTableAdapter = new SWP_4IT_WP_VP.IntersportDataSetTableAdapters.ThisMonthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thisMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AutoGenerateColumns = false;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.measurementDataGridViewTextBoxColumn,
            this.valuePerPieceDataGridViewTextBoxColumn,
            this.valueTotalDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.dataGridViewInventory.DataSource = this.thisMonthBindingSource;
            this.dataGridViewInventory.Location = new System.Drawing.Point(29, 81);
            this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.RowTemplate.Height = 24;
            this.dataGridViewInventory.Size = new System.Drawing.Size(925, 497);
            this.dataGridViewInventory.TabIndex = 0;
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
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "sum";
            this.sumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.Width = 125;
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
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(846, 607);
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
            this.buttonSave.Location = new System.Drawing.Point(29, 607);
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
            this.dateTimePickerInventory.Location = new System.Drawing.Point(29, 31);
            this.dateTimePickerInventory.Name = "dateTimePickerInventory";
            this.dateTimePickerInventory.Size = new System.Drawing.Size(296, 29);
            this.dateTimePickerInventory.TabIndex = 5;
            // 
            // thisMonthTableAdapter
            // 
            this.thisMonthTableAdapter.ClearBeforeFill = true;
            // 
            // createInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 662);
            this.Controls.Add(this.dateTimePickerInventory);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridViewInventory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "createInventory";
            this.Text = "Create new Inventory";
            this.Load += new System.EventHandler(this.createInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thisMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerInventory;
        private IntersportDataSet intersportDataSet;
        private System.Windows.Forms.BindingSource thisMonthBindingSource;
        private IntersportDataSetTableAdapters.ThisMonthTableAdapter thisMonthTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuePerPieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
    }
}