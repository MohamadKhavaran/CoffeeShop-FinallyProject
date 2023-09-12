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
    public partial class FormAdmin : Form
    {
        LLProducts lProducts = new LLProducts();
        public FormAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            bindingSourceData.DataSource = lProducts.Select();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int AddProductButtonIndex = dataGridViewData.Columns["AddProduct"].Index;
            int RemoveProductButtonIndex = dataGridViewData.Columns["RemoveProduct"].Index;
            if (e.ColumnIndex == AddProductButtonIndex)
            {
                string ProductName = dataGridViewData["ProductName", e.RowIndex].Value.ToString();
                LLProducts lProducts = new LLProducts();
                lProducts.UpdateWithProductName(ProductName);
                LoadData();
            }
            if (e.ColumnIndex == RemoveProductButtonIndex)
            {
                int ProductCode = Convert.ToInt32(dataGridViewData["ProductCode", e.RowIndex].Value);
                LLProducts lProducts = new LLProducts();
                lProducts.UpdateSell(ProductCode);
                LoadData();
            }
        }
    }
}
