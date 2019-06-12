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
            this.comboBoxHotelType = new System.Windows.Forms.ComboBox();
            this.labelStarHotelType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAddRoom = new System.Windows.Forms.Label();
            this.listBoxHotels = new System.Windows.Forms.ListBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.checkBoxHasAC = new System.Windows.Forms.CheckBox();
            this.checkBoxHasBalcony = new System.Windows.Forms.CheckBox();
            this.checkBoxHasSeaView = new System.Windows.Forms.CheckBox();
            this.checkBoxHasTV = new System.Windows.Forms.CheckBox();
            this.checkBoxHasMinibar = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStarRoomType = new System.Windows.Forms.Label();
            this.labelStarHotel = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStarRoomNo = new System.Windows.Forms.Label();
            this.textBoxRoomPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelStarPrice = new System.Windows.Forms.Label();
            this.labelKing = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.labelStarCapacity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.textBoxHotelName.MaxLength = 50;
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(121, 20);
            this.textBoxHotelName.TabIndex = 5;
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
            this.comboBoxHotelCity.TabIndex = 6;
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
            this.comboBoxHotelStars.TabIndex = 7;
            // 
            // labelStarHotelName
            // 
            this.labelStarHotelName.AutoSize = true;
            this.labelStarHotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarHotelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarHotelName.Location = new System.Drawing.Point(227, 70);
            this.labelStarHotelName.Name = "labelStarHotelName";
            this.labelStarHotelName.Size = new System.Drawing.Size(15, 20);
            this.labelStarHotelName.TabIndex = 10;
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
            this.labelStarCity.TabIndex = 11;
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
            this.labelStarStars.TabIndex = 12;
            this.labelStarStars.Text = "*";
            this.labelStarStars.Visible = false;
            // 
            // buttonAddHotel
            // 
            this.buttonAddHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddHotel.Location = new System.Drawing.Point(100, 190);
            this.buttonAddHotel.Name = "buttonAddHotel";
            this.buttonAddHotel.Size = new System.Drawing.Size(120, 30);
            this.buttonAddHotel.TabIndex = 9;
            this.buttonAddHotel.Text = "Submit";
            this.buttonAddHotel.UseVisualStyleBackColor = true;
            this.buttonAddHotel.Click += new System.EventHandler(this.ButtonAddHotel_Click);
            // 
            // comboBoxHotelType
            // 
            this.comboBoxHotelType.FormattingEnabled = true;
            this.comboBoxHotelType.Items.AddRange(new object[] {
            "BoutiqueHotel",
            "BusinessHotel",
            "LuxuryHotel",
            "ResortHotel",
            "SuiteHotel"});
            this.comboBoxHotelType.Location = new System.Drawing.Point(100, 160);
            this.comboBoxHotelType.Name = "comboBoxHotelType";
            this.comboBoxHotelType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHotelType.TabIndex = 8;
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
            this.label4.TabIndex = 4;
            this.label4.Text = "Type:";
            // 
            // labelAddRoom
            // 
            this.labelAddRoom.AutoSize = true;
            this.labelAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddRoom.Location = new System.Drawing.Point(577, 40);
            this.labelAddRoom.Name = "labelAddRoom";
            this.labelAddRoom.Size = new System.Drawing.Size(163, 16);
            this.labelAddRoom.TabIndex = 14;
            this.labelAddRoom.Text = "Add New Room to a Hotel";
            // 
            // listBoxHotels
            // 
            this.listBoxHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHotels.FormattingEnabled = true;
            this.listBoxHotels.ItemHeight = 15;
            this.listBoxHotels.Location = new System.Drawing.Point(580, 71);
            this.listBoxHotels.Name = "listBoxHotels";
            this.listBoxHotels.Size = new System.Drawing.Size(360, 229);
            this.listBoxHotels.TabIndex = 15;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoom.Location = new System.Drawing.Point(580, 455);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(167, 30);
            this.buttonAddRoom.TabIndex = 29;
            this.buttonAddRoom.Text = "Submit";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.ButtonAddRoom_Click);
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "SingleRoom",
            "DoubleRoom",
            "TwinRoom",
            "TripleRoom",
            "KingRoom"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(626, 335);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(120, 21);
            this.comboBoxRoomType.TabIndex = 23;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRoomType_SelectedIndexChanged);
            // 
            // checkBoxHasAC
            // 
            this.checkBoxHasAC.AutoSize = true;
            this.checkBoxHasAC.Location = new System.Drawing.Point(580, 306);
            this.checkBoxHasAC.Name = "checkBoxHasAC";
            this.checkBoxHasAC.Size = new System.Drawing.Size(40, 17);
            this.checkBoxHasAC.TabIndex = 17;
            this.checkBoxHasAC.Text = "AC";
            this.checkBoxHasAC.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasBalcony
            // 
            this.checkBoxHasBalcony.AutoSize = true;
            this.checkBoxHasBalcony.Location = new System.Drawing.Point(626, 306);
            this.checkBoxHasBalcony.Name = "checkBoxHasBalcony";
            this.checkBoxHasBalcony.Size = new System.Drawing.Size(64, 17);
            this.checkBoxHasBalcony.TabIndex = 18;
            this.checkBoxHasBalcony.Text = "Balcony";
            this.checkBoxHasBalcony.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasSeaView
            // 
            this.checkBoxHasSeaView.AutoSize = true;
            this.checkBoxHasSeaView.Location = new System.Drawing.Point(696, 306);
            this.checkBoxHasSeaView.Name = "checkBoxHasSeaView";
            this.checkBoxHasSeaView.Size = new System.Drawing.Size(71, 17);
            this.checkBoxHasSeaView.TabIndex = 19;
            this.checkBoxHasSeaView.Text = "Sea View";
            this.checkBoxHasSeaView.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasTV
            // 
            this.checkBoxHasTV.AutoSize = true;
            this.checkBoxHasTV.Location = new System.Drawing.Point(773, 306);
            this.checkBoxHasTV.Name = "checkBoxHasTV";
            this.checkBoxHasTV.Size = new System.Drawing.Size(40, 17);
            this.checkBoxHasTV.TabIndex = 20;
            this.checkBoxHasTV.Text = "TV";
            this.checkBoxHasTV.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasMinibar
            // 
            this.checkBoxHasMinibar.AutoSize = true;
            this.checkBoxHasMinibar.Location = new System.Drawing.Point(818, 306);
            this.checkBoxHasMinibar.Name = "checkBoxHasMinibar";
            this.checkBoxHasMinibar.Size = new System.Drawing.Size(60, 17);
            this.checkBoxHasMinibar.TabIndex = 21;
            this.checkBoxHasMinibar.Text = "Minibar";
            this.checkBoxHasMinibar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Type:";
            // 
            // labelStarRoomType
            // 
            this.labelStarRoomType.AutoSize = true;
            this.labelStarRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarRoomType.Location = new System.Drawing.Point(752, 335);
            this.labelStarRoomType.Name = "labelStarRoomType";
            this.labelStarRoomType.Size = new System.Drawing.Size(15, 20);
            this.labelStarRoomType.TabIndex = 24;
            this.labelStarRoomType.Text = "*";
            this.labelStarRoomType.Visible = false;
            // 
            // labelStarHotel
            // 
            this.labelStarHotel.AutoSize = true;
            this.labelStarHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarHotel.Location = new System.Drawing.Point(944, 69);
            this.labelStarHotel.Name = "labelStarHotel";
            this.labelStarHotel.Size = new System.Drawing.Size(15, 20);
            this.labelStarHotel.TabIndex = 16;
            this.labelStarHotel.Text = "*";
            this.labelStarHotel.Visible = false;
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Location = new System.Drawing.Point(626, 362);
            this.textBoxRoomNo.MaxLength = 6;
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxRoomNo.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(578, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "No:";
            // 
            // labelStarRoomNo
            // 
            this.labelStarRoomNo.AutoSize = true;
            this.labelStarRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarRoomNo.Location = new System.Drawing.Point(752, 360);
            this.labelStarRoomNo.Name = "labelStarRoomNo";
            this.labelStarRoomNo.Size = new System.Drawing.Size(15, 20);
            this.labelStarRoomNo.TabIndex = 27;
            this.labelStarRoomNo.Text = "*";
            this.labelStarRoomNo.Visible = false;
            // 
            // textBoxRoomPrice
            // 
            this.textBoxRoomPrice.Location = new System.Drawing.Point(626, 388);
            this.textBoxRoomPrice.MaxLength = 6;
            this.textBoxRoomPrice.Name = "textBoxRoomPrice";
            this.textBoxRoomPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxRoomPrice.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Price:";
            // 
            // labelStarPrice
            // 
            this.labelStarPrice.AutoSize = true;
            this.labelStarPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarPrice.Location = new System.Drawing.Point(752, 388);
            this.labelStarPrice.Name = "labelStarPrice";
            this.labelStarPrice.Size = new System.Drawing.Size(15, 20);
            this.labelStarPrice.TabIndex = 31;
            this.labelStarPrice.Text = "*";
            this.labelStarPrice.Visible = false;
            // 
            // labelKing
            // 
            this.labelKing.AutoSize = true;
            this.labelKing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKing.Location = new System.Drawing.Point(578, 415);
            this.labelKing.Name = "labelKing";
            this.labelKing.Size = new System.Drawing.Size(64, 16);
            this.labelKing.TabIndex = 32;
            this.labelKing.Text = "Capacity:";
            this.labelKing.Visible = false;
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(646, 414);
            this.textBoxCapacity.MaxLength = 2;
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(44, 20);
            this.textBoxCapacity.TabIndex = 33;
            this.textBoxCapacity.Visible = false;
            // 
            // labelStarCapacity
            // 
            this.labelStarCapacity.AutoSize = true;
            this.labelStarCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarCapacity.Location = new System.Drawing.Point(696, 415);
            this.labelStarCapacity.Name = "labelStarCapacity";
            this.labelStarCapacity.Size = new System.Drawing.Size(15, 20);
            this.labelStarCapacity.TabIndex = 34;
            this.labelStarCapacity.Text = "*";
            this.labelStarCapacity.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Next Day";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Summary";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 305);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(428, 184);
            this.listBox1.TabIndex = 41;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1069, 497);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelStarCapacity);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.labelKing);
            this.Controls.Add(this.labelStarPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRoomPrice);
            this.Controls.Add(this.labelStarRoomNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRoomNo);
            this.Controls.Add(this.labelStarHotel);
            this.Controls.Add(this.labelStarRoomType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxHasMinibar);
            this.Controls.Add(this.checkBoxHasTV);
            this.Controls.Add(this.checkBoxHasSeaView);
            this.Controls.Add(this.checkBoxHasBalcony);
            this.Controls.Add(this.checkBoxHasAC);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.listBoxHotels);
            this.Controls.Add(this.labelAddRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelStarHotelType);
            this.Controls.Add(this.comboBoxHotelType);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminForm_Paint);
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
        private System.Windows.Forms.ComboBox comboBoxHotelType;
        private System.Windows.Forms.Label labelStarHotelType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAddRoom;
        private System.Windows.Forms.ListBox listBoxHotels;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.CheckBox checkBoxHasAC;
        private System.Windows.Forms.CheckBox checkBoxHasBalcony;
        private System.Windows.Forms.CheckBox checkBoxHasSeaView;
        private System.Windows.Forms.CheckBox checkBoxHasTV;
        private System.Windows.Forms.CheckBox checkBoxHasMinibar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStarRoomType;
        private System.Windows.Forms.Label labelStarHotel;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStarRoomNo;
        private System.Windows.Forms.TextBox textBoxRoomPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelStarPrice;
        private System.Windows.Forms.Label labelKing;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.Label labelStarCapacity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
    }
}