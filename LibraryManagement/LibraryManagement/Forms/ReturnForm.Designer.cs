namespace LibraryManagement.Forms
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            bookDataGridView = new DataGridView();
            returnButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).BeginInit();
            SuspendLayout();
            // 
            // bookDataGridView
            // 
            bookDataGridView.AllowUserToAddRows = false;
            bookDataGridView.AllowUserToDeleteRows = false;
            bookDataGridView.BackgroundColor = Color.Gainsboro;
            bookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGridView.Location = new Point(65, 92);
            bookDataGridView.Name = "bookDataGridView";
            bookDataGridView.ReadOnly = true;
            bookDataGridView.Size = new Size(616, 768);
            bookDataGridView.TabIndex = 0;
            // 
            // returnButton
            // 
            returnButton.BackColor = SystemColors.InactiveCaption;
            returnButton.Font = new Font("Segoe UI", 18F);
            returnButton.Location = new Point(712, 742);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(282, 118);
            returnButton.TabIndex = 1;
            returnButton.Text = "Връщане";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1551, 963);
            ControlBox = false;
            Controls.Add(returnButton);
            Controls.Add(bookDataGridView);
            Name = "ReturnForm";
            Text = "ReturnForm";
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView bookDataGridView;
        private Button returnButton;
    }
}