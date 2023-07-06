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
    }
}
