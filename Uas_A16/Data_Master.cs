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
    public partial class Data_Master : Form
    {
        public Data_Master()
        {
            InitializeComponent();
        }

        private void Data_Master_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer nx = new Customer();
            nx.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu bc = new Menu();
            bc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaksi nx = new Transaksi();
            nx.Show();
            this.Hide();
        }
    }
}
