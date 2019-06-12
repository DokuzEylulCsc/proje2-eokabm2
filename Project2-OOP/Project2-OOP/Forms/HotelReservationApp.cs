using System;
using System.IO;
using System.Windows.Forms;

namespace Project2_OOP
{
    public partial class HotelReservationApp : Form
    {
        private ElTuristiko elTuristiko = ElTuristiko.GetInstance();
        private static AppDate appDate = AppDate.GetInstance();
        internal static User currentUser;
        private static Random random = new Random();
        private static HotelReservationApp hotelReservationApp = new HotelReservationApp();
        private XXmlClass a;
        
        private HotelReservationApp()
        {
            InitializeComponent();
            a = new XXmlClass();
            InitializeFiles();
        }

        public static HotelReservationApp GetInstance() { return hotelReservationApp; }

        private void HotelReservationApp_Load(object sender, EventArgs e)
        {

        }

        private void InitializeFiles() 
        {
            appDate.Date = DateTime.Now;

            //elTuristiko.AddUser(new Administrator("admin", "123456"));
            //elTuristiko.AddUser(new Customer("eminozk", "123456", "Emin Özkaradeniz", "Bucca", "5055050"));
            //elTuristiko.AddUser(new Customer("abmogol", "123456", "Ahmet Buğra Moğol", "Bucca", "232323"));
            //elTuristiko.AddUser(new Customer("a", "a", "aa", "aa", "aa"));

            a.xReadHotel();
            a.xReadUsers();
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
                    hotel.AddRoom(new KingRoom((j + i % 10) * 10, random.Next(4, 6), random.Next(480, 2200), true, true, true, true, true));
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
                customerForm.CurrentUser = (Customer)currentUser;
                customerForm.Show();
            }
            else
            {
                //admin giriş yaptı..              
                AdminForm adminForm = new AdminForm();
                adminForm.CurrentUser = (Administrator)currentUser;
                adminForm.Show();
            }

            //
            string s = currentUser.ToString() + " signed in.";
            AppLogs.WriteLog(s);
            //

        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void HotelReservationApp_FormClosing(object sender, FormClosingEventArgs e) //program kapanırken gerekli işlemler yapılıcak.
        {
            //MessageBox.Show("Thanks for using.");
            a.xWriteHotel();
            a.xWriteUser(elTuristiko.Users);
            AppLogs.Sr.Close();
        }

    }
}
