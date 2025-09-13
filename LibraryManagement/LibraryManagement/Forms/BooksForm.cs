using LibraryManagement.Models;
using LibraryManagement.Models.Repositories;
using System.Data;

namespace LibraryManagement.Forms
{
    internal partial class BooksForm : Form
    {
        internal DataTable dataTable;

        private string connectionString = "Server=localhost;Database=librarymanagementdb;Uid=root;Pwd=;";
        private BookRepository bookRepository;
        private BorrowForm borrowForm = new BorrowForm(new Member(1, "", "", DateTime.Now));

        public BooksForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.bookRepository = new BookRepository(borrowForm);
            if (Program.homeForm.borrowButton.Enabled)
            {
                Program.homeForm.borrowButton.Enabled = false;
                Program.homeForm.returnButton.Enabled = false;
            }
        }
        public BooksForm(BorrowForm borrowForm) : base()
            => this.borrowForm = borrowForm;

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
        private void BorrowForm_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearSelection();
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
        private void bookSearchBar_TextChanged(object sender, EventArgs e)
        {
            var filteredData = bookRepository.SearchBookByValue(this.dataTable, "Title", this.titleSearchBar.Text);
            this.booksDataGrid.DataSource = filteredData;
        }
        private void isbnSearchBar_TextChanged(object sender, EventArgs e)
        {
            var filteredData = bookRepository.SearchBookByValue(this.dataTable, "ISBN", this.isbnSearchBar.Text);
            this.booksDataGrid.DataSource = filteredData;
        }
        private void genreSearchBar_TextChanged(object sender, EventArgs e)
        {
            var filteredData = bookRepository.SearchBookByValue(this.dataTable, "Genre", this.genreSearchBar.Text);
            this.booksDataGrid.DataSource = filteredData;
        }
        private void authorSearchBar_TextChanged(object sender, EventArgs e)
        {
            var filteredData = bookRepository.SearchBookByValue(this.dataTable, "Author", this.authorSearchBar.Text);
            this.booksDataGrid.DataSource = filteredData;
        }

        private void complexSearchButton_Click(object sender, EventArgs e)
            => this.booksDataGrid.DataSource = bookRepository.ComplexFilter();
        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ctr in this.Controls.OfType<TextBox>())
                ctr.Text = string.Empty;
            this.complexSearchButton.PerformClick();
        }

        private void newBookButton_Click(object sender, EventArgs e)
        {
            var newBookForm = new NewBookForm();
            this.Dispose();
            Program.homeForm.contentArea.Controls.Add(newBookForm);
            newBookForm.Show();
        }

        private void idSearchBar_TextChanged(object sender, EventArgs e)
        {
            var filteredData = bookRepository.SearchBookByValue(this.dataTable, "BookId", this.idSearchBar.Text);
            this.booksDataGrid.DataSource = filteredData;
        }
    }
}