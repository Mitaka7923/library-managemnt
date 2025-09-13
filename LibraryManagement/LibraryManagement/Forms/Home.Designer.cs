namespace LibraryManagement
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            navigationPanel = new Panel();
            membersButton = new Button();
            booksIconLabel = new Label();
            dateTimeControl1 = new Controls.DateTimeControl();
            membersIconLabel = new Label();
            borrowButton = new Button();
            booksButton = new Button();
            returnButton = new Button();
            borrowIconLabel = new Label();
            returnIconLabel = new Label();
            contentArea = new Panel();
            label1 = new Label();
            reportButton = new Button();
            navigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navigationPanel
            // 
            navigationPanel.Controls.Add(label1);
            navigationPanel.Controls.Add(reportButton);
            navigationPanel.Controls.Add(membersButton);
            navigationPanel.Controls.Add(booksIconLabel);
            navigationPanel.Controls.Add(dateTimeControl1);
            navigationPanel.Controls.Add(membersIconLabel);
            navigationPanel.Controls.Add(borrowButton);
            navigationPanel.Controls.Add(booksButton);
            navigationPanel.Controls.Add(returnButton);
            navigationPanel.Controls.Add(borrowIconLabel);
            navigationPanel.Controls.Add(returnIconLabel);
            navigationPanel.Dock = DockStyle.Left;
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(365, 924);
            navigationPanel.TabIndex = 0;
            // 
            // membersButton
            // 
            membersButton.BackColor = Color.LavenderBlush;
            membersButton.FlatAppearance.BorderColor = Color.Black;
            membersButton.FlatAppearance.MouseOverBackColor = Color.Pink;
            membersButton.Font = new Font("Segoe UI", 22F);
            membersButton.Location = new Point(76, 423);
            membersButton.Name = "membersButton";
            membersButton.Size = new Size(262, 144);
            membersButton.TabIndex = 0;
            membersButton.Text = "Читатели";
            membersButton.UseVisualStyleBackColor = false;
            membersButton.Click += membersButton_Click;
            // 
            // booksIconLabel
            // 
            booksIconLabel.AutoSize = true;
            booksIconLabel.Font = new Font("Segoe UI", 32F);
            booksIconLabel.Location = new Point(-5, 610);
            booksIconLabel.Name = "booksIconLabel";
            booksIconLabel.Size = new Size(80, 59);
            booksIconLabel.TabIndex = 8;
            booksIconLabel.Text = "📚";
            // 
            // dateTimeControl1
            // 
            dateTimeControl1.Location = new Point(24, 0);
            dateTimeControl1.Margin = new Padding(3, 4, 3, 4);
            dateTimeControl1.Name = "dateTimeControl1";
            dateTimeControl1.Size = new Size(314, 62);
            dateTimeControl1.TabIndex = 10;
            // 
            // membersIconLabel
            // 
            membersIconLabel.AutoSize = true;
            membersIconLabel.Font = new Font("Segoe UI", 32F);
            membersIconLabel.Location = new Point(0, 461);
            membersIconLabel.Name = "membersIconLabel";
            membersIconLabel.Size = new Size(75, 59);
            membersIconLabel.TabIndex = 7;
            membersIconLabel.Text = "\U0001f935";
            // 
            // borrowButton
            // 
            borrowButton.BackColor = Color.LavenderBlush;
            borrowButton.Enabled = false;
            borrowButton.FlatAppearance.BorderColor = Color.Black;
            borrowButton.FlatAppearance.MouseOverBackColor = Color.Pink;
            borrowButton.Font = new Font("Segoe UI", 22F);
            borrowButton.Location = new Point(76, 70);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(262, 144);
            borrowButton.TabIndex = 4;
            borrowButton.Text = "Наеми";
            borrowButton.UseVisualStyleBackColor = false;
            borrowButton.Click += borrowButton_Click;
            // 
            // booksButton
            // 
            booksButton.BackColor = Color.LavenderBlush;
            booksButton.FlatAppearance.BorderColor = Color.Black;
            booksButton.FlatAppearance.MouseOverBackColor = Color.Pink;
            booksButton.Font = new Font("Segoe UI", 22F);
            booksButton.Location = new Point(76, 573);
            booksButton.Name = "booksButton";
            booksButton.Size = new Size(262, 144);
            booksButton.TabIndex = 1;
            booksButton.Text = "Книги";
            booksButton.UseVisualStyleBackColor = false;
            booksButton.Click += booksButton_Click;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.LavenderBlush;
            returnButton.Enabled = false;
            returnButton.FlatAppearance.BorderColor = Color.Black;
            returnButton.FlatAppearance.MouseOverBackColor = Color.Pink;
            returnButton.Font = new Font("Segoe UI", 22F);
            returnButton.Location = new Point(76, 220);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(262, 144);
            returnButton.TabIndex = 3;
            returnButton.Text = "Върни";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // borrowIconLabel
            // 
            borrowIconLabel.AutoSize = true;
            borrowIconLabel.Font = new Font("Segoe UI", 32F);
            borrowIconLabel.Location = new Point(0, 107);
            borrowIconLabel.Name = "borrowIconLabel";
            borrowIconLabel.Size = new Size(75, 59);
            borrowIconLabel.TabIndex = 5;
            borrowIconLabel.Text = "📔";
            // 
            // returnIconLabel
            // 
            returnIconLabel.AutoSize = true;
            returnIconLabel.Font = new Font("Segoe UI", 32F);
            returnIconLabel.Location = new Point(0, 257);
            returnIconLabel.Name = "returnIconLabel";
            returnIconLabel.Size = new Size(80, 59);
            returnIconLabel.TabIndex = 6;
            returnIconLabel.Text = "📃";
            // 
            // contentArea
            // 
            contentArea.BackColor = Color.Transparent;
            contentArea.Dock = DockStyle.Fill;
            contentArea.Location = new Point(365, 0);
            contentArea.Name = "contentArea";
            contentArea.Size = new Size(1146, 924);
            contentArea.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(-14, 789);
            label1.Name = "label1";
            label1.Size = new Size(84, 59);
            label1.TabIndex = 12;
            label1.Text = "🗃";
            // 
            // reportButton
            // 
            reportButton.BackColor = Color.LavenderBlush;
            reportButton.FlatAppearance.BorderColor = Color.Black;
            reportButton.FlatAppearance.MouseOverBackColor = Color.Pink;
            reportButton.Font = new Font("Segoe UI", 22F);
            reportButton.Location = new Point(76, 752);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(262, 144);
            reportButton.TabIndex = 11;
            reportButton.Text = "Отчет";
            reportButton.UseVisualStyleBackColor = false;
            reportButton.Click += reportButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1511, 924);
            Controls.Add(contentArea);
            Controls.Add(navigationPanel);
            Name = "Home";
            Text = "Home";
            navigationPanel.ResumeLayout(false);
            navigationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal Panel navigationPanel;
        internal Button membersButton;
        internal Button booksButton;
        public Panel contentArea;
        public Button borrowButton;
        public Button returnButton;
        internal Label borrowIconLabel;
        internal Label returnIconLabel;
        internal Label membersIconLabel;
        internal Label booksIconLabel;
        internal Controls.DateTimeControl dateTimeControl1;
        internal Controls.DateTimeControl dateTimeControl2;
        internal Label label1;
        internal Button reportButton;
    }
}
