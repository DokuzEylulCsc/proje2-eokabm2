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
    internal partial class CustomerForm : Form
    {
        private User currentUser;
        internal CustomerForm()
        {
            InitializeComponent();
        }

        internal User CurrentUser { get => currentUser; set => currentUser = value; }
    }
}
