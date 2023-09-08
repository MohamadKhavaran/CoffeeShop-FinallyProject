namespace WindowsFormsApp1.UserInterFaces
{
    partial class FormEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntry));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.FamilyNameTextBox = new System.Windows.Forms.TextBox();
            this.FamilyName = new System.Windows.Forms.Label();
            this.buttonConfrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(229, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(447, 26);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(26, 118);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(97, 26);
            this.name.TabIndex = 7;
            this.name.Text = "Name : ";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("IranNastaliq", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(220, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(231, 84);
            this.title.TabIndex = 6;
            this.title.Text = "Welcome ";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(229, 261);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(447, 26);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(25, 258);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(98, 26);
            this.email.TabIndex = 9;
            this.email.Text = "Email : ";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BackColor = System.Drawing.Color.White;
            this.PhoneTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.Location = new System.Drawing.Point(229, 328);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(447, 26);
            this.PhoneTextBox.TabIndex = 4;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(19, 328);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(104, 26);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "Phone : ";
            // 
            // FamilyNameTextBox
            // 
            this.FamilyNameTextBox.BackColor = System.Drawing.Color.White;
            this.FamilyNameTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyNameTextBox.Location = new System.Drawing.Point(229, 186);
            this.FamilyNameTextBox.Name = "FamilyNameTextBox";
            this.FamilyNameTextBox.Size = new System.Drawing.Size(447, 26);
            this.FamilyNameTextBox.TabIndex = 2;
            this.FamilyNameTextBox.TextChanged += new System.EventHandler(this.FamilyNameTextBox_TextChanged);
            // 
            // FamilyName
            // 
            this.FamilyName.AutoSize = true;
            this.FamilyName.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyName.Location = new System.Drawing.Point(25, 188);
            this.FamilyName.Name = "FamilyName";
            this.FamilyName.Size = new System.Drawing.Size(177, 26);
            this.FamilyName.TabIndex = 8;
            this.FamilyName.Text = "FamilyName : ";
            // 
            // buttonConfrim
            // 
            this.buttonConfrim.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonConfrim.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfrim.Location = new System.Drawing.Point(519, 402);
            this.buttonConfrim.Name = "buttonConfrim";
            this.buttonConfrim.Size = new System.Drawing.Size(182, 50);
            this.buttonConfrim.TabIndex = 5;
            this.buttonConfrim.Text = "Confrim";
            this.buttonConfrim.UseVisualStyleBackColor = false;
            this.buttonConfrim.Click += new System.EventHandler(this.buttonConfrim_Click);
            this.buttonConfrim.MouseEnter += new System.EventHandler(this.buttonConfrim_MouseEnter);
            // 
            // FormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(706, 463);
            this.Controls.Add(this.buttonConfrim);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.FamilyName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.FamilyNameTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox FamilyNameTextBox;
        private System.Windows.Forms.Label FamilyName;
        private System.Windows.Forms.Button buttonConfrim;
    }
}