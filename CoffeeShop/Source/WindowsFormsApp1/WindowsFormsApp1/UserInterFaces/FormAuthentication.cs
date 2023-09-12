using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserInterFaces
{
    public partial class FormAuthentication : Form
    {
        public FormAuthentication()
        {
            InitializeComponent();
        }

        private void FormAuthentication_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
        }

        private void buttonConfrim_MouseEnter(object sender, EventArgs e)
        {
            buttonConfrim.BackColor = Color.LimeGreen;
        }

        private void buttonConfrim_MouseLeave(object sender, EventArgs e)
        {
            buttonConfrim.BackColor = Color.White;
        }

        private void buttonConfrim_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text.Trim().Count() == 0 || PassWordTextBox.Text.Trim().Count() == 0)
            {
                MessageBox.Show("Do Not Leave Any Field Blank", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (UserNameTextBox.Text.Equals("Mohamad") && PassWordTextBox.Text.Equals("2311"))
            {
                MessageBox.Show("Login Was Successful", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.ShowDialog();
            }
        }
    }
}
