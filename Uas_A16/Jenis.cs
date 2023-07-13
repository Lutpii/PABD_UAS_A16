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
    public partial class Jenis : Form
    {
        public Jenis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Grid da = new Data_Grid();
            da.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void jenisBarangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Jenis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_MajuDataSet6.Jenis_Barang' table. You can move, or remove it, as needed.
            this.jenis_BarangTableAdapter.Fill(this.toko_MajuDataSet6.Jenis_Barang);

        }
    }
}
