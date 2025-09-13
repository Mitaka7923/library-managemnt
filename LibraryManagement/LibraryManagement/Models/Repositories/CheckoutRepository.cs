using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagement.Models.Repositories
{
    internal class CheckoutRepository
    {
        private MySqlConnection connection;
        private readonly string connectionString = "Server=localhost;Database=librarymanagementdb;Uid=root;Pwd=;";
        public CheckoutRepository()
        {
            connection = new MySqlConnection(connectionString);
        }

        public int AddCheckout(Checkout checkout)
        {
            string query = "INSERT INTO Checkouts (BookID, MemberID, CheckOutDate, DueDate) " +
                           "VALUES (@BookID, @MemberID, @CheckOutDate, @DueDate); " +
                           "SELECT LAST_INSERT_ID();";

            using (connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BookID", checkout.BookID);
                    cmd.Parameters.AddWithValue("@MemberID", checkout.MemberID);
                    cmd.Parameters.AddWithValue("@CheckOutDate", checkout.CheckOutDate);
                    cmd.Parameters.AddWithValue("@DueDate", checkout.DueDate);

                    int newCheckoutID = Convert.ToInt32(cmd.ExecuteScalar());
                    return newCheckoutID;
                }
            }
        }
        public DataTable GetCheckouts(string span)
        {
            var data = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.connectionString))
                {
                    connection.Open();

                    string query = null;

                    if (span == "monthly")
                    {
                        query = @"
                    SELECT * 
                    FROM Checkouts 
                    WHERE MONTH(CheckOutDate) = MONTH(CURRENT_DATE) 
                    AND YEAR(CheckOutDate) = YEAR(CURRENT_DATE) 
                    ORDER BY DueDate DESC";
                    }
                    else if (span == "daily")
                    {
                        query = @"
                    SELECT * 
                    FROM Checkouts 
                    WHERE DATE(CheckOutDate) = CURRENT_DATE 
                    ORDER BY DueDate DESC";
                    }

                    if (query != null)
                    {
                        using (var command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                data.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching checkouts from database: {ex.Message}");
            }

            return data;
        }

        public void UpdateAvailableCopies(int bookID, int adjustment)
        {
            string query = "UPDATE Books SET AvailableCopies = AvailableCopies + @Adjustment WHERE BookID = @BookID";
            using (connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Adjustment", adjustment);
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
