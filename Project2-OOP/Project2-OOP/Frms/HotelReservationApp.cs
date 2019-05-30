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
        

        public HotelReservationApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            Form Customer = new Frms.Frm_Customer();
            Customer.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Form Admin = new Frms.Frm_Admin();
            Admin.Show();
        }
    }
}
