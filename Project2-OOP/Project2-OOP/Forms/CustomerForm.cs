﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Project2_OOP
{
    internal partial class CustomerForm : Form
    {
        private readonly ElTuristiko elTuristiko;
        private readonly HotelReservationApp hotelReservationApp;
        private readonly AppDate appDate;
        private User currentUser;
        internal User CurrentUser { get => currentUser; set => currentUser = value; }

        private List<string[]> res_list;

        internal CustomerForm()
        {
            InitializeComponent();
            elTuristiko = ElTuristiko.GetInstance();
            hotelReservationApp = HotelReservationApp.GetInstance();
            appDate = AppDate.GetInstance();
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotelReservationApp.Show();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //comboboxCities
            List<string> cities;
            cities = elTuristiko.GetCities();
            foreach(string s in cities) { comboBoxCities.Items.Add(s); } //combobox a şehirler eklendi.

            //dateTimePickerCheckIn
            dateTimePickerCheckIn.MinDate = appDate.Date;
            dateTimePickerCheckOut.MinDate = appDate.Date.AddDays(1);
        }

        private void DateTimePickerCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerCheckOut.MinDate = dateTimePickerCheckIn.Value.AddDays(1);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if(!((Customer)currentUser).isBookable(dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value))
            {
                MessageBox.Show("You have a reservation between these dates.");
                return;
            }

            if(comboBoxCities.SelectedItem == null) { labelStarCity.Visible = true; return; } else { labelStarCity.Visible = false; }
            if (comboBoxPersons.SelectedItem == null) { labelStarPersons.Visible = true; return; } else { labelStarPersons.Visible = false; }
            if (comboBoxRoomType.SelectedItem == null) { labelStarRoomTypes.Visible = true; return; } else { labelStarRoomTypes.Visible = false; }

            listBoxReservation.Items.Clear();

            res_list = elTuristiko.SearchRooms(comboBoxCities.SelectedItem.ToString(), dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value, comboBoxRoomType.SelectedItem.ToString(),
                checkBoxAC.Checked, checkBoxBalcony.Checked, checkBoxSeaView.Checked, checkBoxTV.Checked, checkBoxMiniBar.Checked);

            foreach(string[] s in res_list){
                listBoxReservation.Items.Add(s[2] + " " + s[3] + " " + s[4] + " " + s[5] + " " + s[6]);
            }
     
        }

        private void ComboBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRoomType.Items.Clear();
            comboBoxRoomType.SelectedItem = null;

            int i = comboBoxPersons.SelectedIndex;
            string[] rooms = new string[] { "Single Room", "Double Room", "Twin Room", "Triple Room", "King Room" };

            if (i >= 2){ i++; }

            while (i < 5){ comboBoxRoomType.Items.Add(rooms[i++]); }

        }

        private void ButtonMakeReservation_Click(object sender, EventArgs e)
        {
            if (listBoxReservation.SelectedItem == null) { labelStarReservation.Visible = true; } else { labelStarReservation.Visible = false; }

            int index = 0;
            int hotelId = 0;
            int roomNo = 0;
            try
            {
                index = listBoxReservation.SelectedIndex;
                hotelId = Convert.ToInt32(res_list[index][0]);
                roomNo = Convert.ToInt32(res_list[index][1]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            

            IEnumerator enumeratorH = elTuristiko.GetEnumerator();
            while (enumeratorH.MoveNext())
            {
                if(((Hotel)enumeratorH.Current).Id == hotelId)
                {
                    IEnumerator enumeratorR = ((Hotel)enumeratorH.Current).GetEnumerator();
                    while (enumeratorR.MoveNext())
                    {
                        if(((Room)enumeratorR.Current).No == roomNo)
                        {
                            Reservation r = ((Room)enumeratorR.Current).Make_Reservation(((Hotel)enumeratorH.Current).Name,
                                roomNo, Convert.ToDateTime(res_list[index][7]), Convert.ToDateTime(res_list[index][8]));
                            ((Customer)currentUser).Make_Reservation(r);
                        }
                    }
                }
            }

            listBoxReservation.Items.Clear();

        }

        private void buttonListMyReservation_Click(object sender, EventArgs e)
        {
            listBoxMyReservations.Items.Clear();
            foreach(Reservation r in ((Customer)currentUser).Reservations)
            {
                listBoxMyReservations.Items.Add(r.ToString());
            }
        }

        private void buttonCancelReservation_Click(object sender, EventArgs e)
        {
            if (listBoxMyReservations.SelectedItem == null) { labelStarMyReservation.Visible = true; return; } else { labelStarMyReservation.Visible = false; }

            int index = 0;

            try
            {
                index = listBoxMyReservations.SelectedIndex;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Reservation r = ((Customer)currentUser).Reservations[index];

            IEnumerator enumeratorH = elTuristiko.GetEnumerator();
            while (enumeratorH.MoveNext())
            {
                if (((Hotel)enumeratorH.Current).Name == r.HotelName)
                {
                    IEnumerator enumeratorR = ((Hotel)enumeratorH.Current).GetEnumerator();
                    while (enumeratorR.MoveNext())
                    {
                        if (((Room)enumeratorR.Current).No == r.RoomNo)
                        {
                            ((Room)enumeratorR.Current).Cancel_Reservation(r);
                        }
                    }
                }
            }

            ((Customer)currentUser).Cancel_Reservation(r);

            listBoxMyReservations.Items.Clear();


        }
    }
}
