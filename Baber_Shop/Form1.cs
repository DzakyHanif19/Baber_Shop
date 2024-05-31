using System;
using System.Windows.Forms;

namespace Baber_Shop
{
    public partial class Form1 : Form
    {
        string curFileName;
        string connectionString = "Data Source=LAPTOP-0SQR7EBD\\DZAKYHANIFANNAFI;" +
            "Initial Catalog=BarberShop;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pelanggan_Click(object sender, EventArgs e)
        {
            Pelanggan pelangganForm = new Pelanggan();
            pelangganForm.Show();
        }

        private void Antrian_Click(object sender, EventArgs e)
        {
            Antrian antrianForm = new Antrian();
            antrianForm.Show();
        }

        private void Pembookingan_Click(object sender, EventArgs e)
        {
            Pembookingan pembookinganForm = new Pembookingan();
            pembookinganForm.Show();
        }

        private void TukangCukur_Click(object sender, EventArgs e)
        {
            Tukang_Cukur tukangCukurForm = new Tukang_Cukur();
            tukangCukurForm.Show();
        }
    }
}
