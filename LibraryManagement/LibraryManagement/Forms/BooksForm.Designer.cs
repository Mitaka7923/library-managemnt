namespace LibraryManagement.Forms
{
    partial class BooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            titleSearchBar = new TextBox();
            booksDataGrid = new DataGridView();
            bookTitleLabel = new Label();
            authorSearchBar = new TextBox();
            label1 = new Label();
            idSearchBar = new TextBox();
            label2 = new Label();
            genreSearchBar = new TextBox();
            label3 = new Label();
            isbnSearchBar = new TextBox();
            label4 = new Label();
            complexSearchButton = new Button();
            clearButton = new Button();
            newBookButton = new Button();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).BeginInit();
            SuspendLayout();
            // 
            // titleSearchBar
            // 
            titleSearchBar.BackColor = Color.Gainsboro;
            titleSearchBar.Font = new Font("Segoe UI", 22F);
            titleSearchBar.Location = new Point(188, 174);
            titleSearchBar.Name = "titleSearchBar";
            titleSearchBar.Size = new Size(501, 47);
            titleSearchBar.TabIndex = 4;
            titleSearchBar.TextChanged += bookSearchBar_TextChanged;
            // 
            // booksDataGrid
            // 
            booksDataGrid.AllowUserToAddRows = false;
            booksDataGrid.AllowUserToDeleteRows = false;
            booksDataGrid.AllowUserToResizeColumns = false;
            booksDataGrid.AllowUserToResizeRows = false;
            booksDataGrid.BackgroundColor = Color.Gainsboro;
            booksDataGrid.CausesValidation = false;
            booksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            booksDataGrid.Location = new Point(765, 115);
            booksDataGrid.MultiSelect = false;
            booksDataGrid.Name = "booksDataGrid";
            booksDataGrid.ShowCellToolTips = false;
            booksDataGrid.ShowEditingIcon = false;
            booksDataGrid.Size = new Size(741, 655);
            booksDataGrid.TabIndex = 3;
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.BackColor = Color.Transparent;
            bookTitleLabel.Font = new Font("Segoe UI", 25F);
            bookTitleLabel.ForeColor = Color.White;
            bookTitleLabel.Location = new Point(29, 169);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(166, 46);
            bookTitleLabel.TabIndex = 5;
            bookTitleLabel.Text = "Заглавие:";
            // 
            // authorSearchBar
            // 
            authorSearchBar.BackColor = Color.Gainsboro;
            authorSearchBar.Font = new Font("Segoe UI", 22F);
            authorSearchBar.Location = new Point(188, 115);
            authorSearchBar.Name = "authorSearchBar";
            authorSearchBar.Size = new Size(501, 47);
            authorSearchBar.TabIndex = 6;
            authorSearchBar.TextChanged += authorSearchBar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 114);
            label1.Name = "label1";
            label1.Size = new Size(121, 46);
            label1.TabIndex = 7;
            label1.Text = "Автор:";
            // 
            // idSearchBar
            // 
            idSearchBar.BackColor = Color.Gainsboro;
            idSearchBar.Font = new Font("Segoe UI", 22F);
            idSearchBar.Location = new Point(188, 355);
            idSearchBar.Name = "idSearchBar";
            idSearchBar.Size = new Size(501, 47);
            idSearchBar.TabIndex = 8;
            idSearchBar.TextChanged += idSearchBar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(134, 354);
            label2.Name = "label2";
            label2.Size = new Size(60, 46);
            label2.TabIndex = 9;
            label2.Text = "ID:";
            // 
            // genreSearchBar
            // 
            genreSearchBar.BackColor = Color.Gainsboro;
            genreSearchBar.Font = new Font("Segoe UI", 22F);
            genreSearchBar.Location = new Point(188, 233);
            genreSearchBar.Name = "genreSearchBar";
            genreSearchBar.Size = new Size(501, 47);
            genreSearchBar.TabIndex = 10;
            genreSearchBar.TextChanged += genreSearchBar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 228);
            label3.Name = "label3";
            label3.Size = new Size(113, 46);
            label3.TabIndex = 11;
            label3.Text = "Жанр:";
            // 
            // isbnSearchBar
            // 
            isbnSearchBar.BackColor = Color.Gainsboro;
            isbnSearchBar.Font = new Font("Segoe UI", 22F);
            isbnSearchBar.Location = new Point(188, 293);
            isbnSearchBar.Name = "isbnSearchBar";
            isbnSearchBar.Size = new Size(501, 47);
            isbnSearchBar.TabIndex = 12;
            isbnSearchBar.TextChanged += isbnSearchBar_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(56, 289);
            label4.Name = "label4";
            label4.Size = new Size(139, 46);
            label4.TabIndex = 13;
            label4.Text = "Баркод:";
            // 
            // complexSearchButton
            // 
            complexSearchButton.BackColor = SystemColors.ActiveCaption;
            complexSearchButton.Font = new Font("Segoe UI", 22F);
            complexSearchButton.Location = new Point(487, 460);
            complexSearchButton.Name = "complexSearchButton";
            complexSearchButton.Size = new Size(202, 82);
            complexSearchButton.TabIndex = 14;
            complexSearchButton.Text = "🔎";
            complexSearchButton.UseVisualStyleBackColor = false;
            complexSearchButton.Click += complexSearchButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 22F);
            clearButton.Location = new Point(188, 460);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(202, 82);
            clearButton.TabIndex = 15;
            clearButton.Text = "Изчисти";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // newBookButton
            // 
            newBookButton.BackColor = Color.RosyBrown;
            newBookButton.Font = new Font("Segoe UI", 22F);
            newBookButton.Location = new Point(765, 795);
            newBookButton.Name = "newBookButton";
            newBookButton.Size = new Size(361, 91);
            newBookButton.TabIndex = 16;
            newBookButton.Text = "Добави книга";
            newBookButton.UseVisualStyleBackColor = false;
            newBookButton.Click += newBookButton_Click;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1527, 963);
            ControlBox = false;
            Controls.Add(newBookButton);
            Controls.Add(clearButton);
            Controls.Add(complexSearchButton);
            Controls.Add(isbnSearchBar);
            Controls.Add(label4);
            Controls.Add(genreSearchBar);
            Controls.Add(label3);
            Controls.Add(idSearchBar);
            Controls.Add(label2);
            Controls.Add(authorSearchBar);
            Controls.Add(label1);
            Controls.Add(titleSearchBar);
            Controls.Add(booksDataGrid);
            Controls.Add(bookTitleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BooksForm";
            Text = "BorrowForm";
            Load += BorrowForm_Load;
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox titleSearchBar;
        internal DataGridView booksDataGrid;
        internal Label bookTitleLabel;
        internal TextBox authorSearchBar;
        internal Label label1;
        internal TextBox idSearchBar;
        internal Label label2;
        internal TextBox genreSearchBar;
        internal Label label3;
        internal TextBox isbnSearchBar;
        internal Label label4;
        internal Button complexSearchButton;
        internal Button clearButton;
        private Button newBookButton;
    }
}