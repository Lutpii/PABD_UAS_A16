using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uas_A16
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null; 
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }
    }
}
