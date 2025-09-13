namespace LibraryManagement.Forms
{
    partial class RegisterMemberControl
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
            nameLabel = new Label();
            contactLabel = new Label();
            nameTextBox = new TextBox();
            contactTextBox = new TextBox();
            registerButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 22F);
            nameLabel.Location = new Point(71, 34);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(84, 41);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Име:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Font = new Font("Segoe UI", 22F);
            contactLabel.Location = new Point(20, 94);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(145, 41);
            contactLabel.TabIndex = 1;
            contactLabel.Text = "Телефон:";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.InactiveCaption;
            nameTextBox.Font = new Font("Segoe UI", 22F);
            nameTextBox.Location = new Point(161, 31);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(343, 47);
            nameTextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            contactTextBox.BackColor = SystemColors.InactiveCaption;
            contactTextBox.Font = new Font("Segoe UI", 22F);
            contactTextBox.Location = new Point(161, 88);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(343, 47);
            contactTextBox.TabIndex = 3;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Segoe UI", 15F);
            registerButton.Location = new Point(300, 176);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(204, 62);
            registerButton.TabIndex = 4;
            registerButton.Text = "Регистрация";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // RegisterMemberControl
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(registerButton);
            Controls.Add(contactTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(contactLabel);
            Controls.Add(nameLabel);
            Name = "RegisterMemberControl";
            Size = new Size(546, 271);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label contactLabel;
        private TextBox nameTextBox;
        private TextBox contactTextBox;
        private Button registerButton;
    }
}