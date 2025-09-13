namespace LibraryManagement.Controls
{
    partial class DateTimeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            timeOfDayLabel = new Label();
            dateLabel = new Label();
            SuspendLayout();
            // 
            // timeOfDayLabel
            // 
            timeOfDayLabel.AutoSize = true;
            timeOfDayLabel.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            timeOfDayLabel.Location = new Point(174, 10);
            timeOfDayLabel.Name = "timeOfDayLabel";
            timeOfDayLabel.Size = new Size(0, 42);
            timeOfDayLabel.TabIndex = 0;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            dateLabel.Location = new Point(3, 10);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(0, 42);
            dateLabel.TabIndex = 1;
            // 
            // DateTimeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateLabel);
            Controls.Add(timeOfDayLabel);
            Name = "DateTimeControl";
            Size = new Size(326, 71);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeOfDayLabel;
        private Label dateLabel;
    }
}
