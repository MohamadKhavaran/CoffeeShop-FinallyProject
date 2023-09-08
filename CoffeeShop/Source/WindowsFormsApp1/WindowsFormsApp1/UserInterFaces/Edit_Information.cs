using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.LogicLayers;
namespace WindowsFormsApp1.UserInterFaces
{
    public partial class Edit_Information : Form
    {
        public Edit_Information()
        {
            InitializeComponent();
        }
        internal int a = 0;
        internal int b = 0;
        internal int c = 0;
        internal int d = 0;
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.BackColor = Color.LimeGreen;
            a = 1;
            if (nameTextBox.Text.Trim().Count() == 0)
            {
                nameTextBox.BackColor = Color.Red;
                a = 0;
            }
        }

        private void FamilyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FamilyNameTextBox.BackColor = Color.LimeGreen;
            b = 1;
            if (FamilyNameTextBox.Text.Trim().Count() == 0)
            {
                FamilyNameTextBox.BackColor = Color.Red;
                b = 0;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            PhoneTextBox.BackColor = Color.LimeGreen;
            c = 1;
            if (PhoneTextBox.Text.Trim().Count() == 0)
            {
                PhoneTextBox.BackColor = Color.Red;
                c = 0;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailTextBox.Text.Trim().Count() == 0)
            {
                EmailTextBox.BackColor = Color.Red;
                d = 0;
            }

            if (EmailTextBox.Text.Contains("@gmail.com") && EmailTextBox.Text.Count() > 10)
            {
                EmailTextBox.BackColor = Color.LimeGreen;
                d = 1;
            }
            else
            {
                EmailTextBox.BackColor = Color.Red;
                d = 0;
            }

        }

        private void buttonConfrim_MouseEnter(object sender, EventArgs e)
        {
            if (a == 0 || b == 0 || c == 0 || d == 0)
            {
                Save.Cursor = Cursors.No;
            }
            else if (a == 1 && b == 1 && c == 1 && d == 1)
            {
                Save.Cursor = Cursors.Hand;
            }

        }
        private void buttonConfrim_Click(object sender, EventArgs e)
        {
            if (a == 0 || b == 0 || c == 0 || d == 0)
            {
                MessageBox.Show("Enter The Information Correctly", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (a == 1 && b == 1 && c == 1 && d == 1)
            {
                LLUsers lLUsers = new LLUsers();
                lLUsers.Update(this.nameTextBox.Text.Trim(), this.FamilyNameTextBox.Text.Trim(), this.EmailTextBox.Text.Trim(), this.PhoneTextBox.Text.Trim());
                MessageBox.Show("Information Saved Successfully", "System Message",MessageBoxButtons.OK , MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

    }
}
