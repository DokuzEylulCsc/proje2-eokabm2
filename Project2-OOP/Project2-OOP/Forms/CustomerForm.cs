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

        //private List<Hotel> temphotels = new List<Hotel>();
        private List<Room> temprooms = new List<Room>();
        private User currentUser;
        private List<Hotel> temphotel;
        internal CustomerForm()
        {
            InitializeComponent();
            elTuristiko = ElTuristiko.getInstance();
            hotelReservationApp = HotelReservationApp.GetInstance();
            //Buraya bakılcak
            temphotel = elTuristiko.Hotels;
            resettemproom();
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
            listViewRooms.Columns.Add("No");
            listViewRooms.Columns.Add("RoomType");
            listViewRooms.Columns.Add("Capacity");
            listViewRooms.Columns.Add("Price");
            listViewRooms.Columns.Add("has AC");
            listViewRooms.Columns.Add("has Balcony");
            listViewRooms.Columns.Add("has Sea View");
            listViewRooms.Columns.Add("has TV");
            listViewRooms.Columns.Add("has Minibar");

            comboBoxCities.Items.Add("ALL");
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
            if (comboBoxCities.Text == "ALL")
            {
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
        public void resettemproom()
        {
            temprooms.Clear();
            foreach (Hotel hotel in elTuristiko.Hotels)
            {
                foreach (Room room in hotel.Rooms)
                {
                    temprooms.Add(room);
                }
            }
            
        }
            //Search Buttonunda datetimepickerlar odaların boşluk durumunu kontrol etmeli listeyi ona göre değiştirmeli
            //Genel olarak buttonsearch bize seçili özelliklerdeki müsait odaları göstercek
            //Oda hangi otelde ?
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            resettemproom();
            listViewRooms.Items.Clear();
            
            //Bir alt satırda (room.Capacity < Int32.Parse(comboBox1.Text) olursa okadar kişilik odalar listelenir
            if (comboBox1.Text != String.Empty)         {foreach (Hotel hotel in temphotel) {foreach (Room room in hotel.Rooms) {if (room.Capacity < Int32.Parse(comboBox1.Text))    {temprooms.Remove(room);}}}}
            if (comboBoxRoomType.Text != String.Empty)  {foreach (Hotel hotel in temphotel) {foreach (Room room in hotel.Rooms) {if (room.GetType().Name != comboBoxRoomType.Text)   {temprooms.Remove(room);}}}}
            if (checkBoxAC.Checked)             {foreach (Hotel hotel in temphotel) {foreach (Room room in hotel.Rooms) {if (temprooms.Contains(room) && !room.HasAC)        {temprooms.Remove(room);}}}}
            if (checkBoxBalcony.Checked)        {foreach (Hotel hotel in temphotel) {foreach (Room room in hotel.Rooms) {if (temprooms.Contains(room) && !room.HasBalcony)   {temprooms.Remove(room);}}}}
            if (checkBoxSeaView.Checked)        {foreach (Hotel hotel in temphotel) {foreach (Room room in hotel.Rooms) {if (temprooms.Contains(room) && !room.HasSeaView)   {temprooms.Remove(room);}}}}
            if (checkBoxTV.Checked)             {foreach (Hotel hotel in temphotel) {foreach (Room room in hotel.Rooms) {if (temprooms.Contains(room) && !room.HasTV)        {temprooms.Remove(room);}}}}
            if (checkBoxMiniBar.Checked)        {foreach (Hotel hotel in temphotel) {foreach (Room room in hotel.Rooms) {if (temprooms.Contains(room) && !room.HasMinibar)   {temprooms.Remove(room);}}}}
            
            foreach (Room room in temprooms)
            {
                ListViewItem item = new ListViewItem(room.No.ToString());
                item.SubItems.Add(room.GetType().Name.ToString());
                item.SubItems.Add(room.Capacity.ToString());
                item.SubItems.Add(room.Price.ToString());
                item.SubItems.Add(room.HasAC.ToString());
                item.SubItems.Add(room.HasBalcony.ToString());
                item.SubItems.Add(room.HasSeaView.ToString());
                item.SubItems.Add(room.HasTV.ToString());
                item.SubItems.Add(room.HasMinibar.ToString());
                listViewRooms.Items.Add(item);
            }
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
