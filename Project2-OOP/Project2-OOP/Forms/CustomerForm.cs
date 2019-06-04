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


        private User currentUser;

        internal CustomerForm()
        {
            InitializeComponent();
            elTuristiko = ElTuristiko.getInstance();
            hotelReservationApp = HotelReservationApp.GetInstance();
        }

        internal User CurrentUser { get => currentUser; set => currentUser = value; }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //Columns isimleri girilcek;
            listViewHotel.Columns.Add("");
            listViewHotel.Columns.Add("");
            listViewHotel.Columns.Add("");
            listViewHotel.Columns.Add("");
            listViewHotel.Columns.Add("");
            comboBoxCities.Items.Add("All");
            foreach (Hotel hotel in elTuristiko.Hotels)
            {
                if (!comboBoxCities.Items.Contains(hotel.City))
                {
                    comboBoxCities.Items.Add(hotel.City);
                    //Daha sonra seçili Otele göre olmalı
                    foreach(Room room in hotel.Rooms)
                    {
                        if (!comboBoxRoomType.Items.Contains(room.GetType().Name))
                        {
                            comboBoxRoomType.Items.Add(room.GetType().Name);
                        }
                        if (!comboBox1.Items.Contains(room.Capacity))
                        {
                            comboBox1.Items.Add(room.Capacity);
                        }
                        comboBox1.Sorted = true;
                    }
                    
                }
                listViewHotel.Items.Clear();
                ListAllHotels();
            }
        }
        
        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCities.Text == "All")
            {
                //listViewHotel.Items.Clear();
                ListAllHotels();
            }
            else
            {
                listViewHotel.Items.Clear();
                IEnumerator enumerator = elTuristiko.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    if (((Hotel)enumerator.Current).City == comboBoxCities.Text)
                    {
                        ListViewItem item = new ListViewItem(((Hotel)enumerator.Current).Id.ToString());
                        item.SubItems.Add(((Hotel)enumerator.Current).GetType().Name.ToString());
                        item.SubItems.Add(((Hotel)enumerator.Current).Name);
                        item.SubItems.Add(((Hotel)enumerator.Current).City);
                        item.SubItems.Add(((Hotel)enumerator.Current).NumberOfStars.ToString());
                        listViewHotel.Items.Add(item);
                    }
                }
            }
        }
        
        private void ListAllHotels()
        {
            listViewHotel.Items.Clear();
            IEnumerator enumerator = elTuristiko.GetEnumerator();
            while (enumerator.MoveNext())
            {
                ListViewItem item = new ListViewItem(((Hotel)enumerator.Current).Id.ToString());
                item.SubItems.Add(((Hotel)enumerator.Current).GetType().Name.ToString());
                item.SubItems.Add(((Hotel)enumerator.Current).Name);
                item.SubItems.Add(((Hotel)enumerator.Current).City);
                item.SubItems.Add(((Hotel)enumerator.Current).NumberOfStars.ToString());
                listViewHotel.Items.Add(item);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //var result = listViewHotel.Items.Cast < ListViewItem >().Where
            //ListViewItemCollections
            //int a = Int32.Parse(textBoxHotelID.Text);
            foreach (Hotel hotel in elTuristiko.Hotels)
            {
                if (hotel.Id == Int32.Parse(textBoxHotelID.Text))
                {
                    foreach(Room room in hotel.Rooms)
                    {
                        
                    }
                }
            }
            if (checkBoxAC.Checked) { }
            if (checkBoxBalcony.Checked) { }
            if (checkBoxMiniBar.Checked) { }
            if (checkBoxSeaView.Checked) { }
            if (checkBoxTV.Checked) { }
            
        }

        private void listViewHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHotel.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewHotel.SelectedItems[0];
                textBoxHotelID.Text = item.SubItems[0].Text;
            }
            else
            {
                textBoxHotelID.Text = string.Empty;
            }
        }
    }
}
