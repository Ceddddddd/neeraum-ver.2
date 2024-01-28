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

namespace Mau
{
    public partial class Velocity : Form
    {
        public Velocity()
        {
            InitializeComponent();
            display();
        }
        private void display() {
            // SQL query to select data from the LeoLaseer table
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string query = "SELECT * FROM Velocity";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlDataAdapter to execute the query and fill the data into a DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Create a DataTable to store the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the SqlDataAdapter
                        adapter.Fill(dataTable);

                        // Set the DataSource property of the DataGridView to the DataTable
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string for your SQL Server
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            // Values to insert
            string transaction_id = textBox1.Text;
            int tiretypeID = 4;
            string tire = textBox2.Text;
            decimal price = decimal.Parse(textBox3.Text);
            int stock = int.Parse(textBox4.Text);
            int sold = int.Parse(textBox5.Text);

            // Create the SQL insert statement
            string insertQuery = @"INSERT INTO Velocity (TransactionID, TireTypeID, Tire, Price, Stocks, Sold)
                                   VALUES (@TransactionID, @TireTypeID, @Tire, @Price, @Stocks, @Sold)";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@TransactionID", transaction_id);
                    command.Parameters.AddWithValue("@TireTypeID", tiretypeID);
                    command.Parameters.AddWithValue("@Tire", tire);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Stocks", stock);
                    command.Parameters.AddWithValue("@Sold", sold);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        display();
                        // Check if the query executed successfully
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting data: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            // Values to update
            string transaction_id = textBox1.Text;
            int tiretypeID = 4;
            string tire = textBox2.Text;
            decimal price = decimal.Parse(textBox3.Text);
            int stock = int.Parse(textBox4.Text);
            int sold = int.Parse(textBox5.Text);

            // Create the SQL update statement
            string updateQuery = @"UPDATE Velocity
                      SET TireTypeID = @TireTypeID, 
                          Tire = @Tire, 
                          Price = @Price, 
                          Stocks = @Stocks, 
                          Sold = @Sold 
                      WHERE TransactionID = @TransactionID";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@TransactionID", transaction_id);
                    command.Parameters.AddWithValue("@TireTypeID", tiretypeID);
                    command.Parameters.AddWithValue("@Tire", tire);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Stocks", stock);
                    command.Parameters.AddWithValue("@Sold", sold);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        display();

                        // Check if the query executed successfully
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were Updated.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update Failed: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            // Get the TransactionID to delete
            string transaction_id = textBox1.Text;

            // Create the SQL delete statement
            string deleteQuery = @"DELETE FROM Velocity
                       WHERE TransactionID = @TransactionID";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    // Add the TransactionID parameter
                    command.Parameters.AddWithValue("@TransactionID", transaction_id);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the delete query
                        int rowsAffected = command.ExecuteNonQuery();
                        display();
                        // Check if any rows were deleted
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row Deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were deleted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete Failed: " + ex.Message);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Fill textboxes with data from the selected row
                textBox1.Text = selectedRow.Cells["TransactionID"].Value?.ToString() ?? "";
                textBox2.Text = selectedRow.Cells["Tire"].Value?.ToString() ?? "";
                textBox3.Text = selectedRow.Cells["Price"].Value?.ToString() ?? "";
                textBox4.Text = selectedRow.Cells["Stocks"].Value?.ToString() ?? "";
                textBox5.Text = selectedRow.Cells["Sold"].Value?.ToString() ?? "";
                // Add more textboxes and column names as needed
            }
        }
    }
}
