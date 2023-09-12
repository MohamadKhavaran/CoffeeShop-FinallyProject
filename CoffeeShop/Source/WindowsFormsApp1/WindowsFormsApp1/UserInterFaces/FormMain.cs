using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using WindowsFormsApp1.UserInterFaces;
using WindowsFormsApp1.LogicLayers;
namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Menu.BackColor = Color.Transparent;
            About.BackColor = Color.Transparent;
            Login_as_admin.BackColor = Color.Transparent;
            Change_Info.BackColor = Color.Transparent;
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            Menu.ForeColor = Color.Yellow;
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            Menu.ForeColor = Color.White;
        }

        private void About_MouseEnter(object sender, EventArgs e)
        {
            About.ForeColor = Color.Yellow;
        }

        private void About_MouseLeave(object sender, EventArgs e)
        {
            About.ForeColor = Color.White;
        }

        private void Login_as_admin_MouseEnter(object sender, EventArgs e)
        {
            Login_as_admin.ForeColor = Color.Yellow;
        }

        private void Login_as_admin_MouseLeave(object sender, EventArgs e)
        {
            Login_as_admin.ForeColor = Color.White;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Close();
        }

        private void Change_Info_Click(object sender, EventArgs e)
        {
            LLUsers lLUsers = new LLUsers();
            DataRow dataRow = lLUsers.IsNullLogin();
            string FirstName = (string)dataRow["FirstName"];
            string FamilyName = (string)dataRow["FamilyName"];
            string Email = (string)dataRow["Email"];
            string Phone = (string)dataRow["Phone"];
            FormEditInfo edit_Information = new FormEditInfo();
            edit_Information.nameTextBox.Text = FirstName;
            edit_Information.FamilyNameTextBox.Text = FamilyName;
            edit_Information.EmailTextBox.Text = Email;
            edit_Information.PhoneTextBox.Text = Phone;
            edit_Information.ShowDialog();
        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void Login_as_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuthentication form  = new FormAuthentication();
            form.ShowDialog();
            this.Close();
        }

        private void Change_Info_MouseEnter(object sender, EventArgs e)
        {
            Change_Info.ForeColor = Color.Yellow;
        }

        private void Change_Info_MouseLeave(object sender, EventArgs e)
        {
            Change_Info.ForeColor = Color.White;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
