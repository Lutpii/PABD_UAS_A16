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
    public partial class Data_Grid : Form
    {
        public Data_Grid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu bc = new Menu();
            bc.Show();
            this.Hide();
        }

        private void Data_Grid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_MajuDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.toko_MajuDataSet.Customer);
        }
    }
}
