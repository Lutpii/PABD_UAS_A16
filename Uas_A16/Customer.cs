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
        private string stringConnection = "Data Source=LAPTOP-OPC709QK;Initial Catalog=PabdAct6;Persist Security Info=True;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
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
            txtNIM.Enabled = true;
            txtNama.Enabled = true;
            txtAlamat.Enabled = true;
            cbxJenisKelamin.Enabled = true;
            dtTanggalLahir.Enabled = true;
            cbxProdi.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            clearBinding();
        }
        private void clearBinding()
        {
            this.txtNIM.DataBindings.Clear();
            this.txtNama.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.cbxJenisKelamin.DataBindings.Clear();
            this.dtTanggalLahir.DataBindings.Clear();
            this.cbxProdi.DataBindings.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Data_Master fm = new Data_Master();
            fm.Show();
            this.Hide();
        }
    }
}
