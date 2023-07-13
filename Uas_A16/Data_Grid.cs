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
    public partial class Data_Grid : Form
    {
        private string stringConnection = "Data Source=LAPTOP-OPC709QK;Initial Catalog=Toko_Maju;Persist Security Info=True;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Data_Grid()
        {
            InitializeComponent();
        }

        private void Data_Grid_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand;
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            sp.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu bc = new Menu();
            bc.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Brand br = new Brand();
            br.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Jenis jn = new Jenis();
            jn.Show();
            this.Hide();
        }
    }
}
