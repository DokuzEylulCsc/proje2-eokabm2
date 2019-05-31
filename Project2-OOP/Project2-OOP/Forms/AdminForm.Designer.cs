namespace Project2_OOP
{
    partial class AdminForm
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
            this.labelAddHotel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.comboBoxHotelCity = new System.Windows.Forms.ComboBox();
            this.comboBoxHotelStars = new System.Windows.Forms.ComboBox();
            this.labelStarHotelName = new System.Windows.Forms.Label();
            this.labelStarCity = new System.Windows.Forms.Label();
            this.labelStarStars = new System.Windows.Forms.Label();
            this.buttonAddHotel = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.comboBoxHotelType = new System.Windows.Forms.ComboBox();
            this.labelStarHotelType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddHotel
            // 
            this.labelAddHotel.AutoSize = true;
            this.labelAddHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddHotel.Location = new System.Drawing.Point(100, 40);
            this.labelAddHotel.Name = "labelAddHotel";
            this.labelAddHotel.Size = new System.Drawing.Size(98, 16);
            this.labelAddHotel.TabIndex = 0;
            this.labelAddHotel.Text = "Add New Hotel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stars:";
            // 
            // textBoxHotelName
            // 
            this.textBoxHotelName.Location = new System.Drawing.Point(100, 70);
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(121, 20);
            this.textBoxHotelName.TabIndex = 4;
            // 
            // comboBoxHotelCity
            // 
            this.comboBoxHotelCity.FormattingEnabled = true;
            this.comboBoxHotelCity.Items.AddRange(new object[] {
            "Istanbul",
            "Ankara",
            "Izmir",
            "Antalya",
            "Bursa"});
            this.comboBoxHotelCity.Location = new System.Drawing.Point(100, 100);
            this.comboBoxHotelCity.Name = "comboBoxHotelCity";
            this.comboBoxHotelCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHotelCity.TabIndex = 5;
            // 
            // comboBoxHotelStars
            // 
            this.comboBoxHotelStars.FormattingEnabled = true;
            this.comboBoxHotelStars.Items.AddRange(new object[] {
            "One Star",
            "Two Stars",
            "Three Stars",
            "Four Stars",
            "Five Stars"});
            this.comboBoxHotelStars.Location = new System.Drawing.Point(100, 130);
            this.comboBoxHotelStars.Name = "comboBoxHotelStars";
            this.comboBoxHotelStars.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHotelStars.TabIndex = 6;
            // 
            // labelStarHotelName
            // 
            this.labelStarHotelName.AutoSize = true;
            this.labelStarHotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarHotelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarHotelName.Location = new System.Drawing.Point(227, 70);
            this.labelStarHotelName.Name = "labelStarHotelName";
            this.labelStarHotelName.Size = new System.Drawing.Size(15, 20);
            this.labelStarHotelName.TabIndex = 7;
            this.labelStarHotelName.Text = "*";
            this.labelStarHotelName.Visible = false;
            // 
            // labelStarCity
            // 
            this.labelStarCity.AutoSize = true;
            this.labelStarCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarCity.Location = new System.Drawing.Point(227, 100);
            this.labelStarCity.Name = "labelStarCity";
            this.labelStarCity.Size = new System.Drawing.Size(15, 20);
            this.labelStarCity.TabIndex = 8;
            this.labelStarCity.Text = "*";
            this.labelStarCity.Visible = false;
            // 
            // labelStarStars
            // 
            this.labelStarStars.AutoSize = true;
            this.labelStarStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarStars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarStars.Location = new System.Drawing.Point(227, 130);
            this.labelStarStars.Name = "labelStarStars";
            this.labelStarStars.Size = new System.Drawing.Size(15, 20);
            this.labelStarStars.TabIndex = 9;
            this.labelStarStars.Text = "*";
            this.labelStarStars.Visible = false;
            // 
            // buttonAddHotel
            // 
            this.buttonAddHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddHotel.Location = new System.Drawing.Point(100, 190);
            this.buttonAddHotel.Name = "buttonAddHotel";
            this.buttonAddHotel.Size = new System.Drawing.Size(120, 30);
            this.buttonAddHotel.TabIndex = 10;
            this.buttonAddHotel.Text = "Submit";
            this.buttonAddHotel.UseVisualStyleBackColor = true;
            this.buttonAddHotel.Click += new System.EventHandler(this.ButtonAddHotel_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(650, 10);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(120, 30);
            this.buttonLogOut.TabIndex = 11;
            this.buttonLogOut.Text = "Logout";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            // 
            // comboBoxHotelType
            // 
            this.comboBoxHotelType.FormattingEnabled = true;
            this.comboBoxHotelType.Items.AddRange(new object[] {
            "Boutique",
            "Business",
            "Luxury",
            "Resort",
            "Suite"});
            this.comboBoxHotelType.Location = new System.Drawing.Point(100, 160);
            this.comboBoxHotelType.Name = "comboBoxHotelType";
            this.comboBoxHotelType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHotelType.TabIndex = 12;
            // 
            // labelStarHotelType
            // 
            this.labelStarHotelType.AutoSize = true;
            this.labelStarHotelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarHotelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarHotelType.Location = new System.Drawing.Point(227, 160);
            this.labelStarHotelType.Name = "labelStarHotelType";
            this.labelStarHotelType.Size = new System.Drawing.Size(15, 20);
            this.labelStarHotelType.TabIndex = 13;
            this.labelStarHotelType.Text = "*";
            this.labelStarHotelType.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelStarHotelType);
            this.Controls.Add(this.comboBoxHotelType);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonAddHotel);
            this.Controls.Add(this.labelStarStars);
            this.Controls.Add(this.labelStarCity);
            this.Controls.Add(this.labelStarHotelName);
            this.Controls.Add(this.comboBoxHotelStars);
            this.Controls.Add(this.comboBoxHotelCity);
            this.Controls.Add(this.textBoxHotelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAddHotel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHotelName;
        private System.Windows.Forms.ComboBox comboBoxHotelCity;
        private System.Windows.Forms.ComboBox comboBoxHotelStars;
        private System.Windows.Forms.Label labelStarHotelName;
        private System.Windows.Forms.Label labelStarCity;
        private System.Windows.Forms.Label labelStarStars;
        private System.Windows.Forms.Button buttonAddHotel;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.ComboBox comboBoxHotelType;
        private System.Windows.Forms.Label labelStarHotelType;
        private System.Windows.Forms.Label label4;
    }
}