using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportsApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationControl registrationControl = new RegistrationControl();

            registrationControl.Dock = DockStyle.Fill;  // makes it fill the form

            this.Controls.Add(registrationControl);

            registrationControl.BringToFront();
        }
    }
}
