using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baber_Shop
{
    public partial class Tukang_Cukur : Form
    {
        public Tukang_Cukur()
        {
            InitializeComponent();
        }

        private void Tukang_Cukur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barberShopDataSet.TukangCukur' table. You can move, or remove it, as needed.
            this.tukangCukurTableAdapter.Fill(this.barberShopDataSet.TukangCukur);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Add customer logic here
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Delete customer logic here
        }

        private void Update_Click(object sender, EventArgs e)
        {
            // Update customer logic here
        }
    }
}
