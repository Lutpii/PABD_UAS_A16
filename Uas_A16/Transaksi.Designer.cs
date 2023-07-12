namespace Uas_A16
{
    partial class Transaksi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_MajuDataSet2 = new Uas_A16.Toko_MajuDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTransaksi = new System.Windows.Forms.DateTimePicker();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toko_MajuDataSet = new Uas_A16.Toko_MajuDataSet();
            this.tokoMajuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Uas_A16.Toko_MajuDataSetTableAdapters.CustomerTableAdapter();
            this.transaksiTableAdapter = new Uas_A16.Toko_MajuDataSet2TableAdapters.TransaksiTableAdapter();
            this.toko_MajuDataSet1 = new Uas_A16.Toko_MajuDataSet1();
            this.transaksiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter1 = new Uas_A16.Toko_MajuDataSet1TableAdapters.TransaksiTableAdapter();
            this.cbxKeterangan = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxId = new System.Windows.Forms.ComboBox();
            this.cbxKodebarang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoMajuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.transaksiBindingSource, "tgl_transaksi", true));
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.toko_MajuDataSet2;
            // 
            // toko_MajuDataSet2
            // 
            this.toko_MajuDataSet2.DataSetName = "Toko_MajuDataSet2";
            this.toko_MajuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Transaksi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanggal Transaksi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id Customer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Keterangan";
            // 
            // dtTransaksi
            // 
            this.dtTransaksi.Location = new System.Drawing.Point(240, 294);
            this.dtTransaksi.Name = "dtTransaksi";
            this.dtTransaksi.Size = new System.Drawing.Size(200, 22);
            this.dtTransaksi.TabIndex = 6;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(240, 200);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(100, 22);
            this.txtKode.TabIndex = 7;
            this.txtKode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(691, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(240, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(356, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(476, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // toko_MajuDataSet
            // 
            this.toko_MajuDataSet.DataSetName = "Toko_MajuDataSet";
            this.toko_MajuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tokoMajuDataSetBindingSource
            // 
            this.tokoMajuDataSetBindingSource.DataSource = this.toko_MajuDataSet;
            this.tokoMajuDataSetBindingSource.Position = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.tokoMajuDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // toko_MajuDataSet1
            // 
            this.toko_MajuDataSet1.DataSetName = "Toko_MajuDataSet1";
            this.toko_MajuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiBindingSource1
            // 
            this.transaksiBindingSource1.DataMember = "Transaksi";
            this.transaksiBindingSource1.DataSource = this.toko_MajuDataSet1;
            // 
            // transaksiTableAdapter1
            // 
            this.transaksiTableAdapter1.ClearBeforeFill = true;
            // 
            // cbxKeterangan
            // 
            this.cbxKeterangan.FormattingEnabled = true;
            this.cbxKeterangan.Items.AddRange(new object[] {
            "Lunas",
            "BelumLunas",
            "TidakLunas"});
            this.cbxKeterangan.Location = new System.Drawing.Point(240, 322);
            this.cbxKeterangan.Name = "cbxKeterangan";
            this.cbxKeterangan.Size = new System.Drawing.Size(100, 24);
            this.cbxKeterangan.TabIndex = 16;
            this.cbxKeterangan.SelectedIndexChanged += new System.EventHandler(this.cbxKeterangan_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(592, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxId
            // 
            this.cbxId.FormattingEnabled = true;
            this.cbxId.Location = new System.Drawing.Point(240, 231);
            this.cbxId.Name = "cbxId";
            this.cbxId.Size = new System.Drawing.Size(100, 24);
            this.cbxId.TabIndex = 18;
            this.cbxId.SelectedIndexChanged += new System.EventHandler(this.cbxId_SelectedIndexChanged);
            // 
            // cbxKodebarang
            // 
            this.cbxKodebarang.FormattingEnabled = true;
            this.cbxKodebarang.Location = new System.Drawing.Point(240, 264);
            this.cbxKodebarang.Name = "cbxKodebarang";
            this.cbxKodebarang.Size = new System.Drawing.Size(100, 24);
            this.cbxKodebarang.TabIndex = 19;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxKodebarang);
            this.Controls.Add(this.cbxId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbxKeterangan);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.dtTransaksi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoMajuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_MajuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTransaksi;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button5;
        private Toko_MajuDataSet toko_MajuDataSet;
        private System.Windows.Forms.BindingSource tokoMajuDataSetBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Toko_MajuDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private Toko_MajuDataSet2 toko_MajuDataSet2;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private Toko_MajuDataSet2TableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private Toko_MajuDataSet1 toko_MajuDataSet1;
        private System.Windows.Forms.BindingSource transaksiBindingSource1;
        private Toko_MajuDataSet1TableAdapters.TransaksiTableAdapter transaksiTableAdapter1;
        private System.Windows.Forms.ComboBox cbxKeterangan;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbxId;
        private System.Windows.Forms.ComboBox cbxKodebarang;
    }
}