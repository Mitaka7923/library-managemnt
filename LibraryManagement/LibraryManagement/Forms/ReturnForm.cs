using LibraryManagement.Models;
using LibraryManagement.Models.Repositories;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagement.Forms
{
    internal partial class ReturnForm : Form
    {
        private Member member;
        private BookRepository bookRepository;
        private LibraryManager libraryManager;
        private DataTable dataTable;

        public ReturnForm(Member member, BookRepository bookRepository)
        {
            InitializeComponent();
            this.member = member;
            this.bookRepository = bookRepository;
            InitializeDataGridView();
            DisplayUnreturnedBooksInGrid(this.member.MemberID);
            this.libraryManager = new LibraryManager(new MySqlConnection(Program.connectionString), this.bookRepository, this.member);
        }
        private void InitializeDataGridView()
        {
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void DisplayUnreturnedBooksInGrid(int memberID)
        {
            var books = this.bookRepository.GetUnreturnedBooks(memberID);

            if (books.Count == 0)
                MessageBox.Show("Този читател няма книги за връщане!");

            this.bookDataGridView.DataSource = books;
            this.bookDataGridView.Columns["CheckoutDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
            this.bookDataGridView.Columns["DueDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }


        private void returnButton_Click(object sender, EventArgs e)
        {
            var bookName = this.bookDataGridView.SelectedRows[0].Cells[2].Value;
            var bookAuthor = this.bookDataGridView.SelectedRows[0].Cells[3].Value;
            var checkoutID = Convert.ToInt32(this.bookDataGridView.SelectedRows[0].Cells[0].Value);

            var isUserSure = MessageBox.Show($@"Име: {this.member.Name} 
Връща ""{bookName}"", {bookAuthor}?", "ПОТВЪРЖДЕНИЕ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (isUserSure == DialogResult.OK)
            {
                this.libraryManager.ReturnBook(checkoutID, DateTime.Now);
                MessageBox.Show($@"{this.member.Name} върна ""{bookName}""!");
            }
            DisplayUnreturnedBooksInGrid(this.member.MemberID);
        }
    }
}