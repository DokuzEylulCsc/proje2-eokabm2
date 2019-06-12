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
    internal partial class RegisterForm : Form
    {
        private ElTuristiko elTuristiko;
        private HotelReservationApp hotelReservationApp;
        internal RegisterForm()
        {
            InitializeComponent();
            elTuristiko = ElTuristiko.GetInstance();
            hotelReservationApp = HotelReservationApp.GetInstance();
        }
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    if (((TextBox)c).Text == String.Empty) { labelRequired.Visible = true; return; } else { labelRequired.Visible = false; }
                }
            }

            if(elTuristiko.AddCustomer(textBoxUserId.Text, textBoxPassword.Text, textBoxFName.Text + " " + textBoxLName.Text, textBoxAddress.Text, textBoxPhoneN.Text))
            {
                MessageBox.Show("Successfully registered.");
                AppLogs.WriteLog("(Register) New Customer Register. UserId: " + textBoxUserId.Text);
                this.Close();
                hotelReservationApp.Show();
            }
            else
            {
                MessageBox.Show("This username already exists.");
                return;
            }
            
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotelReservationApp.Show();
        }
    }
}
