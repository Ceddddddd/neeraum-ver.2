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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sub.Hide();
            displayoverall();
            displayprice();
            displaysold();
            displayearning();
            display1();
            display2();
            display3();
            display4();
            display5();
        }
        private void display5() {
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string query = "SELECT t.TransactionID, t.TireTypeID, t.Price, t.Stocks, t.Sold, tt.TireType\r\nFROM Taurus t\r\nINNER JOIN TireTypes tt ON t.TireTypeID = tt.TireTypeID\r\nWHERE t.TireTypeID = 5;";

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
                        dataGridView7.DataSource = dataTable;
                        foreach (DataGridViewColumn column in dataGridView7.Columns)
                        {
                            column.Width = 119;
                        }

                    }
                }
            }

        }
        private void display4() {
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string query = "SELECT v.TransactionID, v.TireTypeID, v.Price, v.Stocks, v.Sold, tt.TireType\r\nFROM Velocity v\r\nINNER JOIN TireTypes tt ON v.TireTypeID = tt.TireTypeID\r\nWHERE v.TireTypeID = 4;";

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
                        dataGridView6.DataSource = dataTable;
                        foreach (DataGridViewColumn column in dataGridView6.Columns)
                        {
                            column.Width = 119;
                        }

                    }
                }
            }

        }
        private void display3() {
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string query = "SELECT sf.TransactionID, sf.TireTypeID, sf.Price, sf.Stocks, sf.Sold, tt.TireType\r\nFROM SonyFront sf\r\nINNER JOIN TireTypes tt ON sf.TireTypeID = tt.TireTypeID\r\nWHERE sf.TireTypeID = 3;";

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
                        dataGridView5.DataSource = dataTable;
                        foreach (DataGridViewColumn column in dataGridView5.Columns)
                        {
                            column.Width = 119;
                        }

                    }
                }
            }

        }
        private void display2() {
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string query = "SELECT s.TransactionID, s.TireTypeID, s.Price, s.Stocks, s.Sold, tt.TireType\r\nFROM Samurai s\r\nINNER JOIN TireTypes tt ON s.TireTypeID = tt.TireTypeID\r\nWHERE s.TireTypeID = 2;";

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
                        dataGridView4.DataSource = dataTable;
                        foreach (DataGridViewColumn column in dataGridView4.Columns)
                        {
                            column.Width = 119;
                        }

                    }
                }
            }

        }
        private void display1() {
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string query = "SELECT ll.TransactionID, ll.TireTypeID, ll.Price, ll.Stocks, ll.Sold, tt.TireType\r\nFROM LeoLaseer ll\r\nINNER JOIN TireTypes tt ON ll.TireTypeID = tt.TireTypeID\r\nWHERE ll.TireTypeID = 1;";

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
                        dataGridView3.DataSource = dataTable;
                        foreach (DataGridViewColumn column in dataGridView3.Columns)
                        {
                            column.Width = 119;
                        }

                    }
                }
            }
        }

        private void displayearning() {
            // Connection string
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            // Define the variable to store the total earnings
            decimal totalEarnings = 0;

            // SQL query
            string query = @"
            SELECT 
                SUM((s.Sold * s.Price) - ((s.Stocks - s.Sold) * s.Price)) AS TotalEarnings
            FROM 
                (
                SELECT 
                    ll.Sold,
                    ll.Price,
                    ll.Stocks
                FROM 
                    LeoLaseer ll

                UNION ALL

                SELECT 
                    s.Sold,
                    s.Price,
                    s.Stocks
                FROM 
                    Samurai s

                UNION ALL

                SELECT 
                    sf.Sold,
                    sf.Price,
                    sf.Stocks
                FROM 
                    SonyFront sf

                UNION ALL

                SELECT 
                    v.Sold,
                    v.Price,
                    v.Stocks
                FROM 
                    Velocity v

                UNION ALL

                SELECT 
                    ta.Sold,
                    ta.Price,
                    ta.Stocks
                FROM 
                    Taurus ta
                ) AS s;
        ";

            // Execute the query and retrieve the result
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        // Execute the query and retrieve the result
                        totalEarnings = (decimal)command.ExecuteScalar();
                        label8.Text = totalEarnings.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
        private void displaysold()
        {
            // Connection string
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            // Define the variable to store the total overall sold quantity
            int totalOverallSold = 0;

            // SQL query
            string query = @"
            DECLARE @TotalOverallSold INT;

            SELECT @TotalOverallSold = SUM(OverallSold)
            FROM (
                SELECT 
                    t.TireTypeID,
                    t.TireType,
                    SUM(ISNULL(ll.Price, 0) + ISNULL(s.Price, 0) + ISNULL(sf.Price, 0) + ISNULL(v.Price, 0) + ISNULL(ta.Price, 0)) AS OverallPrice,
                    SUM(ISNULL(ll.Stocks, 0) + ISNULL(s.Stocks, 0) + ISNULL(sf.Stocks, 0) + ISNULL(v.Stocks, 0) + ISNULL(ta.Stocks, 0)) AS OverallStocks,
                    SUM(ISNULL(ll.Sold, 0) + ISNULL(s.Sold, 0) + ISNULL(sf.Sold, 0) + ISNULL(v.Sold, 0) + ISNULL(ta.Sold, 0)) AS OverallSold
                FROM 
                    TireTypes t
                LEFT JOIN 
                    LeoLaseer ll ON t.TireTypeID = ll.TireTypeID
                LEFT JOIN 
                    Samurai s ON t.TireTypeID = s.TireTypeID
                LEFT JOIN 
                    SonyFront sf ON t.TireTypeID = sf.TireTypeID
                LEFT JOIN 
                    Velocity v ON t.TireTypeID = v.TireTypeID
                LEFT JOIN 
                    Taurus ta ON t.TireTypeID = ta.TireTypeID
                GROUP BY 
                    t.TireTypeID,
                    t.TireType
            ) AS OverallSales;

            -- Output the total overall sold quantity
            SELECT @TotalOverallSold;
        ";

            // Execute the query and retrieve the result
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        // Execute the query
                        totalOverallSold = (int)command.ExecuteScalar();
                        lblsold.Text = totalOverallSold.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
        private void displayprice()
        {
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            // Define the variable to store the total overall price
            decimal totalOverallPrice = 0;

            // SQL query
            string query = @"
            DECLARE @TotalOverallPrice DECIMAL(10, 2);

            SELECT @TotalOverallPrice = SUM(OverallPrice)
            FROM (
                SELECT 
                    t.TireTypeID,
                    t.TireType,
                    SUM(ISNULL(ll.Price * ll.Stocks, 0) + ISNULL(s.Price * s.Stocks, 0) + ISNULL(sf.Price * sf.Stocks, 0) + ISNULL(v.Price * v.Stocks, 0) + ISNULL(ta.Price * ta.Stocks, 0)) AS OverallPrice
                FROM 
                    TireTypes t
                LEFT JOIN 
                    LeoLaseer ll ON t.TireTypeID = ll.TireTypeID
                LEFT JOIN 
                    Samurai s ON t.TireTypeID = s.TireTypeID
                LEFT JOIN 
                    SonyFront sf ON t.TireTypeID = sf.TireTypeID
                LEFT JOIN 
                    Velocity v ON t.TireTypeID = v.TireTypeID
                LEFT JOIN 
                    Taurus ta ON t.TireTypeID = ta.TireTypeID
                GROUP BY 
                    t.TireTypeID,
                    t.TireType
            ) AS OverallPrices;

            -- Output the total overall price
            SELECT @TotalOverallPrice;
        ";

            // Execute the query and retrieve the result
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        // Execute the query
                        totalOverallPrice = (decimal)command.ExecuteScalar();
                        lblprice.Text = totalOverallPrice.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
        private void displayoverall() {
            // SQL query to select data from the LeoLaseer table
            string connectionString = "Data Source=DESKTOP-C75ROGV\\SQLEXPRESS;Initial Catalog=maureen;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string query = "SELECT \r\n    t.TireTypeID,\r\n    t.TireType,\r\n    SUM(ISNULL(ll.Price, 0) + ISNULL(s.Price, 0) + ISNULL(sf.Price, 0) + ISNULL(v.Price, 0) + ISNULL(ta.Price, 0)) AS OverallPrice,\r\n    SUM(ISNULL(ll.Stocks, 0) + ISNULL(s.Stocks, 0) + ISNULL(sf.Stocks, 0) + ISNULL(v.Stocks, 0) + ISNULL(ta.Stocks, 0)) AS OverallStocks,\r\n    SUM(ISNULL(ll.Sold, 0) + ISNULL(s.Sold, 0) + ISNULL(sf.Sold, 0) + ISNULL(v.Sold, 0) + ISNULL(ta.Sold, 0)) AS OverallSold\r\nFROM \r\n    TireTypes t\r\nLEFT JOIN \r\n    LeoLaseer ll ON t.TireTypeID = ll.TireTypeID\r\nLEFT JOIN \r\n    Samurai s ON t.TireTypeID = s.TireTypeID\r\nLEFT JOIN \r\n    SonyFront sf ON t.TireTypeID = sf.TireTypeID\r\nLEFT JOIN \r\n    Velocity v ON t.TireTypeID = v.TireTypeID\r\nLEFT JOIN \r\n    Taurus ta ON t.TireTypeID = ta.TireTypeID\r\nGROUP BY \r\n    t.TireTypeID,\r\n    t.TireType;";

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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Taurus taurus = new Taurus();
            this.Hide();
            taurus.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Leo leo = new Leo();   
            this.Hide();
            leo.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            samurai samurai = new samurai();
            this.Hide(); samurai.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SonyFront sonyFront = new SonyFront();
            this.Hide(); sonyFront.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Velocity velocity = new Velocity();
            this.Hide();
            velocity.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sub.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sub.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }
    }
}
