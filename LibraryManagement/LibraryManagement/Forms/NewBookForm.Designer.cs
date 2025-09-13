namespace LibraryManagement.Forms
{
    partial class NewBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBookForm));
            titleTextBox = new TextBox();
            titleLabel = new Label();
            authorLabel = new Label();
            genreLabel = new Label();
            isbnLabel = new Label();
            label1 = new Label();
            authorTextBox = new TextBox();
            isbnTextBox = new TextBox();
            totalCopiesTextBox = new TextBox();
            genreComboBox = new ComboBox();
            createBookButton = new Button();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = Color.Bisque;
            titleTextBox.Font = new Font("Segoe UI", 32F);
            titleTextBox.ForeColor = Color.Black;
            titleTextBox.Location = new Point(346, 231);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(478, 64);
            titleTextBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(115, 234);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(225, 59);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Заглавие:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.BackColor = Color.Transparent;
            authorLabel.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            authorLabel.ForeColor = Color.White;
            authorLabel.Location = new Point(176, 301);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(164, 59);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Автор:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.BackColor = Color.Transparent;
            genreLabel.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            genreLabel.ForeColor = Color.White;
            genreLabel.Location = new Point(183, 443);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(156, 59);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "Жанр:";
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.BackColor = Color.Transparent;
            isbnLabel.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            isbnLabel.ForeColor = Color.WhiteSmoke;
            isbnLabel.Location = new Point(149, 376);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new Size(191, 59);
            isbnLabel.TabIndex = 4;
            isbnLabel.Text = "Баркод:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(195, 164);
            label1.Name = "label1";
            label1.Size = new Size(145, 59);
            label1.TabIndex = 5;
            label1.Text = "Брой:";
            // 
            // authorTextBox
            // 
            authorTextBox.BackColor = Color.Bisque;
            authorTextBox.Font = new Font("Segoe UI", 32F);
            authorTextBox.ForeColor = Color.Black;
            authorTextBox.Location = new Point(346, 301);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(478, 64);
            authorTextBox.TabIndex = 6;
            // 
            // isbnTextBox
            // 
            isbnTextBox.BackColor = Color.Bisque;
            isbnTextBox.Font = new Font("Segoe UI", 32F);
            isbnTextBox.ForeColor = Color.Black;
            isbnTextBox.Location = new Point(346, 371);
            isbnTextBox.Name = "isbnTextBox";
            isbnTextBox.Size = new Size(478, 64);
            isbnTextBox.TabIndex = 7;
            // 
            // totalCopiesTextBox
            // 
            totalCopiesTextBox.BackColor = Color.Bisque;
            totalCopiesTextBox.Font = new Font("Segoe UI", 32F);
            totalCopiesTextBox.ForeColor = Color.Black;
            totalCopiesTextBox.Location = new Point(346, 161);
            totalCopiesTextBox.Name = "totalCopiesTextBox";
            totalCopiesTextBox.Size = new Size(130, 64);
            totalCopiesTextBox.TabIndex = 8;
            // 
            // genreComboBox
            // 
            genreComboBox.BackColor = Color.Bisque;
            genreComboBox.Font = new Font("Segoe UI", 23F);
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Items.AddRange(new object[] { "Fiction", "Mystery/Thriller", "Fantasy", "Science Fiction", "Romance", "Historical Fiction", "Horror", "Young Adult", "Non-Fiction", "Biography/Memoir" });
            genreComboBox.Location = new Point(346, 449);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(478, 50);
            genreComboBox.TabIndex = 9;
            // 
            // createBookButton
            // 
            createBookButton.BackColor = Color.MistyRose;
            createBookButton.Font = new Font("Segoe UI", 18F);
            createBookButton.Location = new Point(346, 561);
            createBookButton.Name = "createBookButton";
            createBookButton.Size = new Size(478, 94);
            createBookButton.TabIndex = 10;
            createBookButton.Text = "📌Запис";
            createBookButton.UseVisualStyleBackColor = false;
            createBookButton.Click += createBookButton_Click;
            // 
            // NewBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1874, 1032);
            Controls.Add(createBookButton);
            Controls.Add(genreComboBox);
            Controls.Add(totalCopiesTextBox);
            Controls.Add(isbnTextBox);
            Controls.Add(authorTextBox);
            Controls.Add(label1);
            Controls.Add(isbnLabel);
            Controls.Add(genreLabel);
            Controls.Add(authorLabel);
            Controls.Add(titleLabel);
            Controls.Add(titleTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewBookForm";
            Text = "NewBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private Label titleLabel;
        private Label authorLabel;
        private Label genreLabel;
        private Label isbnLabel;
        private Label label1;
        private TextBox authorTextBox;
        private TextBox isbnTextBox;
        private TextBox totalCopiesTextBox;
        private ComboBox genreComboBox;
        private Button createBookButton;
    }
}