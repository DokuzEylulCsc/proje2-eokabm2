using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_OOP
{
    internal partial class AdminForm : Form
    {
        private readonly ElTuristiko elTuristiko;
        private readonly HotelReservationApp hotelReservationApp;
        internal AdminForm()
        {
            InitializeComponent();
            elTuristiko = ElTuristiko.getInstance();
            hotelReservationApp = HotelReservationApp.GetInstance();
        }

        internal User CurrentUser { get; set; }

        private void ButtonAddHotel_Click(object sender, EventArgs e)
        {
            if (textBoxHotelName.Text == String.Empty) { labelStarHotelName.Visible = true; return; } else { labelStarHotelName.Visible = false; }
            if (comboBoxHotelCity.SelectedItem == null) { labelStarCity.Visible = true; return; } else { labelStarCity.Visible = false; }
            if (comboBoxHotelStars.SelectedItem == null) { labelStarStars.Visible = true; return; } else { labelStarStars.Visible = false; }
            if (comboBoxHotelType.SelectedItem == null) { labelStarHotelType.Visible = true; return; } else { labelStarHotelType.Visible = false; }

            if(elTuristiko.AddHotel(textBoxHotelName.Text, comboBoxHotelCity.SelectedItem.ToString(), comboBoxHotelStars.SelectedIndex + 1, comboBoxHotelType.SelectedIndex))
            {
                MessageBox.Show("Hotel " + textBoxHotelName.Text + " added.");
                ListAllHotels();
            }
            else
            {
                MessageBox.Show("This hotel already exists.");
            }

            
        }

        private void AdminForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, 300, 0, 300, this.Height);
            
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotelReservationApp.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ListAllHotels();
        }

        private void ListAllHotels()
        {
            listBoxHotels.Items.Clear();
            IEnumerator enumerator = elTuristiko.GetEnumerator();

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
            if (textBoxCapacity.Visible == true)
            {
                if(int.TryParse(textBoxCapacity.Text, out int cc))
                { labelStarCapacity.Visible = false; capacity = cc; }
                else
                { labelStarCapacity.Visible = true; return; }
            }


            IEnumerator enumerator = elTuristiko.GetEnumerator();
            int typeHotel = listBoxHotels.SelectedIndex;
            for(int i = 0; i <= typeHotel; i++)
            {
                enumerator.MoveNext();
            } //enumerator seçilen oteli gösteriyor.
            int typeRoom = comboBoxRoomType.SelectedIndex + 1;

            if(((Hotel)enumerator.Current).AddRoom(roomNo, capacity, price, checkBoxHasAC.Checked, checkBoxHasBalcony.Checked, checkBoxHasSeaView.Checked,
                checkBoxHasTV.Checked, checkBoxHasMinibar.Checked, typeRoom))
            {
                MessageBox.Show("Room added to Hotel " + ((Hotel)enumerator.Current).Name);
            }
            else
            {
                MessageBox.Show("A room with this number already exists.");
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
    }
}
