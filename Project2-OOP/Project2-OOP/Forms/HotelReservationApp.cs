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
    public partial class HotelReservationApp : Form
    {
        private ElTuristiko elTuristiko = ElTuristiko.getInstance();
        internal static User currentUser;
        private static Random random = new Random();

        public HotelReservationApp()
        {
            InitializeComponent();
            InitializeFiles();
        }

        private void HotelReservationApp_Load(object sender, EventArgs e)
        {

        }

        private void InitializeFiles() //dosyalardan bilgileri alıcak
        {
            elTuristiko.AddUser(new Administrator("admin", "123456"));
            elTuristiko.AddUser(new Customer("eminozk", "123456", "Emin Özkaradeniz", "Bucca", "5055050"));
            
           
            Hotel hotel1 = new BusinessHotel("Silence Istanbul", "Istanbul", 5);
            Hotel hotel2 = new BoutiqueHotel("Hotel Sahil", "Istanbul", 4);
            Hotel hotel3 = new ResortHotel("Dragos Resort", "Istanbul", 3);
            Hotel hotel4 = new SuiteHotel("Hotel Ramada", "Istanbul", 4);
            Hotel hotel5 = new LuxuryHotel("Hilton Istanbul", "Istanbul", 5);

            Hotel hotel6 = new LuxuryHotel("Swiss", "Izmir", 5);
            Hotel hotel7 = new ResortHotel("Hotel Ilica", "Izmir", 5);
            Hotel hotel8 = new BoutiqueHotel("Sc Inn", "Izmir", 3);
            Hotel hotel9 = new BusinessHotel("Ege Palas", "Izmir", 4);

            elTuristiko.AddHotel(hotel1);
            elTuristiko.AddHotel(hotel2);
            elTuristiko.AddHotel(hotel3);
            elTuristiko.AddHotel(hotel4);
            elTuristiko.AddHotel(hotel5);
            elTuristiko.AddHotel(hotel6);
            elTuristiko.AddHotel(hotel7);
            elTuristiko.AddHotel(hotel8);
            elTuristiko.AddHotel(hotel9);

            AddRoomsRandom(hotel1, 24);
            AddRoomsRandom(hotel2, 20);
            AddRoomsRandom(hotel3, 36);
            AddRoomsRandom(hotel4, 72);
            AddRoomsRandom(hotel5, 96);

            AddRoomsRandom(hotel6, 80);
            AddRoomsRandom(hotel7, 48);
            AddRoomsRandom(hotel8, 32);
            AddRoomsRandom(hotel9, 84);


            /*foreach (Hotel hotel in elTuristiko.hotels)
            {
                textBox1.Text += hotel.Name + "\r\n";
                foreach (Room r in hotel.rooms)
                {
                    textBox1.Text += (r.No + "\t" + r.Price + "\t" + r.GetType()).ToString() + "\t" + r.HasAC + "\t" + r.HasBalcony
                        + "\t" + r.HasMinibar + "\t" + r.HasSeaView + "\t" + r.HasTV + "\r\n";
                }
            }*/

        }

        private void AddRoomsRandom(Hotel hotel, int n)
        {

            double rnd_number;

            for (int i = 1, j = 100; i <= n; i++)
            {
                if (i % 10 == 0)
                {
                    j += 100;
                }
                rnd_number = random.NextDouble();
                if (rnd_number < 0.15)
                {
                    hotel.AddRoom(new SingleRoom(j + i % 10, random.Next(60, 150), random.NextDouble() >= 0.25,
                        random.NextDouble() >= 0.35, random.NextDouble() >= 0.5, random.NextDouble() >= 0.3, random.NextDouble() >= 0.3));
                }
                else if (rnd_number < 0.35)
                {
                    hotel.AddRoom(new DoubleRoom(j + i % 10, random.Next(100, 240), random.NextDouble() >= 0.25,
                        random.NextDouble() >= 0.35, random.NextDouble() >= 0.5, random.NextDouble() >= 0.3, random.NextDouble() >= 0.3));
                }
                else if (rnd_number < 0.70)
                {
                    hotel.AddRoom(new TwinRoom(j + i % 10, random.Next(120, 280), random.NextDouble() >= 0.25,
                        random.NextDouble() >= 0.35, random.NextDouble() >= 0.5, random.NextDouble() >= 0.3, random.NextDouble() >= 0.3));
                }
                else if (rnd_number < 0.90)
                {
                    hotel.AddRoom(new TripleRoom(j + i % 10, random.Next(140, 360), random.NextDouble() >= 0.25,
                        random.NextDouble() >= 0.35, random.NextDouble() >= 0.5, random.NextDouble() >= 0.3, random.NextDouble() >= 0.3));
                }
                else
                {
                    hotel.AddRoom(new KingRoom((j + i % 10) * 10, random.Next(4, 10), random.Next(480, 2200), true, true, true, true, true));
                }
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUserId.Text == String.Empty) { labelStarUserId.Visible = true; return; } else { labelStarUserId.Visible = false; }
            if(textBoxPassword.Text == String.Empty) { labelStarPassword.Visible = true; return; } else { labelStarPassword.Visible = false; }
            currentUser = elTuristiko.VerifyLogin(textBoxUserId.Text, textBoxPassword.Text);
            if (currentUser == null) { labelIdPwIncorrect.Visible = true; return; } else { labelIdPwIncorrect.Visible = false; }

            this.Hide();
            //giriş yapan kullanıcı admin ise admin paneline müşteri ise müşteri paneline yönlendirilecek..
            if (currentUser.GetType() == typeof(Customer))
            {
                //müşteri giriş yaptı..
                CustomerForm customerForm = new CustomerForm();
                customerForm.Show();
            }
            else
            {
                //admin giriş yaptı..              
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }

        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            //Kayıt olma formu açılacak..
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
