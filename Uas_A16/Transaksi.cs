using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uas_A16
{
    public partial class Transaksi : Form
    {
        private string stringConnection = "Data Source=LAPTOP-OPC709QK;Initial Catalog=Toko_Maju;Persist Security Info=True;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private string kodeTran, idCust, kodeBar, keterangan;
        private DateTime tglTran;
        private BindingSource TransaksiBindingSource;
        public Transaksi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            TransaksiBindingSource = new BindingSource();
            refreshform();
        }
        private void refreshform()
        {
            txtKode.Enabled = false;
            txtKode.Text = "";
            cbxId.Enabled = false;
            cbxId.Text = "";
            cbxKodebarang.Enabled = false;
            cbxKodebarang.Text = "";
            dtTransaksi.Enabled = false;
            dtTransaksi.Text = "";
            cbxKeterangan.Enabled = false;
            cbxKeterangan.Text = "";
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            clearBinding();
        }
        private void clearBinding()
        {
            this.txtKode.DataBindings.Clear();
            this.cbxId.DataBindings.Clear();
            this.cbxKodebarang.DataBindings.Clear();
            this.dtTransaksi.DataBindings.Clear();
            this.cbxKeterangan.DataBindings.Clear();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Transaksi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Data_Master bc = new Data_Master();
            bc.Show();
            this.Hide();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_MajuDataSet1.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter1.Fill(this.toko_MajuDataSet1.Transaksi);
            // TODO: This line of code loads data into the 'toko_MajuDataSet2.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.toko_MajuDataSet2.Transaksi);
            // TODO: This line of code loads data into the 'toko_MajuDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.toko_MajuDataSet.Customer);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kode_transaksi = dataGridView1.SelectedRows[0].Cells["kode_transaksi"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Transaksi WHERE kode_transaksi = @kode_transaksi";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("kode_transaksi", kode_transaksi));
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cbxKodebarang.Text = row.Cells["kode_transaksi"].Value.ToString();
                cbxId.Text = row.Cells["id_customer"].Value.ToString();
                dtTransaksi.Text = row.Cells["tgl_transaksi"].Value.ToString();
                cbxKodebarang.Text = row.Cells["kode_barang"].Value.ToString();
                cbxKeterangan.Text = row.Cells["keterangan"].Value.ToString();
                
                cbxKodebarang.Enabled = false;
                cbxId.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = true;
            }
        }
        private void Id()
        {
            koneksi.Open();
            string StringConnection = "select id_customer, id_customer from dbo.Customer";
            SqlCommand cmd = new SqlCommand(StringConnection, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            koneksi.Close();
            cbxId.DisplayMember = "id_customer";
            cbxId.ValueMember = "id_customer";
            cbxId.DataSource = dt;
        }

        private void Kode()
        {
            koneksi.Open();
            string StringConnection = "select kode_barang, kode_barang from dbo.Barang";
            SqlCommand cmd = new SqlCommand(StringConnection, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            koneksi.Close();
            cbxKodebarang.DisplayMember = "kode_barang";
            cbxKodebarang.ValueMember = "kode_barang";
            cbxKodebarang.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtKode.Enabled = true;
            cbxKodebarang.Enabled = true;
            cbxId.Enabled = true;
            Id();
            dtTransaksi.Enabled = true;
            dtTransaksi.Value = DateTime.Today;
            cbxKodebarang.Enabled = true;
            Kode();
            cbxKeterangan.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void cbxId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            kodeTran = txtKode.Text.Trim();
            idCust = cbxId.Text.Trim();
            tglTran = dtTransaksi.Value;
            kodeBar = cbxKodebarang.Text.Trim();
            keterangan = cbxKeterangan.Text.Trim();
            if (string.IsNullOrEmpty(kodeTran) || string.IsNullOrEmpty(idCust) || string.IsNullOrEmpty(kodeBar) || string.IsNullOrEmpty(keterangan))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO Transaksi (kode_transaksi, id_customer, tgl_transaksi, kode_barang, keterangan) VALUES (@kode_transaksi, @id_customer, @tgl_transaksi, @kode_barang, @keterangan)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.AddWithValue("@kode_transaksi", kodeTran);
                cmd.Parameters.AddWithValue("@id_customer", idCust);
                cmd.Parameters.AddWithValue("@tgl_transaksi", tglTran);
                cmd.Parameters.AddWithValue("@kode_barang", kodeBar);
                cmd.Parameters.AddWithValue("@keterangan", keterangan);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKode.Text = "";
            cbxId.Text = "";
            cbxKodebarang.Text = "";
            dtTransaksi.Value = DateTime.Now;
            cbxKeterangan.Text = "";
        }

        

        private void cbxKeterangan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
