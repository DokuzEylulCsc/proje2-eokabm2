using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Project2_OOP
{
    internal partial class AdminForm : Form
    {
        private readonly ElTuristiko elTuristiko;
        private readonly HotelReservationApp hotelReservationApp;
        private readonly AppDate appDate;
        internal AdminForm()
        {
            InitializeComponent();
            elTuristiko = ElTuristiko.GetInstance();
            hotelReservationApp = HotelReservationApp.GetInstance();
            appDate = AppDate.GetInstance();
        }

        internal Administrator CurrentUser { get; set; }

        private void ButtonAddHotel_Click(object sender, EventArgs e)
        {
            if (textBoxHotelName.Text == String.Empty) { labelStarHotelName.Visible = true; return; } else { labelStarHotelName.Visible = false; }
            if (comboBoxHotelCity.SelectedItem == null) { labelStarCity.Visible = true; return; } else { labelStarCity.Visible = false; }
            if (comboBoxHotelStars.SelectedItem == null) { labelStarStars.Visible = true; return; } else { labelStarStars.Visible = false; }
            if (comboBoxHotelType.SelectedItem == null) { labelStarHotelType.Visible = true; return; } else { labelStarHotelType.Visible = false; }

            if(elTuristiko.HasSameHotel(textBoxHotelName.Text))
            {
                MessageBox.Show("This hotel already exists.");
                
            }
            else
            {
                elTuristiko.AddHotel(AppFactory.BuildHotel(textBoxHotelName.Text, comboBoxHotelCity.SelectedItem.ToString(),
                    comboBoxHotelStars.SelectedIndex + 1, comboBoxHotelType.SelectedItem.ToString()));
                MessageBox.Show("Hotel " + textBoxHotelName.Text + " added.");
                AppLogs.WriteLog("(Admin) " + CurrentUser.UserId + " has Added new Hotel");
                ListAllHotels();
            }

            
        }

        private void AdminForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, 510, 0, 510, this.Height);
            
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotelReservationApp.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ListAllHotels();
            label8.Text = appDate.Date.ToShortDateString();
        }

        private void ListAllHotels()
        {
            listBoxHotels.Items.Clear();
            IEnumerator  enumerator = elTuristiko.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                listBoxHotels.Items.Add(enumerator.Current.ToString());
            }
        }

        private void ButtonAddRoom_Click(object sender, EventArgs e)
        {

            if(listBoxHotels.SelectedItem == null) { labelStarHotel.Visible = true; return; } else { labelStarHotel.Visible = false; }
            if(comboBoxRoomType.SelectedItem == null) { labelStarRoomType.Visible = true; return; } else { labelStarRoomType.Visible = false; }
   
            if(int.TryParse(textBoxRoomNo.Text, out int roomNo)) { labelStarRoomNo.Visible = false; } else { labelStarRoomNo.Visible = true; return; }
            if(int.TryParse(textBoxRoomPrice.Text, out int price)) { labelStarPrice.Visible = false; } else { labelStarPrice.Visible = true; return; }

            int capacity = 0;
            switch (comboBoxRoomType.SelectedIndex)
            {
                case 0:
                    capacity = 1;
                    break;
                case 1:
                    capacity = 2;
                    break;
                case 2:
                    capacity = 2;
                    break;
                case 3:
                    capacity = 3;
                    break;
                case 4:
                    if (textBoxCapacity.Visible == true)
                    {
                        if (int.TryParse(textBoxCapacity.Text, out int cc))
                        { labelStarCapacity.Visible = false; capacity = cc; }
                        else
                        { labelStarCapacity.Visible = true; return; }
                    }
                    break;

            }
            
            IEnumerator enumerator = elTuristiko.GetEnumerator();
            int typeHotel = listBoxHotels.SelectedIndex;
            string typeRoom = comboBoxRoomType.SelectedItem.ToString();

            for (int i = 0; i <= typeHotel; i++)
            {
                enumerator.MoveNext();
            } //enumerator seçilen oteli gösteriyor.
            Hotel hotel = ((Hotel)enumerator.Current);      
            
            if(hotel.HasSameRoomNo(roomNo))
            {
                MessageBox.Show("A room with this number already exists.");              
            }
            else
            {
                hotel.AddRoom(AppFactory.BuildRoom(roomNo, capacity, price, checkBoxHasAC.Checked, checkBoxHasBalcony.Checked, checkBoxHasSeaView.Checked,
                    checkBoxHasTV.Checked, checkBoxHasMinibar.Checked, typeRoom));
                MessageBox.Show("Room added to Hotel " + hotel.Name);
                AppLogs.WriteLog("(Admin) " + CurrentUser.UserId + " has added new Room to Hotel " + hotel.Name);
            }

        }

        private void ComboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRoomType.SelectedIndex == 4)
            {
                labelKing.Visible = true;
                textBoxCapacity.Visible = true;
            }
            else
            {
                labelKing.Visible = false;
                textBoxCapacity.Visible = false;
            }
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            appDate.NextDay();
            label8.Text = appDate.ToString();
            listBox1.Items.Clear();

            IEnumerator enumeratorH = elTuristiko.GetEnumerator();
            while (enumeratorH.MoveNext())
            {
                Hotel hotel = (Hotel)enumeratorH.Current;
                IEnumerator enumeratorR = hotel.GetEnumerator();
                int roomSum = 0; int priceSum = 0;

                while (enumeratorR.MoveNext())
                {
                    
                    Room room = (Room)enumeratorR.Current;

                    foreach(Reservation r in room.Reservations)
                    {
                        if(appDate.AreBetween(r.CheckIn, r.CheckOut))
                        {
                            roomSum++;
                            priceSum += room.Price;
                            break;
                        }
                    }

                    
                }
                listBox1.Items.Add("Hotel:  " + hotel.Name + "  Rooms:  " + roomSum + "/" + hotel.NumberOfRooms + "  Total Income:  " + priceSum + " \u20BA");

            }

        }
    }
}
