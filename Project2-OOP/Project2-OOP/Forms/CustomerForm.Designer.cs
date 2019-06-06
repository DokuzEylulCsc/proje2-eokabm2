namespace Project2_OOP
{
    partial class CustomerForm
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
            this.checkBoxMiniBar = new System.Windows.Forms.CheckBox();
            this.checkBoxTV = new System.Windows.Forms.CheckBox();
            this.checkBoxSeaView = new System.Windows.Forms.CheckBox();
            this.checkBoxBalcony = new System.Windows.Forms.CheckBox();
            this.checkBoxAC = new System.Windows.Forms.CheckBox();
            this.buttonShowMyReservation = new System.Windows.Forms.Button();
            this.buttonDeleteReservation = new System.Windows.Forms.Button();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.comboBoxPersons = new System.Windows.Forms.ComboBox();
            this.buttonAddReservation = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.listBoxReservation = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // checkBoxMiniBar
            // 
            this.checkBoxMiniBar.AutoSize = true;
            this.checkBoxMiniBar.Location = new System.Drawing.Point(95, 196);
            this.checkBoxMiniBar.Name = "checkBoxMiniBar";
            this.checkBoxMiniBar.Size = new System.Drawing.Size(60, 17);
            this.checkBoxMiniBar.TabIndex = 53;
            this.checkBoxMiniBar.Text = "Minibar";
            this.checkBoxMiniBar.UseVisualStyleBackColor = true;
            // 
            // checkBoxTV
            // 
            this.checkBoxTV.AutoSize = true;
            this.checkBoxTV.Location = new System.Drawing.Point(41, 196);
            this.checkBoxTV.Name = "checkBoxTV";
            this.checkBoxTV.Size = new System.Drawing.Size(40, 17);
            this.checkBoxTV.TabIndex = 52;
            this.checkBoxTV.Text = "TV";
            this.checkBoxTV.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeaView
            // 
            this.checkBoxSeaView.AutoSize = true;
            this.checkBoxSeaView.Location = new System.Drawing.Point(188, 173);
            this.checkBoxSeaView.Name = "checkBoxSeaView";
            this.checkBoxSeaView.Size = new System.Drawing.Size(68, 17);
            this.checkBoxSeaView.TabIndex = 51;
            this.checkBoxSeaView.Text = "SeaView";
            this.checkBoxSeaView.UseVisualStyleBackColor = true;
            // 
            // checkBoxBalcony
            // 
            this.checkBoxBalcony.AutoSize = true;
            this.checkBoxBalcony.Location = new System.Drawing.Point(98, 173);
            this.checkBoxBalcony.Name = "checkBoxBalcony";
            this.checkBoxBalcony.Size = new System.Drawing.Size(64, 17);
            this.checkBoxBalcony.TabIndex = 50;
            this.checkBoxBalcony.Text = "Balcony";
            this.checkBoxBalcony.UseVisualStyleBackColor = true;
            // 
            // checkBoxAC
            // 
            this.checkBoxAC.AutoSize = true;
            this.checkBoxAC.Location = new System.Drawing.Point(42, 173);
            this.checkBoxAC.Name = "checkBoxAC";
            this.checkBoxAC.Size = new System.Drawing.Size(40, 17);
            this.checkBoxAC.TabIndex = 49;
            this.checkBoxAC.Text = "AC";
            this.checkBoxAC.UseVisualStyleBackColor = true;
            // 
            // buttonShowMyReservation
            // 
            this.buttonShowMyReservation.Location = new System.Drawing.Point(188, 262);
            this.buttonShowMyReservation.Name = "buttonShowMyReservation";
            this.buttonShowMyReservation.Size = new System.Drawing.Size(137, 37);
            this.buttonShowMyReservation.TabIndex = 48;
            this.buttonShowMyReservation.Text = "Show My Reservations";
            this.buttonShowMyReservation.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteReservation
            // 
            this.buttonDeleteReservation.Location = new System.Drawing.Point(188, 219);
            this.buttonDeleteReservation.Name = "buttonDeleteReservation";
            this.buttonDeleteReservation.Size = new System.Drawing.Size(137, 37);
            this.buttonDeleteReservation.TabIndex = 47;
            this.buttonDeleteReservation.Text = "Delete Reservation";
            this.buttonDeleteReservation.UseVisualStyleBackColor = true;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Twin Room",
            "Triple Room",
            "King Room"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(42, 119);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoomType.TabIndex = 45;
            // 
            // comboBoxPersons
            // 
            this.comboBoxPersons.FormattingEnabled = true;
            this.comboBoxPersons.Items.AddRange(new object[] {
            "1 Person",
            "2 People",
            "3 People"});
            this.comboBoxPersons.Location = new System.Drawing.Point(41, 146);
            this.comboBoxPersons.Name = "comboBoxPersons";
            this.comboBoxPersons.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPersons.TabIndex = 43;
            // 
            // buttonAddReservation
            // 
            this.buttonAddReservation.Location = new System.Drawing.Point(41, 262);
            this.buttonAddReservation.Name = "buttonAddReservation";
            this.buttonAddReservation.Size = new System.Drawing.Size(137, 37);
            this.buttonAddReservation.TabIndex = 38;
            this.buttonAddReservation.Text = "Add Reservation";
            this.buttonAddReservation.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(41, 219);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 37);
            this.buttonSearch.TabIndex = 37;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(41, 93);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckOut.TabIndex = 34;
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(41, 67);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckIn.TabIndex = 33;
            this.dateTimePickerCheckIn.ValueChanged += new System.EventHandler(this.DateTimePickerCheckIn_ValueChanged);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(41, 40);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCities.TabIndex = 31;
            // 
            // listBoxReservation
            // 
            this.listBoxReservation.FormattingEnabled = true;
            this.listBoxReservation.Location = new System.Drawing.Point(377, 35);
            this.listBoxReservation.Name = "listBoxReservation";
            this.listBoxReservation.Size = new System.Drawing.Size(652, 264);
            this.listBoxReservation.TabIndex = 54;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1175, 559);
            this.Controls.Add(this.listBoxReservation);
            this.Controls.Add(this.checkBoxMiniBar);
            this.Controls.Add(this.checkBoxTV);
            this.Controls.Add(this.checkBoxSeaView);
            this.Controls.Add(this.checkBoxBalcony);
            this.Controls.Add(this.checkBoxAC);
            this.Controls.Add(this.buttonShowMyReservation);
            this.Controls.Add(this.buttonDeleteReservation);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.comboBoxPersons);
            this.Controls.Add(this.buttonAddReservation);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerCheckOut);
            this.Controls.Add(this.dateTimePickerCheckIn);
            this.Controls.Add(this.comboBoxCities);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMiniBar;
        private System.Windows.Forms.CheckBox checkBoxTV;
        private System.Windows.Forms.CheckBox checkBoxSeaView;
        private System.Windows.Forms.CheckBox checkBoxBalcony;
        private System.Windows.Forms.CheckBox checkBoxAC;
        private System.Windows.Forms.Button buttonShowMyReservation;
        private System.Windows.Forms.Button buttonDeleteReservation;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.ComboBox comboBoxPersons;
        private System.Windows.Forms.Button buttonAddReservation;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.ListBox listBoxReservation;
    }
}