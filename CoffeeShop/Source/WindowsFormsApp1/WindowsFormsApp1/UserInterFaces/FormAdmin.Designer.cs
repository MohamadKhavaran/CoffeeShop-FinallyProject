namespace WindowsFormsApp1.UserInterFaces
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.bindingSourceData = new System.Windows.Forms.BindingSource(this.components);
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AllowUserToOrderColumns = true;
            this.dataGridViewData.AutoGenerateColumns = false;
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.ProductNumber,
            this.ProductPrice,
            this.AddProduct,
            this.RemoveProduct});
            this.dataGridViewData.DataSource = this.bindingSourceData;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(1388, 576);
            this.dataGridViewData.TabIndex = 0;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "ProductCode";
            this.ProductCode.MinimumWidth = 6;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductNumber
            // 
            this.ProductNumber.DataPropertyName = "ProductNumber";
            this.ProductNumber.HeaderText = "ProductNumber";
            this.ProductNumber.MinimumWidth = 6;
            this.ProductNumber.Name = "ProductNumber";
            this.ProductNumber.ReadOnly = true;
            this.ProductNumber.Width = 125;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // AddProduct
            // 
            this.AddProduct.HeaderText = "AddProduct";
            this.AddProduct.MinimumWidth = 6;
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.ReadOnly = true;
            this.AddProduct.Text = "+";
            this.AddProduct.UseColumnTextForButtonValue = true;
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.HeaderText = "RemoveProduct";
            this.RemoveProduct.MinimumWidth = 6;
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.ReadOnly = true;
            this.RemoveProduct.Text = "-";
            this.RemoveProduct.UseColumnTextForButtonValue = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 576);
            this.Controls.Add(this.dataGridViewData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin User Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.BindingSource bindingSourceData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewButtonColumn AddProduct;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveProduct;
    }
}