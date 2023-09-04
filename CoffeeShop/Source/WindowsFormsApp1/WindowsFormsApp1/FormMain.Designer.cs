namespace WindowsFormsApp1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Menu = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.BackColor = System.Drawing.SystemColors.Desktop;
            this.Menu.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu.Image = global::WindowsFormsApp1.Properties.Resources._8610577;
            this.Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu.Location = new System.Drawing.Point(921, 36);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(360, 91);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu     ";
            this.Menu.Click += new System.EventHandler(this.label1_Click);
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.BackColor = System.Drawing.SystemColors.Desktop;
            this.About.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.About.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.About.Location = new System.Drawing.Point(862, 150);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(419, 91);
            this.About.TabIndex = 1;
            this.About.Text = "About Us";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.coffee_rorozoa_3_04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 729);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Label About;
    }
}

