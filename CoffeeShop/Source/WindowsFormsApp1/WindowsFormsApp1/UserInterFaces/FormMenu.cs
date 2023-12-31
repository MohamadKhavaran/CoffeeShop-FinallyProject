﻿using System;
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
    public partial class FormMenu : Form
    {
        private FormMain form;
        public FormMenu()
        {
            InitializeComponent();
            CountShopping.Text = Count_Purchases().ToString();   
        }

        private int Count_Purchases()
        {
            int Count_Purchases = 0;
            LLPurchase purchase = new LLPurchase();
            DataTable dataTable = purchase.Select();
            DataRow dataRow;
            int countRows = dataTable.Rows.Count;
            for (int i = 0; i < countRows; i++)
            {
                dataRow = dataTable.Rows[i];
                Count_Purchases += Convert.ToInt32(dataRow["Number"]);
            }
            return Count_Purchases;
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
     
        private void Back_MouseEnter(object sender, EventArgs e)
        {
            Back.ForeColor = Color.Yellow;
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Back.ForeColor= Color.White;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void labelCoffee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCoffee formCoffee = new FormCoffee();
            formCoffee.ShowDialog();
            this.Close();
        }

        private void shopingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchases_Show form = new FormPurchases_Show("Menu");
            form.ShowDialog();
            this.Close();
        }

        private void ColdDrink_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormColdDrinks formColdDrinks = new FormColdDrinks(); 
            formColdDrinks.ShowDialog();
            this.Close();
        }

        private void Dessert_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDesserts formDesserts = new FormDesserts(); 
            formDesserts.ShowDialog();
            this.Close();
        }

        private void Breakfast_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBreakfasts formBreakfasts = new FormBreakfasts();
            formBreakfasts.ShowDialog();
            this.Close();
        }

        private void Appetizer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAppetizers formAppetizers = new FormAppetizers();
            formAppetizers.ShowDialog();
            this.Close();
        }

        private void FastFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFastFoods formFastFoods = new FormFastFoods();
            formFastFoods.ShowDialog();
            this.Close();
        }
    }
}
