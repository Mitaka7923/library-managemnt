using LibraryManagement.Forms;
using LibraryManagement.Models;
using LibraryManagement.Models.Repositories;

namespace LibraryManagement
{
    public partial class Home : Form
    {
        private MembersForm membersForm;
        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void LoadFormIntoPanel(Form form)
        {
            this.contentArea.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            this.contentArea.Controls.Add(form);
            form.Show();
        }

        private Member? GetMemberInfo()
        {
            DataGridView? dataGridView = null;
            try
            {
                var memberForm = this.contentArea.Controls.OfType<MembersForm>().FirstOrDefault();
                if (memberForm == null)
                    throw new Exception();
                dataGridView = memberForm.Controls.OfType<DataGridView>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Моля изберете читател, за да използвате функцията!");
                return null;
            }

            if (this.membersForm.memberDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                var member = new Member(
                    Convert.ToInt32(selectedRow.Cells[0].Value),
                    (string)selectedRow.Cells[1].Value,
                    (string)selectedRow.Cells[2].Value,
                    Convert.ToDateTime(selectedRow.Cells[3].Value));
                return member;
            }
            return null;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            var member = GetMemberInfo();
            if (member is null) 
            {
                return;   
            }
            if (member is not null)
                LoadFormIntoPanel(new BorrowForm(member));
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            var member = GetMemberInfo();
            if (member is null)
            {
                return;
            }
            if (member is not null)
                LoadFormIntoPanel(new ReturnForm(member, new BookRepository()));
        }

        private void membersButton_Click(object sender, EventArgs e)
        {
            this.membersForm = new MembersForm();
            LoadFormIntoPanel(this.membersForm);
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            var bookForm = new BooksForm();
            LoadFormIntoPanel(bookForm);
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            Program.homeForm.contentArea.Controls.Clear();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm();
            LoadFormIntoPanel(reportForm);
        }
    }
}
