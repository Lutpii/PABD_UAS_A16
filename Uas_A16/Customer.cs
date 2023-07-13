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
    public partial class Customer : Form
    {
        private string stringConnection = "Data Source=LAPTOP-OPC709QK;Initial Catalog=Toko_Maju;Persist Security Info=True;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private string idCust, namaCust, namadepCust, namabelCust, alamatCust, tlpCust;
        private BindingSource CustomerBindingSource;
        public Customer()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            CustomerBindingSource = new BindingSource();
            refreshform();
        }
        private void refreshform()
        {
            txtId.Text = "";
            txtId.Enabled = false;
            txtNama.Enabled = false;
            txtNama.Text = "";
            txtNamadep.Enabled = false;
            txtNamadep.Text = "";
            txtNamabel.Enabled = false;
            txtNamabel.Text = "";
            txtAlamat.Enabled = false;
            txtAlamat.Text = "";
            txtTelpon.Enabled = false;
            txtTelpon.Text = "";
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            clearBinding();
        }
        private void clearBinding()
        {
            this.txtId.DataBindings.Clear();
            this.txtNama.DataBindings.Clear();
            this.txtNamadep.DataBindings.Clear();
            this.txtNamabel.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.txtTelpon.DataBindings.Clear();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Customer";
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
                txtId.Text = row.Cells["id_customer"].Value.ToString();
                txtNama.Text = row.Cells["nama_customer"].Value.ToString();
                txtNamadep.Text = row.Cells["namadep_customer"].Value.ToString();
                txtNamabel.Text = row.Cells["namabel_customer"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat_customer"].Value.ToString();
                txtTelpon.Text = row.Cells["tlp_customer"].Value.ToString();

                txtNama.Enabled = false;
                txtAlamat.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = true;
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string id_customer = dataGridView1.SelectedRows[0].Cells["id_customer"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.Customer WHERE id_customer = @id_customer";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id_customer", id_customer));
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNama.Enabled = true;
            txtNamadep.Enabled = true;
            txtNamabel.Enabled=true;
            txtAlamat.Enabled = true;
            txtTelpon.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idCust = txtId.Text.Trim();
            namaCust = txtNama.Text.Trim();
            namadepCust = txtNamadep.Text.Trim();
            namabelCust = txtNamabel.Text.Trim();
            alamatCust = txtAlamat.Text.Trim();
            tlpCust = txtTelpon.Text.Trim();
            if (string.IsNullOrEmpty(idCust) || string.IsNullOrEmpty(namaCust) || string.IsNullOrEmpty(namadepCust) || string.IsNullOrEmpty(namabelCust) || string.IsNullOrEmpty(alamatCust) || string.IsNullOrEmpty(tlpCust))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO Customer (id_customer, nama_customer, namadep_customer, namabel_customer, alamat_customer, tlp_customer) VALUES (@id_customer, @nama_customer, @namadep_customer, @namabel_customer, @alamat_customer, @tlp_customer)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.AddWithValue("@id_customer", idCust);
                cmd.Parameters.AddWithValue("@nama_customer", namaCust);
                cmd.Parameters.AddWithValue("@namadep_customer", namadepCust);
                cmd.Parameters.AddWithValue("@namabel_customer", namabelCust);
                cmd.Parameters.AddWithValue("@alamat_customer", alamatCust);
                cmd.Parameters.AddWithValue("@tlp_customer", tlpCust);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNama.Text = "";
            txtNamadep.Text = "";
            txtNamabel.Text = "";
            txtAlamat.Text = "";
            txtTelpon.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Data_Master fm = new Data_Master();
            fm.Show();
            this.Hide();
        }
    }
}
