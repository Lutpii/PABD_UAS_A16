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
        private string id_customer, nama_customer, namadep_customer, namabel_customer, alamat_customer, tlp_customer;
        private BindingSource CustomerBindingSource;

        public Customer()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            CustomerBindingSource = new BindingSource();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id_customer = textBox1.Text.Trim();
            nama_customer = textBox2.Text.Trim();
            namadep_customer = textBox3.Text.Trim();
            namabel_customer = textBox4.Text.Trim();
            alamat_customer = textBox5.Text.Trim();
            tlp_customer = textBox6.Text.Trim();
            if (string.IsNullOrEmpty(id_customer) || string.IsNullOrEmpty(nama_customer) || string.IsNullOrEmpty(namadep_customer) || string.IsNullOrEmpty(namabel_customer) || string.IsNullOrEmpty(alamat_customer) || string.IsNullOrEmpty(tlp_customer))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO customer (id_customer, nama_customer, namadep_customer, namabel_customer, alamat_customer, tlp_customer) VALUES (@id_customer, @nama_customer, @namadep_customer, @namabel_customer, @alamat_customer, @tlp_customer)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.AddWithValue("@id_customer", id_customer);
                cmd.Parameters.AddWithValue("@nama_customer", nama_customer);
                cmd.Parameters.AddWithValue("@namadep_customer", namadep_customer);
                cmd.Parameters.AddWithValue("@namabel_customer", namabel_customer);
                cmd.Parameters.AddWithValue("@alamat_customer", alamat_customer);
                cmd.Parameters.AddWithValue("@tlp_customer", tlp_customer);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                MessageBox.Show("Data Berhasil Disimpan");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Data_Master fm = new Data_Master();
            fm.Show();
            this.Hide();
        }
    }
}
