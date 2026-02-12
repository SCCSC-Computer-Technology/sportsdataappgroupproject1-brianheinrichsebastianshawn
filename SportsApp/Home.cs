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
            this.Controls.Add(registrationControl);

            registrationControl.BringToFront();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            // take text from email box
            String email = emailTextbox.Text;

            // take text from password box
            String password = passwordTextbox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter email and password.");
                return;
            }

            // check to see if email or password are in User table

        }
    }
}
