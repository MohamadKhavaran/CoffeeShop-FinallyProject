namespace WindowsFormsApp1.UserInterFaces
{
    partial class FormAuthentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthentication));
            this.LabelUserName = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.LabelPassWord = new System.Windows.Forms.Label();
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.buttonConfrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.Location = new System.Drawing.Point(12, 49);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(179, 32);
            this.LabelUserName.TabIndex = 2;
            this.LabelUserName.Text = "Username : ";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.White;
            this.UserNameTextBox.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(196, 54);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(417, 28);
            this.UserNameTextBox.TabIndex = 0;
            // 
            // LabelPassWord
            // 
            this.LabelPassWord.AutoSize = true;
            this.LabelPassWord.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassWord.Location = new System.Drawing.Point(12, 139);
            this.LabelPassWord.Name = "LabelPassWord";
            this.LabelPassWord.Size = new System.Drawing.Size(175, 32);
            this.LabelPassWord.TabIndex = 3;
            this.LabelPassWord.Text = "Password : ";
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.BackColor = System.Drawing.Color.White;
            this.PassWordTextBox.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordTextBox.Location = new System.Drawing.Point(193, 139);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.Size = new System.Drawing.Size(417, 28);
            this.PassWordTextBox.TabIndex = 1;
            // 
            // buttonConfrim
            // 
            this.buttonConfrim.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfrim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfrim.Location = new System.Drawing.Point(476, 197);
            this.buttonConfrim.Name = "buttonConfrim";
            this.buttonConfrim.Size = new System.Drawing.Size(139, 40);
            this.buttonConfrim.TabIndex = 4;
            this.buttonConfrim.Text = "Confrim";
            this.buttonConfrim.UseVisualStyleBackColor = true;
            this.buttonConfrim.Click += new System.EventHandler(this.buttonConfrim_Click);
            this.buttonConfrim.MouseEnter += new System.EventHandler(this.buttonConfrim_MouseEnter);
            this.buttonConfrim.MouseLeave += new System.EventHandler(this.buttonConfrim_MouseLeave);
            // 
            // FormAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(627, 244);
            this.Controls.Add(this.buttonConfrim);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.LabelPassWord);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.LabelUserName);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuthentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuthentication_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUserName;
        internal System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label LabelPassWord;
        internal System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.Button buttonConfrim;
    }
}