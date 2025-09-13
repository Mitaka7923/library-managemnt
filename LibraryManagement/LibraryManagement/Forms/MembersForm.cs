using LibraryManagement.Models;
using System.Data;

namespace LibraryManagement.Forms
{
    public partial class MembersForm : Form
    {
        private DataTable dataTable;

        public MembersForm()
        {
            InitializeComponent();
            this.InitializeDataGridView();

            this.memberDataGrid.SelectionChanged += MemberDataGrid_SelectionChanged;
        }
        private void MemberDataGrid_SelectionChanged(object? sender, EventArgs e)
        {
            if (this.memberDataGrid.SelectedRows.Count > 0)
            {
                Program.homeForm.borrowButton.Enabled = true;
                Program.homeForm.returnButton.Enabled = true;
            }
            else
            {
                Program.homeForm.borrowButton.Enabled = false;
                Program.homeForm.returnButton.Enabled = false;
            }
        }
        private void InitializeDataGridView()
        {
            this.memberDataGrid.AllowUserToAddRows = false;
            this.memberDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.memberDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadData()
        {
            MemberRepository memberRepo = new MemberRepository();

            this.dataTable = memberRepo.GetAllMembers();
            memberDataGrid.DataSource = this.dataTable;
            memberDataGrid.BeginInvoke(new Action(ClearSelection));
        }
        private void MembersForm_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearSelection();
            this.ControlBox = false;
        }
        private void ClearSelection()
        {
            memberDataGrid.ClearSelection();
            memberDataGrid.CurrentCell = null;
        }
        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterExpression = $"Name LIKE '{nameSearchBar.Text}%'";
                DataView dataView = new DataView(this.dataTable) { RowFilter = filterExpression };
                memberDataGrid.DataSource = dataView;
            }
            catch (Exception ex) { }

            ClearSelection();
        }
        private void registerMember_Click(object sender, EventArgs e)
        {
            this.registerMemberPanel.Show();
            this.registerMemberPanel.Controls.Add(new RegisterMemberControl(this));
            this.registerMember.Enabled = true;
        }
        internal void RefreshDataGrid() => LoadData();

        private void phoneSearchBar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterExpression = $"ContactInfo LIKE '{phoneSearchBar.Text}%'";
                DataView dataView = new DataView(this.dataTable) { RowFilter = filterExpression };
                memberDataGrid.DataSource = dataView;
            }
            catch (Exception ex) { }

            ClearSelection();

        }
    }
}