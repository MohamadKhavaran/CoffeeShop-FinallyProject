namespace WindowsFormsApp1.UserInterFaces
{
    partial class FormCoffee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoffee));
            this.Back = new System.Windows.Forms.Label();
            this.LabelBlackCoffee = new System.Windows.Forms.Label();
            this.ChBlackCoffee = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shopingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountShopping = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEspresso = new System.Windows.Forms.Label();
            this.ChEspresso = new System.Windows.Forms.Label();
            this.labelLatte = new System.Windows.Forms.Label();
            this.ChLatte = new System.Windows.Forms.Label();
            this.labelCappuccino = new System.Windows.Forms.Label();
            this.ChCappuccino = new System.Windows.Forms.Label();
            this.labelAmericano = new System.Windows.Forms.Label();
            this.ChAmericano = new System.Windows.Forms.Label();
            this.labelAffogato = new System.Windows.Forms.Label();
            this.ChAffogato = new System.Windows.Forms.Label();
            this.labelIceCoffee = new System.Windows.Forms.Label();
            this.labelRedEye = new System.Windows.Forms.Label();
            this.ChRedEye = new System.Windows.Forms.Label();
            this.ChIceCoffee = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.DimGray;
            this.Back.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Back.Location = new System.Drawing.Point(12, 552);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(143, 54);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            this.Back.MouseEnter += new System.EventHandler(this.Back_MouseEnter);
            this.Back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            // 
            // LabelBlackCoffee
            // 
            this.LabelBlackCoffee.AutoSize = true;
            this.LabelBlackCoffee.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBlackCoffee.ForeColor = System.Drawing.Color.Black;
            this.LabelBlackCoffee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelBlackCoffee.Location = new System.Drawing.Point(16, 75);
            this.LabelBlackCoffee.Name = "LabelBlackCoffee";
            this.LabelBlackCoffee.Size = new System.Drawing.Size(406, 54);
            this.LabelBlackCoffee.TabIndex = 2;
            this.LabelBlackCoffee.Text = "BlackCoffee : 3$";
            this.LabelBlackCoffee.Click += new System.EventHandler(this.LabelBlackCoffee_Click);
            // 
            // ChBlackCoffee
            // 
            this.ChBlackCoffee.AutoSize = true;
            this.ChBlackCoffee.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBlackCoffee.ForeColor = System.Drawing.Color.White;
            this.ChBlackCoffee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChBlackCoffee.Location = new System.Drawing.Point(445, 51);
            this.ChBlackCoffee.Name = "ChBlackCoffee";
            this.ChBlackCoffee.Size = new System.Drawing.Size(87, 91);
            this.ChBlackCoffee.TabIndex = 2;
            this.ChBlackCoffee.Text = "+";
            this.ChBlackCoffee.Click += new System.EventHandler(this.ChBlackCoffee_Click);
            this.ChBlackCoffee.MouseEnter += new System.EventHandler(this.ChBlackCoffee_MouseEnter);
            this.ChBlackCoffee.MouseLeave += new System.EventHandler(this.ChBlackCoffee_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopingListToolStripMenuItem,
            this.CountShopping});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shopingListToolStripMenuItem
            // 
            this.shopingListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopingListToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Cart;
            this.shopingListToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopingListToolStripMenuItem.Name = "shopingListToolStripMenuItem";
            this.shopingListToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.shopingListToolStripMenuItem.Text = "Shoping List";
            this.shopingListToolStripMenuItem.Click += new System.EventHandler(this.shopingListToolStripMenuItem_Click);
            // 
            // CountShopping
            // 
            this.CountShopping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountShopping.Name = "CountShopping";
            this.CountShopping.Size = new System.Drawing.Size(32, 24);
            this.CountShopping.Text = "0";
            // 
            // labelEspresso
            // 
            this.labelEspresso.AutoSize = true;
            this.labelEspresso.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspresso.ForeColor = System.Drawing.Color.Black;
            this.labelEspresso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEspresso.Location = new System.Drawing.Point(16, 169);
            this.labelEspresso.Name = "labelEspresso";
            this.labelEspresso.Size = new System.Drawing.Size(324, 54);
            this.labelEspresso.TabIndex = 2;
            this.labelEspresso.Text = "Espresso : 2$";
            this.labelEspresso.Click += new System.EventHandler(this.labelEspresso_Click);
            // 
            // ChEspresso
            // 
            this.ChEspresso.AutoSize = true;
            this.ChEspresso.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChEspresso.ForeColor = System.Drawing.Color.White;
            this.ChEspresso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChEspresso.Location = new System.Drawing.Point(359, 145);
            this.ChEspresso.Name = "ChEspresso";
            this.ChEspresso.Size = new System.Drawing.Size(87, 91);
            this.ChEspresso.TabIndex = 2;
            this.ChEspresso.Text = "+";
            this.ChEspresso.Click += new System.EventHandler(this.ChEspresso_Click);
            this.ChEspresso.MouseEnter += new System.EventHandler(this.ChEspresso_MouseEnter);
            this.ChEspresso.MouseLeave += new System.EventHandler(this.ChEspresso_MouseLeave);
            // 
            // labelLatte
            // 
            this.labelLatte.AutoSize = true;
            this.labelLatte.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatte.ForeColor = System.Drawing.Color.Black;
            this.labelLatte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelLatte.Location = new System.Drawing.Point(16, 263);
            this.labelLatte.Name = "labelLatte";
            this.labelLatte.Size = new System.Drawing.Size(243, 54);
            this.labelLatte.TabIndex = 2;
            this.labelLatte.Text = "Latte : 2$";
            this.labelLatte.Click += new System.EventHandler(this.labellatte_Click);
            // 
            // ChLatte
            // 
            this.ChLatte.AutoSize = true;
            this.ChLatte.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChLatte.ForeColor = System.Drawing.Color.White;
            this.ChLatte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChLatte.Location = new System.Drawing.Point(282, 237);
            this.ChLatte.Name = "ChLatte";
            this.ChLatte.Size = new System.Drawing.Size(87, 91);
            this.ChLatte.TabIndex = 2;
            this.ChLatte.Text = "+";
            this.ChLatte.Click += new System.EventHandler(this.ChLatte_Click);
            this.ChLatte.MouseEnter += new System.EventHandler(this.Chlatte_MouseEnter);
            this.ChLatte.MouseLeave += new System.EventHandler(this.Chlatte_MouseLeave);
            // 
            // labelCappuccino
            // 
            this.labelCappuccino.AutoSize = true;
            this.labelCappuccino.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCappuccino.ForeColor = System.Drawing.Color.Black;
            this.labelCappuccino.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCappuccino.Location = new System.Drawing.Point(16, 357);
            this.labelCappuccino.Name = "labelCappuccino";
            this.labelCappuccino.Size = new System.Drawing.Size(399, 54);
            this.labelCappuccino.TabIndex = 2;
            this.labelCappuccino.Text = "Cappuccino : 3$";
            this.labelCappuccino.Click += new System.EventHandler(this.labelCappuccino_Click);
            // 
            // ChCappuccino
            // 
            this.ChCappuccino.AutoSize = true;
            this.ChCappuccino.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChCappuccino.ForeColor = System.Drawing.Color.White;
            this.ChCappuccino.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChCappuccino.Location = new System.Drawing.Point(441, 330);
            this.ChCappuccino.Name = "ChCappuccino";
            this.ChCappuccino.Size = new System.Drawing.Size(87, 91);
            this.ChCappuccino.TabIndex = 2;
            this.ChCappuccino.Text = "+";
            this.ChCappuccino.Click += new System.EventHandler(this.ChCappuccino_Click);
            this.ChCappuccino.MouseEnter += new System.EventHandler(this.ChCappuccino_MouseEnter);
            this.ChCappuccino.MouseLeave += new System.EventHandler(this.ChCappuccino_MouseLeave);
            // 
            // labelAmericano
            // 
            this.labelAmericano.AutoSize = true;
            this.labelAmericano.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmericano.ForeColor = System.Drawing.Color.Black;
            this.labelAmericano.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAmericano.Location = new System.Drawing.Point(16, 451);
            this.labelAmericano.Name = "labelAmericano";
            this.labelAmericano.Size = new System.Drawing.Size(380, 54);
            this.labelAmericano.TabIndex = 2;
            this.labelAmericano.Text = "Americano : 2$";
            this.labelAmericano.Click += new System.EventHandler(this.labelAmericano_Click);
            // 
            // ChAmericano
            // 
            this.ChAmericano.AutoSize = true;
            this.ChAmericano.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChAmericano.ForeColor = System.Drawing.Color.White;
            this.ChAmericano.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChAmericano.Location = new System.Drawing.Point(419, 421);
            this.ChAmericano.Name = "ChAmericano";
            this.ChAmericano.Size = new System.Drawing.Size(87, 91);
            this.ChAmericano.TabIndex = 2;
            this.ChAmericano.Text = "+";
            this.ChAmericano.Click += new System.EventHandler(this.ChAmericano_Click);
            this.ChAmericano.MouseEnter += new System.EventHandler(this.ChAmericano_MouseEnter);
            this.ChAmericano.MouseLeave += new System.EventHandler(this.ChAmericano_MouseLeave);
            // 
            // labelAffogato
            // 
            this.labelAffogato.AutoSize = true;
            this.labelAffogato.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffogato.ForeColor = System.Drawing.Color.Black;
            this.labelAffogato.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAffogato.Location = new System.Drawing.Point(616, 75);
            this.labelAffogato.Name = "labelAffogato";
            this.labelAffogato.Size = new System.Drawing.Size(328, 54);
            this.labelAffogato.TabIndex = 2;
            this.labelAffogato.Text = "Affogato : 3$";
            this.labelAffogato.Click += new System.EventHandler(this.labelAffogato_Click);
            // 
            // ChAffogato
            // 
            this.ChAffogato.AutoSize = true;
            this.ChAffogato.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChAffogato.ForeColor = System.Drawing.Color.White;
            this.ChAffogato.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChAffogato.Location = new System.Drawing.Point(965, 53);
            this.ChAffogato.Name = "ChAffogato";
            this.ChAffogato.Size = new System.Drawing.Size(87, 91);
            this.ChAffogato.TabIndex = 2;
            this.ChAffogato.Text = "+";
            this.ChAffogato.Click += new System.EventHandler(this.ChAffogato_Click);
            this.ChAffogato.MouseEnter += new System.EventHandler(this.ChAffogato_MouseEnter);
            this.ChAffogato.MouseLeave += new System.EventHandler(this.ChAffogato_MouseLeave);
            // 
            // labelIceCoffee
            // 
            this.labelIceCoffee.AutoSize = true;
            this.labelIceCoffee.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIceCoffee.ForeColor = System.Drawing.Color.Black;
            this.labelIceCoffee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelIceCoffee.Location = new System.Drawing.Point(611, 169);
            this.labelIceCoffee.Name = "labelIceCoffee";
            this.labelIceCoffee.Size = new System.Drawing.Size(350, 54);
            this.labelIceCoffee.TabIndex = 2;
            this.labelIceCoffee.Text = "Ice Coffee : 3$";
            this.labelIceCoffee.Click += new System.EventHandler(this.labelIceCoffee_Click);
            // 
            // labelRedEye
            // 
            this.labelRedEye.AutoSize = true;
            this.labelRedEye.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedEye.ForeColor = System.Drawing.Color.Black;
            this.labelRedEye.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelRedEye.Location = new System.Drawing.Point(616, 263);
            this.labelRedEye.Name = "labelRedEye";
            this.labelRedEye.Size = new System.Drawing.Size(307, 54);
            this.labelRedEye.TabIndex = 2;
            this.labelRedEye.Text = "Red Eye : 2$";
            this.labelRedEye.Click += new System.EventHandler(this.labelRedEye_Click);
            // 
            // ChRedEye
            // 
            this.ChRedEye.AutoSize = true;
            this.ChRedEye.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChRedEye.ForeColor = System.Drawing.Color.White;
            this.ChRedEye.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChRedEye.Location = new System.Drawing.Point(946, 233);
            this.ChRedEye.Name = "ChRedEye";
            this.ChRedEye.Size = new System.Drawing.Size(87, 91);
            this.ChRedEye.TabIndex = 2;
            this.ChRedEye.Text = "+";
            this.ChRedEye.Click += new System.EventHandler(this.ChRedEye_Click);
            this.ChRedEye.MouseEnter += new System.EventHandler(this.ChRedEye_MouseEnter);
            this.ChRedEye.MouseLeave += new System.EventHandler(this.ChRedEye_MouseLeave);
            // 
            // ChIceCoffee
            // 
            this.ChIceCoffee.AutoSize = true;
            this.ChIceCoffee.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChIceCoffee.ForeColor = System.Drawing.Color.White;
            this.ChIceCoffee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChIceCoffee.Location = new System.Drawing.Point(990, 139);
            this.ChIceCoffee.Name = "ChIceCoffee";
            this.ChIceCoffee.Size = new System.Drawing.Size(87, 91);
            this.ChIceCoffee.TabIndex = 2;
            this.ChIceCoffee.Text = "+";
            this.ChIceCoffee.Click += new System.EventHandler(this.ChIceCoffee_Click);
            this.ChIceCoffee.MouseEnter += new System.EventHandler(this.ChIceCoffee_MouseEnter);
            this.ChIceCoffee.MouseLeave += new System.EventHandler(this.ChIceCoffee_MouseLeave);
            // 
            // FormCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1075, 621);
            this.Controls.Add(this.ChRedEye);
            this.Controls.Add(this.ChIceCoffee);
            this.Controls.Add(this.ChAffogato);
            this.Controls.Add(this.ChAmericano);
            this.Controls.Add(this.labelRedEye);
            this.Controls.Add(this.labelIceCoffee);
            this.Controls.Add(this.labelAffogato);
            this.Controls.Add(this.labelAmericano);
            this.Controls.Add(this.ChCappuccino);
            this.Controls.Add(this.labelCappuccino);
            this.Controls.Add(this.ChLatte);
            this.Controls.Add(this.labelLatte);
            this.Controls.Add(this.ChEspresso);
            this.Controls.Add(this.labelEspresso);
            this.Controls.Add(this.ChBlackCoffee);
            this.Controls.Add(this.LabelBlackCoffee);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormCoffee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffees";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.Label LabelBlackCoffee;
        private System.Windows.Forms.Label ChBlackCoffee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shopingListToolStripMenuItem;
        private System.Windows.Forms.Label labelEspresso;
        private System.Windows.Forms.Label ChEspresso;
        private System.Windows.Forms.Label labelLatte;
        private System.Windows.Forms.Label ChLatte;
        private System.Windows.Forms.Label labelCappuccino;
        private System.Windows.Forms.Label ChCappuccino;
        private System.Windows.Forms.Label labelAmericano;
        private System.Windows.Forms.Label ChAmericano;
        private System.Windows.Forms.Label labelAffogato;
        private System.Windows.Forms.Label ChAffogato;
        private System.Windows.Forms.Label labelIceCoffee;
        private System.Windows.Forms.Label labelRedEye;
        private System.Windows.Forms.Label ChRedEye;
        private System.Windows.Forms.Label ChIceCoffee;
        internal System.Windows.Forms.ToolStripMenuItem CountShopping;
    }
}