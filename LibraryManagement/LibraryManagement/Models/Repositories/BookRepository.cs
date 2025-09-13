using LibraryManagement.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagement.Models.Repositories
{
    internal class BookRepository
    {
        internal Dictionary<int, Book> booksDictionary = new Dictionary<int, Book>();
        private BorrowForm borrowForm;
        private MySqlConnection connection;

        public BookRepository() { }
        public BookRepository(BorrowForm borrowForm)
        {
            PopulateDictionary();
            this.borrowForm = borrowForm;
            this.connection = new MySqlConnection(Program.connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        private void PopulateDictionary()
        {
            try
            {
                using (var connection = new MySqlConnection(Program.connectionString))
                {
                    connection.Open();

                    var query = "SELECT * FROM Books";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("BookID");
                                string title = reader.GetString("Title");
                                string author = reader.GetString("Author");
                                string genre = reader.GetString("Genre");
                                string isbn = reader.GetString("ISBN");
                                int availableCopies = reader.GetInt32("AvailableCopies");
                                int totalCopies = reader.GetInt32("TotalCopies");

                                var book = new Book(id, title, author, genre, isbn, availableCopies, totalCopies);
                                this.booksDictionary[id] = book;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching books from database: {ex.Message}");
            }
        }
        internal DataTable GetAllBooks()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("BookID");
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Genre");
            dataTable.Columns.Add("ISBN");
            dataTable.Columns.Add("AvailableCopies");
            dataTable.Columns.Add("TotalCopies");

            foreach (var book in this.booksDictionary.Values)
                dataTable.Rows.Add(book.BookID, book.Title, book.Author, book.Genre, book.ISBN, book.AvailableCopies, book.TotalCopies);

            return dataTable;
        }
        internal DataView? SearchBookByValue(DataTable dataTable, string property, string value)
        {
            string filterExpression = $"{property} LIKE '{value}%'";
            if (int.TryParse(value, out int parsedValue) && property != "ISBN")
                filterExpression = $"{property} = {parsedValue}";

            DataView? dataView = new DataView(dataTable) { RowFilter = filterExpression };
            return dataView;
        }
        internal DataView ComplexFilter()
        {
            List<string> filters = new List<string>();

            if (!string.IsNullOrWhiteSpace(borrowForm.titleSearchBar.Text))
                filters.Add($"Title LIKE '{borrowForm.titleSearchBar.Text}%'");
            if (!string.IsNullOrWhiteSpace(borrowForm.authorSearchBar.Text))
                filters.Add($"Author LIKE '{borrowForm.authorSearchBar.Text}%'");
            if (!string.IsNullOrWhiteSpace(borrowForm.idSearchBar.Text) && int.TryParse(borrowForm.idSearchBar.Text, out int parsedId))
                filters.Add($"BookID = {parsedId}");
            if (!string.IsNullOrWhiteSpace(borrowForm.genreSearchBar.Text))
                filters.Add($"Genre LIKE '{borrowForm.genreSearchBar.Text}%'");

            string filterExpression = string.Join(" AND ", filters);

            return new DataView(borrowForm.dataTable) { RowFilter = filterExpression };
        }

        public List<CheckedOutBook> GetUnreturnedBooks(int memberID)
        {
            var unreturnedBooks = new List<CheckedOutBook>();
            string query = @"
        SELECT c.CheckoutID, b.BookID, b.Title, b.Author, c.CheckoutDate, c.DueDate 
        FROM Books b
        INNER JOIN Checkouts c ON b.BookID = c.BookID
        WHERE c.MemberID = @MemberID AND c.ReturnDate IS NULL";

            using (connection = new MySqlConnection(Program.connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MemberID", memberID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var book = new CheckedOutBook(
                                (int)reader["CheckoutID"],
                                (int)reader["BookID"],
                                (string)reader["Title"],
                                (string)reader["Author"],
                                (DateTime)reader["CheckoutDate"],
                                (DateTime)reader["DueDate"]
                            );
                            unreturnedBooks.Add(book);
                        }
                    }
                }
            }

            return unreturnedBooks;
        }

        internal bool AddBook(string title, string author, string genre, string isbn, int totalCopies)
        {
            var query = "INSERT INTO books (Title,Author,Genre,ISBN,AvailableCopies,TotalCopies) VALUES (@Title,@Author,@Genre,@ISBN,@AvailableCopies,@TotalCopies)";
            try
            {
                using (this.connection = new MySqlConnection(Program.connectionString))
                {
                    this.connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@ISBN", isbn);
                        command.Parameters.AddWithValue("@AvailableCopies", totalCopies);
                        command.Parameters.AddWithValue("@TotalCopies", totalCopies);

                        var rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book to database: {ex.Message}");
                return false;
            }
        }
    }
}
