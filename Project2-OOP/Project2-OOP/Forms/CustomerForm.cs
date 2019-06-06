using System;
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
        internal CustomerForm()
        {
            InitializeComponent();
            elTuristiko = ElTuristiko.getInstance();
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
            listBoxReservation.Items.Clear();

            List<string> searches;
            searches = elTuristiko.SearchRooms(comboBoxCities.SelectedItem.ToString(), dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value, comboBoxRoomType.SelectedItem.ToString(),
                checkBoxAC.Checked, checkBoxBalcony.Checked, checkBoxSeaView.Checked, checkBoxTV.Checked, checkBoxMiniBar.Checked);

            List<string[]> list = new List<string[]> { };
            foreach(string s in searches)
            {
                list.Add(s.Split(' '));
            }

            if(searches.Count != 0)
            {
                foreach(string s in searches)
                {
                    listBoxReservation.Items.Add(s);
                }
            }
            else
            {
                MessageBox.Show("There is no room for your search.");
            }
        }
    }
}
