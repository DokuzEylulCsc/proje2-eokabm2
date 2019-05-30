namespace Project2_OOP.Frms
{
    partial class Frm_AddRoom
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxAC = new System.Windows.Forms.CheckBox();
            this.checkBoxBalcony = new System.Windows.Forms.CheckBox();
            this.checkBoxSeaView = new System.Windows.Forms.CheckBox();
            this.checkBoxTV = new System.Windows.Forms.CheckBox();
            this.checkBoxMiniBar = new System.Windows.Forms.CheckBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelFeatures = new System.Windows.Forms.Label();
            this.comboBoxCapacity = new System.Windows.Forms.ComboBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonUpdateRoom = new System.Windows.Forms.Button();
            this.buttonDeleteRoom = new System.Windows.Forms.Button();
            this.buttonListRoom = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(569, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkBoxAC
            // 
            this.checkBoxAC.AutoSize = true;
            this.checkBoxAC.Location = new System.Drawing.Point(135, 204);
            this.checkBoxAC.Name = "checkBoxAC";
            this.checkBoxAC.Size = new System.Drawing.Size(50, 24);
            this.checkBoxAC.TabIndex = 1;
            this.checkBoxAC.Text = "AC";
            this.checkBoxAC.UseVisualStyleBackColor = true;
            // 
            // checkBoxBalcony
            // 
            this.checkBoxBalcony.AutoSize = true;
            this.checkBoxBalcony.Location = new System.Drawing.Point(191, 204);
            this.checkBoxBalcony.Name = "checkBoxBalcony";
            this.checkBoxBalcony.Size = new System.Drawing.Size(84, 24);
            this.checkBoxBalcony.TabIndex = 2;
            this.checkBoxBalcony.Text = "Balcony";
            this.checkBoxBalcony.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeaView
            // 
            this.checkBoxSeaView.AutoSize = true;
            this.checkBoxSeaView.Location = new System.Drawing.Point(281, 204);
            this.checkBoxSeaView.Name = "checkBoxSeaView";
            this.checkBoxSeaView.Size = new System.Drawing.Size(91, 24);
            this.checkBoxSeaView.TabIndex = 3;
            this.checkBoxSeaView.Text = "SeaView";
            this.checkBoxSeaView.UseVisualStyleBackColor = true;
            // 
            // checkBoxTV
            // 
            this.checkBoxTV.AutoSize = true;
            this.checkBoxTV.Location = new System.Drawing.Point(378, 204);
            this.checkBoxTV.Name = "checkBoxTV";
            this.checkBoxTV.Size = new System.Drawing.Size(48, 24);
            this.checkBoxTV.TabIndex = 4;
            this.checkBoxTV.Text = "TV";
            this.checkBoxTV.UseVisualStyleBackColor = true;
            // 
            // checkBoxMiniBar
            // 
            this.checkBoxMiniBar.AutoSize = true;
            this.checkBoxMiniBar.Location = new System.Drawing.Point(432, 204);
            this.checkBoxMiniBar.Name = "checkBoxMiniBar";
            this.checkBoxMiniBar.Size = new System.Drawing.Size(79, 24);
            this.checkBoxMiniBar.TabIndex = 5;
            this.checkBoxMiniBar.Text = "Minibar";
            this.checkBoxMiniBar.UseVisualStyleBackColor = true;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "DoubleRoom",
            "KingRoom",
            "SingleRoom",
            "TripleRoom",
            "TwinRoom"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(191, 42);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(121, 28);
            this.comboBoxRoomType.TabIndex = 6;
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Location = new System.Drawing.Point(48, 45);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(98, 20);
            this.labelRoomType.TabIndex = 7;
            this.labelRoomType.Text = "Room Type :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(48, 130);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(118, 20);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price per night :";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(48, 89);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(70, 20);
            this.labelCapacity.TabIndex = 9;
            this.labelCapacity.Text = "Capacity";
            // 
            // labelFeatures
            // 
            this.labelFeatures.AutoSize = true;
            this.labelFeatures.Location = new System.Drawing.Point(48, 204);
            this.labelFeatures.Name = "labelFeatures";
            this.labelFeatures.Size = new System.Drawing.Size(81, 20);
            this.labelFeatures.TabIndex = 10;
            this.labelFeatures.Text = "Features :";
            // 
            // comboBoxCapacity
            // 
            this.comboBoxCapacity.FormattingEnabled = true;
            this.comboBoxCapacity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxCapacity.Location = new System.Drawing.Point(191, 86);
            this.comboBoxCapacity.Name = "comboBoxCapacity";
            this.comboBoxCapacity.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCapacity.TabIndex = 11;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(426, 431);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(137, 31);
            this.buttonAddRoom.TabIndex = 12;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateRoom
            // 
            this.buttonUpdateRoom.Location = new System.Drawing.Point(426, 468);
            this.buttonUpdateRoom.Name = "buttonUpdateRoom";
            this.buttonUpdateRoom.Size = new System.Drawing.Size(137, 31);
            this.buttonUpdateRoom.TabIndex = 13;
            this.buttonUpdateRoom.Text = "Update Room";
            this.buttonUpdateRoom.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.Location = new System.Drawing.Point(426, 505);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(137, 31);
            this.buttonDeleteRoom.TabIndex = 14;
            this.buttonDeleteRoom.Text = "Delete Room";
            this.buttonDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // buttonListRoom
            // 
            this.buttonListRoom.Location = new System.Drawing.Point(426, 394);
            this.buttonListRoom.Name = "buttonListRoom";
            this.buttonListRoom.Size = new System.Drawing.Size(137, 31);
            this.buttonListRoom.TabIndex = 15;
            this.buttonListRoom.Text = "List Rooms";
            this.buttonListRoom.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(191, 127);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 26);
            this.textBoxPrice.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 36);
            this.button2.TabIndex = 31;
            this.button2.Text = "List Reservations";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Pick Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 275);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(641, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Burda seçili odadaki yada id ile date seçili ise o tarihteki değilse tüm rezervas" +
    "yonları listeler ";
            // 
            // Frm_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1023, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonListRoom);
            this.Controls.Add(this.buttonDeleteRoom);
            this.Controls.Add(this.buttonUpdateRoom);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.comboBoxCapacity);
            this.Controls.Add(this.labelFeatures);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.checkBoxMiniBar);
            this.Controls.Add(this.checkBoxTV);
            this.Controls.Add(this.checkBoxSeaView);
            this.Controls.Add(this.checkBoxBalcony);
            this.Controls.Add(this.checkBoxAC);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_AddRoom";
            this.Text = "Frm_AddRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxAC;
        private System.Windows.Forms.CheckBox checkBoxBalcony;
        private System.Windows.Forms.CheckBox checkBoxSeaView;
        private System.Windows.Forms.CheckBox checkBoxTV;
        private System.Windows.Forms.CheckBox checkBoxMiniBar;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelFeatures;
        private System.Windows.Forms.ComboBox comboBoxCapacity;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Button buttonUpdateRoom;
        private System.Windows.Forms.Button buttonDeleteRoom;
        private System.Windows.Forms.Button buttonListRoom;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}