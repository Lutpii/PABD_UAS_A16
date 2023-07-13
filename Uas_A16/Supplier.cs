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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_MajuDataSet4.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter1.Fill(this.toko_MajuDataSet4.Supplier);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Grid da = new Data_Grid();
            da.Show();
            this.Hide();
        }
    }
}
