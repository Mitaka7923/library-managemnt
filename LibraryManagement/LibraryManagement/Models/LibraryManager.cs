using LibraryManagement.Models.Repositories;
using MySql.Data.MySqlClient;

namespace LibraryManagement.Models
{
    internal class LibraryManager
    {
        private Member member;
        MySqlConnection connection;
        private CheckoutRepository checkoutRepository;
        private BookRepository bookRepository;

        public LibraryManager(MySqlConnection connection, BookRepository bookRepository, Member member)
        {
            this.bookRepository = bookRepository;
            this.member = member;
            this.connection = connection;
            this.connection.Open();
            this.checkoutRepository = new CheckoutRepository();
        }

        public bool CheckoutBook(DataGridView dataGridView)
        {
            if (dataGridView != null && dataGridView.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                int selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);
                var book = this.bookRepository.booksDictionary[selectedID];

                if (book.AvailableCopies > 0)
                {
                    var isUserSure = ConfirmCheckout(book);
                    if (isUserSure)
                    {
                        PerformCheckout(book);
                        MessageBox.Show("Успешен наем!");
                        return true;
                    }
                }
                else
                    MessageBox.Show("Няма налични копия за наемане.");
            }
            return false;
        }

        public void ReturnBook(int checkOutID, DateTime returnDate)
        {
            using (this.connection = new MySqlConnection(this.connection.ConnectionString))
            {
                this.connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string updateCheckoutQuery = "UPDATE Checkouts SET ReturnDate = @ReturnDate WHERE CheckoutID = @CheckOutID";
                    using (MySqlCommand cmd = new MySqlCommand(updateCheckoutQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                        cmd.Parameters.AddWithValue("@CheckOutID", checkOutID);
                        cmd.ExecuteNonQuery();
                    }

                    string getBookIDQuery = "SELECT BookID FROM Checkouts WHERE CheckoutID = @CheckOutID";
                    int bookID;
                    using (MySqlCommand cmd = new MySqlCommand(getBookIDQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@CheckOutID", checkOutID);
                        bookID = (int)cmd.ExecuteScalar();
                    }

                    string updateBookCopiesQuery = "UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID = @BookID";
                    using (MySqlCommand cmd = new MySqlCommand(updateBookCopiesQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Грешка при връщане на книгаk: " + ex.Message);
                }
            }
        }
        private bool ConfirmCheckout(Book book)
        {
            return MessageBox.Show($@"Наем: 
Име: {this.member.Name} 
Книга: ""{book.Title}"", на {book.Author}?",
                "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
        }

        private void PerformCheckout(Book book)
        {
            var checkout = new Checkout(book.BookID,
                memberID: this.member.MemberID,
                checkOutDate: DateTime.Now,
                dueDate: DateTime.Now.AddDays(14)
            );

            int newCheckoutID = this.checkoutRepository.AddCheckout(checkout);
            checkout.CheckOutID = newCheckoutID;

            this.checkoutRepository.UpdateAvailableCopies(book.BookID, -1);
        }
    }

}
