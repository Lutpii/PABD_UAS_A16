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
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toko_MajuDataSet3 = new Uas_A16.Toko_MajuDataSet3();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_MajuDataSet = new Uas_A16.Toko_MajuDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.customerTableAdapter = new Uas_A16.Toko_MajuDataSetTableAdapters.CustomerTableAdapter();
            this.tokoMajuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new Uas_A16.Toko_MajuDataSet3TableAdapters.CustomerTableAdapter();
            this.toko_MajuDataSetfix = new Uas_A16.Toko_MajuDataSetfix();
            this.tokoMajuDataSetfixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoMajuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSetfix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoMajuDataSetfixBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.tokoMajuDataSetfixBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 229);
            this.dataGridView1.TabIndex = 1;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.toko_MajuDataSet3;
            // 
            // toko_MajuDataSet3
            // 
            this.toko_MajuDataSet3.DataSetName = "Toko_MajuDataSet3";
            this.toko_MajuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.toko_MajuDataSet;
            // 
            // toko_MajuDataSet
            // 
            this.toko_MajuDataSet.DataSetName = "Toko_MajuDataSet";
            this.toko_MajuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tokoMajuDataSetBindingSource
            // 
            this.tokoMajuDataSetBindingSource.DataSource = this.toko_MajuDataSet;
            this.tokoMajuDataSetBindingSource.Position = 0;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // toko_MajuDataSetfix
            // 
            this.toko_MajuDataSetfix.DataSetName = "Toko_MajuDataSetfix";
            this.toko_MajuDataSetfix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tokoMajuDataSetfixBindingSource
            // 
            this.tokoMajuDataSetfixBindingSource.DataSource = this.toko_MajuDataSetfix;
            this.tokoMajuDataSetfixBindingSource.Position = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoMajuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSetfix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoMajuDataSetfixBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource tokoMajuDataSetBindingSource;
        private Toko_MajuDataSet3 toko_MajuDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private Toko_MajuDataSet3TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.BindingSource tokoMajuDataSetfixBindingSource;
        private Toko_MajuDataSetfix toko_MajuDataSetfix;
    }
}