namespace LibraryManagement.Forms
{
    partial class MembersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersForm));
            memberDataGrid = new DataGridView();
            nameSearchBar = new TextBox();
            nameLabel = new Label();
            registerMemberPanel = new Panel();
            registerMember = new Button();
            phoneSearchBar = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)memberDataGrid).BeginInit();
            SuspendLayout();
            // 
            // memberDataGrid
            // 
            memberDataGrid.AllowUserToAddRows = false;
            memberDataGrid.AllowUserToDeleteRows = false;
            memberDataGrid.AllowUserToResizeColumns = false;
            memberDataGrid.AllowUserToResizeRows = false;
            memberDataGrid.BackgroundColor = Color.Gainsboro;
            memberDataGrid.CausesValidation = false;
            memberDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            memberDataGrid.Location = new Point(24, 180);
            memberDataGrid.MultiSelect = false;
            memberDataGrid.Name = "memberDataGrid";
            memberDataGrid.ShowCellToolTips = false;
            memberDataGrid.ShowEditingIcon = false;
            memberDataGrid.Size = new Size(588, 485);
            memberDataGrid.TabIndex = 0;
            // 
            // nameSearchBar
            // 
            nameSearchBar.BackColor = Color.Gainsboro;
            nameSearchBar.Font = new Font("Segoe UI", 22F);
            nameSearchBar.Location = new Point(112, 57);
            nameSearchBar.Name = "nameSearchBar";
            nameSearchBar.Size = new Size(500, 47);
            nameSearchBar.TabIndex = 1;
            nameSearchBar.TextChanged += searchBar_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 25F);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(23, 58);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(94, 46);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Име:";
            // 
            // registerMemberPanel
            // 
            registerMemberPanel.BackColor = Color.Gainsboro;
            registerMemberPanel.Location = new Point(634, 180);
            registerMemberPanel.Name = "registerMemberPanel";
            registerMemberPanel.Size = new Size(571, 258);
            registerMemberPanel.TabIndex = 3;
            registerMemberPanel.Visible = false;
            // 
            // registerMember
            // 
            registerMember.BackColor = SystemColors.ActiveCaption;
            registerMember.Font = new Font("Segoe UI", 18F);
            registerMember.Location = new Point(279, 686);
            registerMember.Name = "registerMember";
            registerMember.Size = new Size(333, 114);
            registerMember.TabIndex = 4;
            registerMember.Text = "📃 Регистрация";
            registerMember.UseVisualStyleBackColor = false;
            registerMember.Click += registerMember_Click;
            // 
            // phoneSearchBar
            // 
            phoneSearchBar.BackColor = Color.Gainsboro;
            phoneSearchBar.Font = new Font("Segoe UI", 22F);
            phoneSearchBar.Location = new Point(178, 110);
            phoneSearchBar.Name = "phoneSearchBar";
            phoneSearchBar.Size = new Size(434, 47);
            phoneSearchBar.TabIndex = 5;
            phoneSearchBar.TextChanged += phoneSearchBar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 111);
            label1.Name = "label1";
            label1.Size = new Size(162, 46);
            label1.TabIndex = 6;
            label1.Text = "Телефон:";
            // 
            // MembersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1543, 1002);
            Controls.Add(phoneSearchBar);
            Controls.Add(label1);
            Controls.Add(registerMember);
            Controls.Add(registerMemberPanel);
            Controls.Add(nameSearchBar);
            Controls.Add(memberDataGrid);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MembersForm";
            Text = "MembersForm";
            Load += MembersForm_Load;
            ((System.ComponentModel.ISupportInitialize)memberDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView memberDataGrid;
        private TextBox nameSearchBar;
        private Label nameLabel;
        private Panel registerMemberPanel;
        private Button registerMember;
        private TextBox phoneSearchBar;
        private Label label1;
    }
}