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
            this.buttonListMyReservation = new System.Windows.Forms.Button();
            this.buttonCancelReservation = new System.Windows.Forms.Button();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.comboBoxPersons = new System.Windows.Forms.ComboBox();
            this.buttonMakeReservation = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.listBoxReservation = new System.Windows.Forms.ListBox();
            this.labelStarCity = new System.Windows.Forms.Label();
            this.labelStarPersons = new System.Windows.Forms.Label();
            this.labelStarRoomTypes = new System.Windows.Forms.Label();
            this.labelStarReservation = new System.Windows.Forms.Label();
            this.listBoxMyReservations = new System.Windows.Forms.ListBox();
            this.labelStarMyReservation = new System.Windows.Forms.Label();
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
            this.checkBoxSeaView.Location = new System.Drawing.Point(173, 173);
            this.checkBoxSeaView.Name = "checkBoxSeaView";
            this.checkBoxSeaView.Size = new System.Drawing.Size(68, 17);
            this.checkBoxSeaView.TabIndex = 51;
            this.checkBoxSeaView.Text = "SeaView";
            this.checkBoxSeaView.UseVisualStyleBackColor = true;
            // 
            // checkBoxBalcony
            // 
            this.checkBoxBalcony.AutoSize = true;
            this.checkBoxBalcony.Location = new System.Drawing.Point(95, 173);
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
            // buttonListMyReservation
            // 
            this.buttonListMyReservation.Location = new System.Drawing.Point(188, 262);
            this.buttonListMyReservation.Name = "buttonListMyReservation";
            this.buttonListMyReservation.Size = new System.Drawing.Size(137, 37);
            this.buttonListMyReservation.TabIndex = 48;
            this.buttonListMyReservation.Text = "List My Reservations";
            this.buttonListMyReservation.UseVisualStyleBackColor = true;
            this.buttonListMyReservation.Click += new System.EventHandler(this.buttonListMyReservation_Click);
            // 
            // buttonCancelReservation
            // 
            this.buttonCancelReservation.Location = new System.Drawing.Point(41, 262);
            this.buttonCancelReservation.Name = "buttonCancelReservation";
            this.buttonCancelReservation.Size = new System.Drawing.Size(137, 37);
            this.buttonCancelReservation.TabIndex = 47;
            this.buttonCancelReservation.Text = "Cancel Reservation";
            this.buttonCancelReservation.UseVisualStyleBackColor = true;
            this.buttonCancelReservation.Click += new System.EventHandler(this.buttonCancelReservation_Click);
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(42, 146);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoomType.TabIndex = 45;
            // 
            // comboBoxPersons
            // 
            this.comboBoxPersons.FormattingEnabled = true;
            this.comboBoxPersons.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxPersons.Location = new System.Drawing.Point(42, 119);
            this.comboBoxPersons.Name = "comboBoxPersons";
            this.comboBoxPersons.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPersons.TabIndex = 43;
            this.comboBoxPersons.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPersons_SelectedIndexChanged);
            // 
            // buttonMakeReservation
            // 
            this.buttonMakeReservation.Location = new System.Drawing.Point(188, 219);
            this.buttonMakeReservation.Name = "buttonMakeReservation";
            this.buttonMakeReservation.Size = new System.Drawing.Size(137, 37);
            this.buttonMakeReservation.TabIndex = 38;
            this.buttonMakeReservation.Text = "Make Reservation";
            this.buttonMakeReservation.UseVisualStyleBackColor = true;
            this.buttonMakeReservation.Click += new System.EventHandler(this.ButtonMakeReservation_Click);
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
            this.dateTimePickerCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(41, 93);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckOut.TabIndex = 34;
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            // labelStarCity
            // 
            this.labelStarCity.AutoSize = true;
            this.labelStarCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarCity.Location = new System.Drawing.Point(168, 41);
            this.labelStarCity.Name = "labelStarCity";
            this.labelStarCity.Size = new System.Drawing.Size(14, 16);
            this.labelStarCity.TabIndex = 55;
            this.labelStarCity.Text = "*";
            this.labelStarCity.Visible = false;
            // 
            // labelStarPersons
            // 
            this.labelStarPersons.AutoSize = true;
            this.labelStarPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarPersons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarPersons.Location = new System.Drawing.Point(164, 120);
            this.labelStarPersons.Name = "labelStarPersons";
            this.labelStarPersons.Size = new System.Drawing.Size(14, 16);
            this.labelStarPersons.TabIndex = 56;
            this.labelStarPersons.Text = "*";
            this.labelStarPersons.Visible = false;
            // 
            // labelStarRoomTypes
            // 
            this.labelStarRoomTypes.AutoSize = true;
            this.labelStarRoomTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarRoomTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarRoomTypes.Location = new System.Drawing.Point(164, 147);
            this.labelStarRoomTypes.Name = "labelStarRoomTypes";
            this.labelStarRoomTypes.Size = new System.Drawing.Size(14, 16);
            this.labelStarRoomTypes.TabIndex = 57;
            this.labelStarRoomTypes.Text = "*";
            this.labelStarRoomTypes.Visible = false;
            // 
            // labelStarReservation
            // 
            this.labelStarReservation.AutoSize = true;
            this.labelStarReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarReservation.Location = new System.Drawing.Point(357, 35);
            this.labelStarReservation.Name = "labelStarReservation";
            this.labelStarReservation.Size = new System.Drawing.Size(14, 16);
            this.labelStarReservation.TabIndex = 58;
            this.labelStarReservation.Text = "*";
            this.labelStarReservation.Visible = false;
            // 
            // listBoxMyReservations
            // 
            this.listBoxMyReservations.FormattingEnabled = true;
            this.listBoxMyReservations.Location = new System.Drawing.Point(377, 305);
            this.listBoxMyReservations.Name = "listBoxMyReservations";
            this.listBoxMyReservations.Size = new System.Drawing.Size(652, 199);
            this.listBoxMyReservations.TabIndex = 59;
            // 
            // labelStarMyReservation
            // 
            this.labelStarMyReservation.AutoSize = true;
            this.labelStarMyReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarMyReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStarMyReservation.Location = new System.Drawing.Point(357, 305);
            this.labelStarMyReservation.Name = "labelStarMyReservation";
            this.labelStarMyReservation.Size = new System.Drawing.Size(14, 16);
            this.labelStarMyReservation.TabIndex = 60;
            this.labelStarMyReservation.Text = "*";
            this.labelStarMyReservation.Visible = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1175, 559);
            this.Controls.Add(this.labelStarMyReservation);
            this.Controls.Add(this.listBoxMyReservations);
            this.Controls.Add(this.labelStarReservation);
            this.Controls.Add(this.labelStarRoomTypes);
            this.Controls.Add(this.labelStarPersons);
            this.Controls.Add(this.labelStarCity);
            this.Controls.Add(this.listBoxReservation);
            this.Controls.Add(this.checkBoxMiniBar);
            this.Controls.Add(this.checkBoxTV);
            this.Controls.Add(this.checkBoxSeaView);
            this.Controls.Add(this.checkBoxBalcony);
            this.Controls.Add(this.checkBoxAC);
            this.Controls.Add(this.buttonListMyReservation);
            this.Controls.Add(this.buttonCancelReservation);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.comboBoxPersons);
            this.Controls.Add(this.buttonMakeReservation);
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
        private System.Windows.Forms.Button buttonListMyReservation;
        private System.Windows.Forms.Button buttonCancelReservation;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.ComboBox comboBoxPersons;
        private System.Windows.Forms.Button buttonMakeReservation;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.ListBox listBoxReservation;
        private System.Windows.Forms.Label labelStarCity;
        private System.Windows.Forms.Label labelStarPersons;
        private System.Windows.Forms.Label labelStarRoomTypes;
        private System.Windows.Forms.Label labelStarReservation;
        private System.Windows.Forms.ListBox listBoxMyReservations;
        private System.Windows.Forms.Label labelStarMyReservation;
    }
}