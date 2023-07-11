namespace Uas_A16
{
    partial class Data_Grid
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.toko_MajuDataSet = new Uas_A16.Toko_MajuDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Uas_A16.Toko_MajuDataSetTableAdapters.CustomerTableAdapter();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namacustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namadepcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabelcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Customer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcustomerDataGridViewTextBoxColumn,
            this.namacustomerDataGridViewTextBoxColumn,
            this.namadepcustomerDataGridViewTextBoxColumn,
            this.namabelcustomerDataGridViewTextBoxColumn,
            this.alamatcustomerDataGridViewTextBoxColumn,
            this.tlpcustomerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 229);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toko_MajuDataSet
            // 
            this.toko_MajuDataSet.DataSetName = "Toko_MajuDataSet";
            this.toko_MajuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.toko_MajuDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            this.idcustomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // namacustomerDataGridViewTextBoxColumn
            // 
            this.namacustomerDataGridViewTextBoxColumn.DataPropertyName = "nama_customer";
            this.namacustomerDataGridViewTextBoxColumn.HeaderText = "nama_customer";
            this.namacustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namacustomerDataGridViewTextBoxColumn.Name = "namacustomerDataGridViewTextBoxColumn";
            this.namacustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // namadepcustomerDataGridViewTextBoxColumn
            // 
            this.namadepcustomerDataGridViewTextBoxColumn.DataPropertyName = "namadep_customer";
            this.namadepcustomerDataGridViewTextBoxColumn.HeaderText = "namadep_customer";
            this.namadepcustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namadepcustomerDataGridViewTextBoxColumn.Name = "namadepcustomerDataGridViewTextBoxColumn";
            this.namadepcustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // namabelcustomerDataGridViewTextBoxColumn
            // 
            this.namabelcustomerDataGridViewTextBoxColumn.DataPropertyName = "namabel_customer";
            this.namabelcustomerDataGridViewTextBoxColumn.HeaderText = "namabel_customer";
            this.namabelcustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namabelcustomerDataGridViewTextBoxColumn.Name = "namabelcustomerDataGridViewTextBoxColumn";
            this.namabelcustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatcustomerDataGridViewTextBoxColumn
            // 
            this.alamatcustomerDataGridViewTextBoxColumn.DataPropertyName = "alamat_customer";
            this.alamatcustomerDataGridViewTextBoxColumn.HeaderText = "alamat_customer";
            this.alamatcustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatcustomerDataGridViewTextBoxColumn.Name = "alamatcustomerDataGridViewTextBoxColumn";
            this.alamatcustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // tlpcustomerDataGridViewTextBoxColumn
            // 
            this.tlpcustomerDataGridViewTextBoxColumn.DataPropertyName = "tlp_customer";
            this.tlpcustomerDataGridViewTextBoxColumn.HeaderText = "tlp_customer";
            this.tlpcustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tlpcustomerDataGridViewTextBoxColumn.Name = "tlpcustomerDataGridViewTextBoxColumn";
            this.tlpcustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // Data_Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Data_Grid";
            this.Text = "Data_Grid";
            this.Load += new System.EventHandler(this.Data_Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Toko_MajuDataSet toko_MajuDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Toko_MajuDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namacustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namadepcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabelcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlpcustomerDataGridViewTextBoxColumn;
    }
}