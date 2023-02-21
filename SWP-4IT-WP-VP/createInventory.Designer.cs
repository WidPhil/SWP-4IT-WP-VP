
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePickerInventory = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.intersportDataSet = new SWP_4IT_WP_VP.IntersportDataSet();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new SWP_4IT_WP_VP.IntersportDataSetTableAdapters.testTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuePerPieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCreateInventory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
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
            this.dataGridViewInventory.DataSource = this.testBindingSource;
            this.dataGridViewInventory.Location = new System.Drawing.Point(17, 122);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.RowTemplate.Height = 24;
            this.dataGridViewInventory.Size = new System.Drawing.Size(977, 238);
            this.dataGridViewInventory.TabIndex = 0;
            this.dataGridViewInventory.Visible = false;
            this.dataGridViewInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonCreate
            // 
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(30, 70);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(109, 32);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Okay";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Visible = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(368, 444);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 33);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerInventory
            // 
            this.dateTimePickerInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInventory.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInventory.Location = new System.Drawing.Point(17, 37);
            this.dateTimePickerInventory.Name = "dateTimePickerInventory";
            this.dateTimePickerInventory.Size = new System.Drawing.Size(137, 27);
            this.dateTimePickerInventory.TabIndex = 3;
            this.dateTimePickerInventory.Value = new System.DateTime(2023, 1, 31, 0, 0, 0, 0);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(30, 444);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 33);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // intersportDataSet
            // 
            this.intersportDataSet.DataSetName = "IntersportDataSet";
            this.intersportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "test";
            this.testBindingSource.DataSource = this.intersportDataSet;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
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
            // labelCreateInventory
            // 
            this.labelCreateInventory.AutoSize = true;
            this.labelCreateInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateInventory.Location = new System.Drawing.Point(12, 9);
            this.labelCreateInventory.Name = "labelCreateInventory";
            this.labelCreateInventory.Size = new System.Drawing.Size(142, 25);
            this.labelCreateInventory.TabIndex = 6;
            this.labelCreateInventory.Text = "Select the date";
            // 
            // createInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 575);
            this.Controls.Add(this.labelCreateInventory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerInventory);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataGridViewInventory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "createInventory";
            this.Text = "Create new Inventory";
            this.Load += new System.EventHandler(this.createInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intersportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerInventory;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox1;
        private IntersportDataSet intersportDataSet;
        private System.Windows.Forms.BindingSource testBindingSource;
        private IntersportDataSetTableAdapters.testTableAdapter testTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuePerPieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelCreateInventory;
    }
}