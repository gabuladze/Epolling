using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epolling
{
    public partial class Form2 : Form
    {
        string[] currentUser = new string[4];

        public Form2(string[] user)
        {
            currentUser = user;

            InitializeComponent();

            // Display user info
            nameTextbox.Text = currentUser[1];
            surnameTextbox.Text = currentUser[2];
            IdTextbox.Text = currentUser[0];

            // Load candidates
            candidatesListBox.DataSource = Candidates.Load();

            // Hide or show the settings button
            settingsButton.Visible = currentUser[3] == "admin" ? true : false;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.Show();
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(candidatesListBox.SelectedItem.ToString());
        }
    }
}
