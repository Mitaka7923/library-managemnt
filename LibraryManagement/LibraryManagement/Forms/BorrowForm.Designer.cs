namespace LibraryManagement.Forms
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            booksDataGrid = new DataGridView();
            complexSearchButton = new Button();
            clearButton = new Button();
            borrowButton = new Button();
            isbnSearchBar = new TextBox();
            label4 = new Label();
            genreSearchBar = new TextBox();
            label3 = new Label();
            idSearchBar = new TextBox();
            label2 = new Label();
            authorSearchBar = new TextBox();
            label1 = new Label();
            titleSearchBar = new TextBox();
            bookTitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).BeginInit();
            SuspendLayout();
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
            booksDataGrid.Location = new Point(774, 139);
            booksDataGrid.MultiSelect = false;
            booksDataGrid.Name = "booksDataGrid";
            booksDataGrid.ShowCellToolTips = false;
            booksDataGrid.ShowEditingIcon = false;
            booksDataGrid.Size = new Size(741, 524);
            booksDataGrid.TabIndex = 3;
            // 
            // complexSearchButton
            // 
            complexSearchButton.BackColor = Color.LightBlue;
            complexSearchButton.Font = new Font("Segoe UI", 16F);
            complexSearchButton.Location = new Point(501, 458);
            complexSearchButton.Name = "complexSearchButton";
            complexSearchButton.Size = new Size(186, 83);
            complexSearchButton.TabIndex = 14;
            complexSearchButton.Text = "🔎";
            complexSearchButton.UseVisualStyleBackColor = false;
            complexSearchButton.Click += complexSearchButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 16F);
            clearButton.Location = new Point(186, 458);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(191, 83);
            clearButton.TabIndex = 15;
            clearButton.Text = "Изчисти";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // borrowButton
            // 
            borrowButton.BackColor = Color.RosyBrown;
            borrowButton.Font = new Font("Segoe UI", 26F);
            borrowButton.ForeColor = Color.White;
            borrowButton.Location = new Point(994, 696);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(295, 114);
            borrowButton.TabIndex = 16;
            borrowButton.Text = "Наем";
            borrowButton.UseVisualStyleBackColor = false;
            borrowButton.Click += borrowButton_Click;
            // 
            // isbnSearchBar
            // 
            isbnSearchBar.BackColor = Color.Gainsboro;
            isbnSearchBar.Font = new Font("Segoe UI", 22F);
            isbnSearchBar.Location = new Point(186, 318);
            isbnSearchBar.Name = "isbnSearchBar";
            isbnSearchBar.Size = new Size(501, 47);
            isbnSearchBar.TabIndex = 25;
            isbnSearchBar.TextChanged += isbnSearchBar_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 314);
            label4.Name = "label4";
            label4.Size = new Size(139, 46);
            label4.TabIndex = 26;
            label4.Text = "Баркод:";
            // 
            // genreSearchBar
            // 
            genreSearchBar.BackColor = Color.Gainsboro;
            genreSearchBar.Font = new Font("Segoe UI", 22F);
            genreSearchBar.Location = new Point(186, 258);
            genreSearchBar.Name = "genreSearchBar";
            genreSearchBar.Size = new Size(501, 47);
            genreSearchBar.TabIndex = 23;
            genreSearchBar.TextChanged += genreSearchBar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(80, 253);
            label3.Name = "label3";
            label3.Size = new Size(113, 46);
            label3.TabIndex = 24;
            label3.Text = "Жанр:";
            // 
            // idSearchBar
            // 
            idSearchBar.BackColor = Color.Gainsboro;
            idSearchBar.Font = new Font("Segoe UI", 22F);
            idSearchBar.Location = new Point(186, 380);
            idSearchBar.Name = "idSearchBar";
            idSearchBar.Size = new Size(501, 47);
            idSearchBar.TabIndex = 21;
            idSearchBar.TextChanged += idSearchBar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(132, 379);
            label2.Name = "label2";
            label2.Size = new Size(60, 46);
            label2.TabIndex = 22;
            label2.Text = "ID:";
            // 
            // authorSearchBar
            // 
            authorSearchBar.BackColor = Color.Gainsboro;
            authorSearchBar.Font = new Font("Segoe UI", 22F);
            authorSearchBar.Location = new Point(186, 140);
            authorSearchBar.Name = "authorSearchBar";
            authorSearchBar.Size = new Size(501, 47);
            authorSearchBar.TabIndex = 19;
            authorSearchBar.TextChanged += authorSearchBar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 139);
            label1.Name = "label1";
            label1.Size = new Size(121, 46);
            label1.TabIndex = 20;
            label1.Text = "Автор:";
            // 
            // titleSearchBar
            // 
            titleSearchBar.BackColor = Color.Gainsboro;
            titleSearchBar.Font = new Font("Segoe UI", 22F);
            titleSearchBar.Location = new Point(186, 199);
            titleSearchBar.Name = "titleSearchBar";
            titleSearchBar.Size = new Size(501, 47);
            titleSearchBar.TabIndex = 17;
            titleSearchBar.TextChanged += titleSearchBar_TextChanged;
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.BackColor = Color.Transparent;
            bookTitleLabel.Font = new Font("Segoe UI", 25F);
            bookTitleLabel.ForeColor = Color.White;
            bookTitleLabel.Location = new Point(27, 194);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(166, 46);
            bookTitleLabel.TabIndex = 18;
            bookTitleLabel.Text = "Заглавие:";
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1527, 963);
            ControlBox = false;
            Controls.Add(isbnSearchBar);
            Controls.Add(label4);
            Controls.Add(genreSearchBar);
            Controls.Add(label3);
            Controls.Add(idSearchBar);
            Controls.Add(label2);
            Controls.Add(authorSearchBar);
            Controls.Add(label1);
            Controls.Add(titleSearchBar);
            Controls.Add(bookTitleLabel);
            Controls.Add(borrowButton);
            Controls.Add(clearButton);
            Controls.Add(complexSearchButton);
            Controls.Add(booksDataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowForm";
            Text = "BorrowForm";
            Load += BorrowForm_Load;
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal DataGridView booksDataGrid;
        internal Button complexSearchButton;
        internal Button clearButton;
        internal Button borrowButton;
        internal TextBox isbnSearchBar;
        internal Label label4;
        internal TextBox genreSearchBar;
        internal Label label3;
        internal TextBox idSearchBar;
        internal Label label2;
        internal TextBox authorSearchBar;
        internal Label label1;
        internal TextBox titleSearchBar;
        internal Label bookTitleLabel;
    }
}