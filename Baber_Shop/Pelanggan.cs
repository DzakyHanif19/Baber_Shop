using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Baber_Shop
{
    public partial class Pelanggan : Form
    {
        private string connectionString = "Data Source=LAPTOP-0SQR7EBD\\DZAKYHANIFANNAFI;Initial Catalog=BarberShop;Integrated Security=True";

        public Pelanggan()
        {
            InitializeComponent();
        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barberShopDataSet.Pelanggan' table. You can move, or remove it, as needed.
            this.pelangganTableAdapter.Fill(this.barberShopDataSet.Pelanggan);
            // Load data into the DataGridView
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pelanggan", conn);
                    DataTable pelangganTable = new DataTable();
                    adapter.Fill(pelangganTable);
                    pelangganDataGridView.DataSource = pelangganTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pelanggan (Name, Phone) VALUES (@Name, @Phone)", conn);
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully.");
                    LoadData(); // Refresh data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding customer: " + ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (pelangganDataGridView.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(pelangganDataGridView.SelectedRows[0].Cells["CustomerId"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Pelanggan WHERE CustomerId = @CustomerId", conn);
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer deleted successfully.");
                        LoadData(); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting customer: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (pelangganDataGridView.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(pelangganDataGridView.SelectedRows[0].Cells["CustomerId"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Pelanggan SET Name = @Name, Phone = @Phone WHERE CustomerId = @CustomerId", conn);
                        cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer updated successfully.");
                        LoadData(); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating customer: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to update.");
            }
        }
    }
}
