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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void labelCoffee_MouseEnter(object sender, EventArgs e)
        {
            labelCoffee.ForeColor = Color.Yellow;
        }

        private void labelCoffee_MouseLeave(object sender, EventArgs e)
        {
            labelCoffee.ForeColor = Color.Black;
        }

        private void ColdDrink_MouseEnter(object sender, EventArgs e)
        {
            ColdDrink.ForeColor = Color.Yellow;
        }

        private void ColdDrink_MouseLeave(object sender, EventArgs e)
        {
            ColdDrink.ForeColor = Color.Black;

        }

        private void Dessert_MouseEnter(object sender, EventArgs e)
        {
            Dessert.ForeColor = Color.Yellow;   
        }

        private void Dessert_Click(object sender, EventArgs e)
        {

        }

        private void Dessert_MouseLeave(object sender, EventArgs e)
        {
            Dessert.ForeColor = Color.Black;
        }

        private void Breakfast_MouseEnter(object sender, EventArgs e)
        {
            Breakfast.ForeColor = Color.Yellow;
        }

        private void Breakfast_MouseLeave(object sender, EventArgs e)
        {
            Breakfast.ForeColor = Color.Black;
        }

        private void Appetizer_MouseEnter(object sender, EventArgs e)
        {
            Appetizer.ForeColor = Color.Yellow;
        }

        private void Appetizer_MouseLeave(object sender, EventArgs e)
        {
            Appetizer.ForeColor = Color.Black;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void FastFood_MouseEnter(object sender, EventArgs e)
        {
            FastFood.ForeColor = Color.Yellow;  
        }

        private void FastFood_MouseLeave(object sender, EventArgs e)
        {
            FastFood.ForeColor = Color.Black;

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void HotDrink_MouseEnter(object sender, EventArgs e)
        {
            HotDrink.ForeColor = Color.Yellow;  
        }

        private void HotDrink_MouseLeave(object sender, EventArgs e)
        {
            HotDrink.ForeColor = Color.Black;
        }
    }
}
