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
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
            // nameTextBox.BackColor = Color.Red;
            //FamilyNameTextBox.BackColor = Color.Red;
            //EmailTextBox.BackColor = Color.Red;
            //PhoneTextBox.BackColor = Color.Red;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.BackColor = Color.LimeGreen;
            if (nameTextBox.Text.Trim().Count() == 0)
                nameTextBox.BackColor = Color.Red;
        }

        private void FamilyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FamilyNameTextBox.BackColor = Color.LimeGreen;
            if (FamilyNameTextBox.Text.Trim().Count() == 0)
                FamilyNameTextBox.BackColor = Color.Red;
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            PhoneTextBox.BackColor = Color.LimeGreen;
            if (PhoneTextBox.Text.Trim().Count() == 0)
                PhoneTextBox.BackColor = Color.Red;
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailTextBox.Text.Trim().Count() == 0)
                EmailTextBox.BackColor = Color.Red;

            if (EmailTextBox.Text.Contains("@gmail.com"))
            {
                EmailTextBox.BackColor = Color.LimeGreen;
            }
            else
            {
                EmailTextBox.BackColor = Color.Red;
            }

        }

    }
}
