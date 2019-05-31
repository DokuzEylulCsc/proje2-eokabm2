using System;
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
        private User currentUser;
        private ElTuristiko elTuristiko;
        private HotelReservationApp hotelReservationApp;
        internal AdminForm()
        {
            InitializeComponent();
            elTuristiko = ElTuristiko.getInstance();
            hotelReservationApp = HotelReservationApp.GetInstance();
        }

        internal User CurrentUser { get => currentUser; set => currentUser = value; }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            hotelReservationApp.Show();
        }

        private void ButtonAddHotel_Click(object sender, EventArgs e)
        {
            if (textBoxHotelName.Text == String.Empty) { labelStarHotelName.Visible = true; return; } else { labelStarHotelName.Visible = false; }
            if (comboBoxHotelCity.SelectedItem == null) { labelStarCity.Visible = true; return; } else { labelStarCity.Visible = false; }
            if (comboBoxHotelStars.SelectedItem == null) { labelStarStars.Visible = true; return; } else { labelStarStars.Visible = false; }
            if (comboBoxHotelType.SelectedItem == null) { labelStarHotelType.Visible = true; return; } else { labelStarHotelType.Visible = false; }

            if(elTuristiko.AddHotel(textBoxHotelName.Text, comboBoxHotelCity.SelectedItem.ToString(), comboBoxHotelStars.SelectedIndex + 1, comboBoxHotelType.SelectedIndex))
            {
                MessageBox.Show("Hotel " + textBoxHotelName.Text + " added.");               
            }
            else
            {
                MessageBox.Show("This hotel already exists.");
            }
        }
    }
}
