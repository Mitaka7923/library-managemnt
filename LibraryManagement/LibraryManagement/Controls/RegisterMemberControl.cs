using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class RegisterMemberControl : UserControl
    {
        private MembersForm membersForm;
        public RegisterMemberControl(MembersForm membersForm)
        {
            this.membersForm = membersForm;
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (this.contactTextBox.Text.Trim().Length != 0 && this.nameTextBox.Text.Length != 0)
            {
                var isUserSure = MessageBox.Show(@$"Регистрация на: 
Име: {this.nameTextBox.Text}
Телефон: {this.contactTextBox.Text}", "ПРОВЕРКА", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isUserSure == DialogResult.Yes)
                {
                var successfullRegistration = Program.memberRepository.RegisterMember(this.nameTextBox.Text, this.contactTextBox.Text);
                if (successfullRegistration)
                {
                    this.membersForm.RefreshDataGrid();
                    MessageBox.Show($"{this.nameTextBox.Text.TrimEnd()} е регистриран читател!");
                    this.Parent.Hide();
                    this.Dispose();
                }
                }
            }
            else
                MessageBox.Show("Провери информацията отново!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
