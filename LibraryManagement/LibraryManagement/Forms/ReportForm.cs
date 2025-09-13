using LibraryManagement.Models.Repositories;
using System.Data;

namespace LibraryManagement.Forms
{
    public partial class ReportForm : Form
    {
        private DataTable dataTable;
        public ReportForm()
        {
            InitializeComponent();
            this.InitializeDataGridView();
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            ClearSelection();
            this.ControlBox = false;
        }
        private void InitializeDataGridView()
        {
            this.dailyCheckoutsDataGrid.AllowUserToAddRows = false;
            this.dailyCheckoutsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dailyCheckoutsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearSelection()
        {
            this.dailyCheckoutsDataGrid.ClearSelection();
            this.dailyCheckoutsDataGrid.CurrentCell = null;
        }
        private void LoadData(string span)
        {
            CheckoutRepository checkoutRepo = new CheckoutRepository();

            this.dataTable = checkoutRepo.GetCheckouts(span);

            this.dailyCheckoutsDataGrid.DataSource = this.dataTable;
            this.dailyCheckoutsDataGrid.BeginInvoke(new Action(ClearSelection));
        }

        private void dailyReportButton_Click(object sender, EventArgs e)
        {
            LoadData("daily");
        }

        private void monthlyReportButton_Click(object sender, EventArgs e)
        {
            LoadData("monthly");
        }
    }
}
