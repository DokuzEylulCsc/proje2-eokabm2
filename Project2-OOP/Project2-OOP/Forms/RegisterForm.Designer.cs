namespace Project2_OOP
{
    partial class RegisterForm
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
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelPhoneN = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneN = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.Location = new System.Drawing.Point(95, 50);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(59, 18);
            this.labelUserId.TabIndex = 1;
            this.labelUserId.Text = "User Id:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(75, 92);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 18);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(69, 132);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(85, 18);
            this.labelFName.TabIndex = 3;
            this.labelFName.Text = "First Name:";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(70, 172);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(84, 18);
            this.labelLName.TabIndex = 4;
            this.labelLName.Text = "Last Name:";
            // 
            // labelPhoneN
            // 
            this.labelPhoneN.AutoSize = true;
            this.labelPhoneN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneN.Location = new System.Drawing.Point(42, 210);
            this.labelPhoneN.Name = "labelPhoneN";
            this.labelPhoneN.Size = new System.Drawing.Size(112, 18);
            this.labelPhoneN.TabIndex = 5;
            this.labelPhoneN.Text = "Phone Number:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(88, 252);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(66, 18);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(160, 50);
            this.textBoxUserId.MaxLength = 15;
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(140, 20);
            this.textBoxUserId.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(160, 90);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(140, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(160, 130);
            this.textBoxFName.MaxLength = 20;
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(140, 20);
            this.textBoxFName.TabIndex = 9;
            // 
            // textBoxPhoneN
            // 
            this.textBoxPhoneN.Location = new System.Drawing.Point(160, 210);
            this.textBoxPhoneN.MaxLength = 15;
            this.textBoxPhoneN.Name = "textBoxPhoneN";
            this.textBoxPhoneN.Size = new System.Drawing.Size(140, 20);
            this.textBoxPhoneN.TabIndex = 11;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(160, 170);
            this.textBoxLName.MaxLength = 30;
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(140, 20);
            this.textBoxLName.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(160, 250);
            this.textBoxAddress.MaxLength = 140;
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(140, 65);
            this.textBoxAddress.TabIndex = 12;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(160, 330);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(140, 39);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // labelRequired
            // 
            this.labelRequired.AutoSize = true;
            this.labelRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRequired.Location = new System.Drawing.Point(160, 20);
            this.labelRequired.Name = "labelRequired";
            this.labelRequired.Size = new System.Drawing.Size(142, 16);
            this.labelRequired.TabIndex = 14;
            this.labelRequired.Text = "*All fields are required.";
            this.labelRequired.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(460, 437);
            this.Controls.Add(this.labelRequired);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxPhoneN);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhoneN);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register to El Turistiko";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelPhoneN;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxPhoneN;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelRequired;
    }
}