using LibraryManagement.Models;
using LibraryManagement.Models.Repositories;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagement.Forms
{
    internal partial class BorrowForm : Form
    {
        internal DataTable dataTable;
        private Member member;
        private LibraryManager libraryManager;
        private BookRepository bookRepository;

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearSelection();
        }
        public BorrowForm(Member member)
        {
            InitializeComponent();
            InitializeDataGridView();

            this.member = member;
            this.bookRepository = new BookRepository(this);
            this.libraryManager = new LibraryManager(new MySqlConnection(Program.connectionString), this.bookRepository, this.member);
        }
        private void InitializeDataGridView()
        {
            this.booksDataGrid.AllowUserToAddRows = false;
            this.booksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataTable = new DataTable();
            dataTable.Columns.Add("BookID");
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Genre");
            dataTable.Columns.Add("ISBN");
            dataTable.Columns.Add("AvailableCopies");
            dataTable.Columns.Add("TotalCopies");
        }
        private void LoadData()
        {
            this.dataTable = bookRepository.GetAllBooks();
            this.booksDataGrid.DataSource = this.dataTable;
            this.booksDataGrid.BeginInvoke(new Action(ClearSelection));
        }
        public void ClearSelection()
        {
            this.booksDataGrid.ClearSelection();
            this.booksDataGrid.CurrentCell = null;
        }
        private void complexSearchButton_Click(object sender, EventArgs e)
            => this.booksDataGrid.DataSource = bookRepository.ComplexFilter();
        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ctr in this.Controls.OfType<TextBox>())
                ctr.Text = string.Empty;
            this.complexSearchButton.PerformClick();
        }
        private void borrowButton_Click(object sender, EventArgs e)
        {
            var checkoutSuccess = this.libraryManager.CheckoutBook(this.booksDataGrid);
            if (checkoutSuccess) this.Dispose();
        }

        private void authorSearchBar_TextChanged(object sender, EventArgs e)
        {
            var filteredData = bookRepository.SearchBookByValue(this.dataTable, "Author", this.authorSearchBar.Text);
            this.booksDataGrid.DataSource = filteredData;
        }

        private void titleSearchBar_TextChanged(object sender, EventArgs e)
        {
            var filteredData = bookRepository.SearchBookByValue(this.dataTable, "Title", this.titleSearchBar.Text);
            this.booksDataGrid.DataSource = filteredData;
        }

        private void genreSearchBar_TextChanged(object sender, EventArgs e)
        {
            var filteredData = bookRepository.SearchBookByValue(this.dataTable, "Genre", this.genreSearchBar.Text);
            this.booksDataGrid.DataSource = filteredData;
        }

        private void isbnSearchBar_TextChanged(object sender, EventArgs e)
        {
            var filteredData = bookRepository.SearchBookByValue(this.dataTable, "ISBN", this.isbnSearchBar.Text);
            this.booksDataGrid.DataSource = filteredData;
        }

        private void idSearchBar_TextChanged(object sender, EventArgs e)
        {
            var filteredData = bookRepository.SearchBookByValue(this.dataTable, "BookId", this.idSearchBar.Text);
            this.booksDataGrid.DataSource = filteredData;
        }
    }
}
