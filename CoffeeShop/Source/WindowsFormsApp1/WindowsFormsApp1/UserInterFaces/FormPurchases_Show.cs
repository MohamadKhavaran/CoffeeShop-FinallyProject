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
using WindowsFormsApp1.UserInterFaces;
namespace WindowsFormsApp1.UserInterFaces
{
    public partial class FormPurchases_Show : Form
    {
        LLPurchase lPurchase = new LLPurchase();
        string identifier_variable;
        public FormPurchases_Show(string identifier_variable)
        {
            InitializeComponent();
            this.identifier_variable = identifier_variable;
            LoadData();
        }

        private void LoadData()
        {
            bindingSourceData.DataSource = lPurchase.Select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int intIndexresetColumns = dataGridViewData.Columns["RemoveOne"].Index;

            if (intIndexresetColumns == e.ColumnIndex)
            {
                LLPurchase lPurchase = new LLPurchase();
                string NameProduct = dataGridViewData["NameProduct", e.RowIndex].Value.ToString();
                int Total_Price = Convert.ToInt32(dataGridViewData["Price", e.RowIndex].Value);
                int Count_Purchases = Convert.ToInt32(dataGridViewData["Number", e.RowIndex].Value);
                if (Count_Purchases <= 1)
                {
                    lPurchase.Delete(NameProduct);
                    LoadData();

                    return;
                }
                int Price_Product = Total_Price / Count_Purchases;
                lPurchase.Update(NameProduct, (Total_Price - Price_Product), (Count_Purchases - 1));
                LoadData();
            }
            else
                return;
        }

        private void FormPurchases_Show_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Saving Was Done Successfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                if (identifier_variable.Equals("Menu"))
                {
                    FormMenu form = new FormMenu();
                    this.Hide();
                    form.ShowDialog();
                }
                if (identifier_variable.Equals("Coffee"))
                {

                    FormCoffee form = new FormCoffee();
                    this.Hide();
                    form.ShowDialog();
                }
            }
        }
    }
}
