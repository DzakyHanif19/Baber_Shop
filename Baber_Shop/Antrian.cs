using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Baber_Shop
{
    public partial class Antrian : Form
    {
        private string connectionString = "Data Source=LAPTOP-0SQR7EBD\\DZAKYHANIFANNAFI;Initial Catalog=BarberShop;Integrated Security=True";

        public Antrian()
        {
            InitializeComponent();
        }

        private void Antrian_Load(object sender, EventArgs e)
        {
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
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Antrian", conn);
                    DataTable antrianTable = new DataTable();
                    adapter.Fill(antrianTable);
                    antrianDataGridView.DataSource = antrianTable;
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Antrian (CustomerId, QueueNumber, Date) VALUES (@CustomerId, @QueueNumber, @Date)", conn);
                    cmd.Parameters.AddWithValue("@CustomerId", customerIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@QueueNumber", queueNumberTextBox.Text);
                    cmd.Parameters.AddWithValue("@Date", dateDateTimePicker.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Queue added successfully.");
                    LoadData(); // Refresh data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding queue: " + ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (antrianDataGridView.SelectedRows.Count > 0)
            {
                int queueId = Convert.ToInt32(antrianDataGridView.SelectedRows[0].Cells["QueueId"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Antrian WHERE QueueId = @QueueId", conn);
                        cmd.Parameters.AddWithValue("@QueueId", queueId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Queue deleted successfully.");
                        LoadData(); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting queue: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a queue to delete.");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (antrianDataGridView.SelectedRows.Count > 0)
            {
                int queueId = Convert.ToInt32(antrianDataGridView.SelectedRows[0].Cells["QueueId"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Antrian SET CustomerId = @CustomerId, QueueNumber = @QueueNumber, Date = @Date WHERE QueueId = @QueueId", conn);
                        cmd.Parameters.AddWithValue("@CustomerId", customerIdTextBox.Text);
                        cmd.Parameters.AddWithValue("@QueueNumber", queueNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@Date", dateDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@QueueId", queueId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Queue updated successfully.");
                        LoadData(); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating queue: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a queue to update.");
            }
        }
    }
}
