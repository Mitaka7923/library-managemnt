namespace LibraryManagement.Forms
{
    public partial class NewBookForm : Form
    {
        public NewBookForm()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private bool ValidateInputInTextBoxes(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (textBox.Text.TrimEnd().Length == 0)
                    return false;
            }
            return true;
        }

        private void createBookButton_Click(object sender, EventArgs e)
        {
            var canParseCopies = int.TryParse(this.totalCopiesTextBox.Text, out int totalCopiesCount);
            if (!ValidateInputInTextBoxes(this.titleTextBox, this.authorTextBox, this.isbnTextBox, this.totalCopiesTextBox) && this.genreComboBox.SelectedItem != null &&
                !canParseCopies)
                MessageBox.Show("Невалидни входни данни. Проверете отново!", "ГРЕШКА", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
            {
                var title = this.titleTextBox.Text;
                var author = this.authorTextBox.Text;
                var isbn = this.isbnTextBox.Text;
                var genre = this.genreComboBox.Text;
                var isUserSure = MessageBox.Show($@"Искате ли да регистрирате книгата:
Заглавие: {title}
Автор: {author}
Баркод: {isbn}
Жанр: {genre}
Брой: {totalCopiesCount}", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (isUserSure == DialogResult.Yes)
                {
                    var operationAddingBook = Program.bookRepository.AddBook(title, author, genre, isbn, totalCopiesCount);
                    if (operationAddingBook)
                    {
                        MessageBox.Show("Книгата е регистрирана!");
                    }
                }
            }
        }
    }
}
