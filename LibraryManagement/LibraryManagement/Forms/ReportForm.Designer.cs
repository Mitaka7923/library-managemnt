namespace LibraryManagement.Forms
{
    partial class ReportForm
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
            dailyCheckoutsDataGrid = new DataGridView();
            dailyReportButton = new Button();
            monthlyReportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dailyCheckoutsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // dailyCheckoutsDataGrid
            // 
            dailyCheckoutsDataGrid.AllowUserToAddRows = false;
            dailyCheckoutsDataGrid.AllowUserToDeleteRows = false;
            dailyCheckoutsDataGrid.AllowUserToResizeColumns = false;
            dailyCheckoutsDataGrid.AllowUserToResizeRows = false;
            dailyCheckoutsDataGrid.BackgroundColor = Color.Gainsboro;
            dailyCheckoutsDataGrid.CausesValidation = false;
            dailyCheckoutsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dailyCheckoutsDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dailyCheckoutsDataGrid.Location = new Point(53, 281);
            dailyCheckoutsDataGrid.MultiSelect = false;
            dailyCheckoutsDataGrid.Name = "dailyCheckoutsDataGrid";
            dailyCheckoutsDataGrid.ShowCellToolTips = false;
            dailyCheckoutsDataGrid.ShowEditingIcon = false;
            dailyCheckoutsDataGrid.Size = new Size(1007, 595);
            dailyCheckoutsDataGrid.TabIndex = 1;
            // 
            // dailyReportButton
            // 
            dailyReportButton.BackColor = SystemColors.ActiveCaption;
            dailyReportButton.Font = new Font("Segoe UI", 18F);
            dailyReportButton.Location = new Point(53, 138);
            dailyReportButton.Name = "dailyReportButton";
            dailyReportButton.Size = new Size(333, 114);
            dailyReportButton.TabIndex = 5;
            dailyReportButton.Text = "Дневен";
            dailyReportButton.UseVisualStyleBackColor = false;
            dailyReportButton.Click += dailyReportButton_Click;
            // 
            // monthlyReportButton
            // 
            monthlyReportButton.BackColor = SystemColors.ActiveCaption;
            monthlyReportButton.Font = new Font("Segoe UI", 18F);
            monthlyReportButton.Location = new Point(727, 138);
            monthlyReportButton.Name = "monthlyReportButton";
            monthlyReportButton.Size = new Size(333, 114);
            monthlyReportButton.TabIndex = 6;
            monthlyReportButton.Text = "Месечен";
            monthlyReportButton.UseVisualStyleBackColor = false;
            monthlyReportButton.Click += monthlyReportButton_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1527, 963);
            Controls.Add(monthlyReportButton);
            Controls.Add(dailyReportButton);
            Controls.Add(dailyCheckoutsDataGrid);
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dailyCheckoutsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dailyCheckoutsDataGrid;
        private Button dailyReportButton;
        private Button monthlyReportButton;
    }
}