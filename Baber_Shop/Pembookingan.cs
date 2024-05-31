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

namespace Baber_Shop
{
    public partial class Pembookingan : Form
    {
        private string connectionString = "Data Source=LAPTOP-0SQR7EBD\\DZAKYHANIFANNAFI;Initial Catalog=BarberShop;Integrated Security=True";

        public Pembookingan()
        {
            InitializeComponent();
        }

        private void Pembookingan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barberShopDataSet.Pembookingan' table. You can move, or remove it, as needed.
            this.pembookinganTableAdapter.Fill(this.barberShopDataSet.Pembookingan);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pembookingan (CustomerName, BookingDate) VALUES (@CustomerName, @BookingDate)", conn);
                    cmd.Parameters.AddWithValue("@CustomerName", customerNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@BookingDate", bookingDateTimePicker.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking added successfully.");
                    this.pembookinganTableAdapter.Fill(this.barberShopDataSet.Pembookingan); // Refresh data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding booking: " + ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (pembookinganDataGridView.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(pembookinganDataGridView.SelectedRows[0].Cells["BookingId"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Pembookingan WHERE BookingId = @BookingId", conn);
                        cmd.Parameters.AddWithValue("@BookingId", bookingId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Booking deleted successfully.");
                        this.pembookinganTableAdapter.Fill(this.barberShopDataSet.Pembookingan); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting booking: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to delete.");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (pembookinganDataGridView.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(pembookinganDataGridView.SelectedRows[0].Cells["BookingId"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Pembookingan SET CustomerName = @CustomerName, BookingDate = @BookingDate WHERE BookingId = @BookingId", conn);
                        cmd.Parameters.AddWithValue("@CustomerName", customerNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@BookingDate", bookingDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@BookingId", bookingId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Booking updated successfully.");
                        this.pembookinganTableAdapter.Fill(this.barberShopDataSet.Pembookingan); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating booking: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to update.");
            }
        }
    }
}
