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
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_MajuDataSet5.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.toko_MajuDataSet5.Brand);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Grid da = new Data_Grid();
            da.Show();
            this.Hide();
        }
    }
}
