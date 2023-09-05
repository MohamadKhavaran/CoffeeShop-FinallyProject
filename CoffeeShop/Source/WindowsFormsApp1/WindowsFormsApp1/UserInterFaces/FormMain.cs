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
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            Menu.ForeColor = Color.Yellow; 
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            Menu.ForeColor= Color.White;
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
            FormMenu Menu = new FormMenu();
            Menu.ShowDialog();
        }
    }
}
