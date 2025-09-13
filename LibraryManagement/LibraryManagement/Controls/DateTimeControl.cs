namespace LibraryManagement.Controls
{
    public partial class DateTimeControl : UserControl
    {
        private System.Windows.Forms.Timer _timer;
        public DateTimeControl()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            this._timer = new System.Windows.Forms.Timer();
            this._timer.Interval = 1000;
            this._timer.Tick += UpdateTimer;
            this._timer.Start();
        }
        private void UpdateTimer(object sender, EventArgs e)
        {
            this.timeOfDayLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            this.dateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}
