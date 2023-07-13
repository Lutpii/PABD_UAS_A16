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
    public partial class Barang : Form
    {
        private string stringConnection = "Data Source=LAPTOP-OPC709QK;Initial Catalog=Toko_Maju;Persist Security Info=True;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private string kodeBar, namaBar, idJenbar, idSup, harga;
        private BindingSource BarangBindingSource;
        public Barang()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            BarangBindingSource = new BindingSource();
            refreshform();
        }
        private void clearBinding()
        {
            this.txtKode.DataBindings.Clear();
            this.txtNama.DataBindings.Clear();
            this.cbxIdJenis.DataBindings.Clear();
            this.cbxId.DataBindings.Clear();
            this.txtHarga.DataBindings.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Master bx = new Data_Master();
            bx.Show();
            this.Hide();
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtKode_TextChanged(object sender, EventArgs e)
        {

        }
        private void IdJenisBarang()
        {
            koneksi.Open();
            string StringConnection = "select id_jenis_barang, id_jenis_barang from dbo.Barang";
            SqlCommand cmd = new SqlCommand(StringConnection, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            koneksi.Close();
            cbxIdJenis.DisplayMember = "id_jenis_barang";
            cbxIdJenis.ValueMember = "id_jenis_barang";
            cbxIdJenis.DataSource = dt;
        }
        private void Id()
        {
            koneksi.Open();
            string StringConnection = "select id_suplier, id_suplier from dbo.Barang";
            SqlCommand cmd = new SqlCommand(StringConnection, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            koneksi.Close();
            cbxId.DisplayMember = "id_suplier";
            cbxId.ValueMember = "id_suplier";
            cbxId.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtKode.Enabled = true;
            txtNama.Enabled = true;
            cbxIdJenis.Enabled = true;
            IdJenisBarang();
            cbxId.Enabled = true;
            Id();
            txtHarga.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            kodeBar = txtKode.Text.Trim();
            namaBar = txtNama.Text.Trim();
            idJenbar = cbxIdJenis.Text.Trim();
            idSup = cbxId.Text.Trim();
            harga = txtHarga.Text.Trim();
            if (string.IsNullOrEmpty(kodeBar) || string.IsNullOrEmpty(namaBar) || string.IsNullOrEmpty(idJenbar) || string.IsNullOrEmpty(idSup) || string.IsNullOrEmpty(harga)) 
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO Barang (kode_barang, nama_barang, id_jenis_barang, id_suplier, harga) VALUES (@kode_barang, @nama_barang, @id_jenis_barang, @id_suplier, @harga)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.AddWithValue("@kode_barang", kodeBar);
                cmd.Parameters.AddWithValue("@nama_barang", namaBar);
                cmd.Parameters.AddWithValue("@id_jenis_barang", idJenbar);
                cmd.Parameters.AddWithValue("@id_suplier", idSup);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
            }
        }

        private void txtKode_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void refreshform()
        {
            txtKode.Enabled = false;
            txtKode.Text = "";
            txtNama.Enabled = false;
            txtNama.Text = "";
            cbxIdJenis.Enabled = false;
            cbxIdJenis.Text = "";
            cbxId.Enabled = false;
            cbxId.Text = "";
            txtHarga.Enabled = false;
            txtHarga.Text = "";
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            clearBinding();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Barang";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtKode.Text = row.Cells["kode_barang"].Value.ToString();
                txtNama.Text = row.Cells["nama_barang"].Value.ToString();
                cbxIdJenis.Text = row.Cells["id_jenis_barang"].Value.ToString();
                cbxId.Text = row.Cells["id_suplier"].Value.ToString();

                cbxId.Enabled = false;
                cbxId.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKode.Text = "";
            txtNama.Text = "";
            cbxIdJenis.Text = "";
            cbxId.Text = "";
            txtHarga.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kode_barang = dataGridView1.SelectedRows[0].Cells["kode_barang"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Barang WHERE kode_barang = @kode_barang";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("kode_barang", kode_barang));
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

        private void Barang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_MajuDataSet1.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.toko_MajuDataSet1.Barang);

        }
    }
}
