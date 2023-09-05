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
            this.Login_as_admin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.BackColor = System.Drawing.SystemColors.Desktop;
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu.Image = global::WindowsFormsApp1.Properties.Resources._8610577;
            this.Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu.Location = new System.Drawing.Point(918, 36);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(360, 91);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu     ";
            this.Menu.MouseEnter += new System.EventHandler(this.Menu_MouseEnter);
            this.Menu.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.BackColor = System.Drawing.SystemColors.Desktop;
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.About.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.About.Location = new System.Drawing.Point(859, 200);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(419, 91);
            this.About.TabIndex = 1;
            this.About.Text = "About Us";
            this.About.MouseEnter += new System.EventHandler(this.About_MouseEnter);
            this.About.MouseLeave += new System.EventHandler(this.About_MouseLeave);
            // 
            // Login_as_admin
            // 
            this.Login_as_admin.AutoSize = true;
            this.Login_as_admin.BackColor = System.Drawing.SystemColors.Desktop;
            this.Login_as_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_as_admin.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_as_admin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_as_admin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Login_as_admin.Location = new System.Drawing.Point(610, 366);
            this.Login_as_admin.Name = "Login_as_admin";
            this.Login_as_admin.Size = new System.Drawing.Size(668, 91);
            this.Login_as_admin.TabIndex = 2;
            this.Login_as_admin.Text = "Login as Admin";
            this.Login_as_admin.MouseEnter += new System.EventHandler(this.Login_as_admin_MouseEnter);
            this.Login_as_admin.MouseLeave += new System.EventHandler(this.Login_as_admin_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 718);
            this.Controls.Add(this.Login_as_admin);
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
        private System.Windows.Forms.Label Login_as_admin;
    }
}

