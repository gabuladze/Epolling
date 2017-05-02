using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Epolling
{
    public partial class Form2 : Form
    {
        string[] currentUser = new string[4];


        public string[] _currentUser
        {
            get { return currentUser; }
            set {
                currentUser = value;
                nameTextbox.Text = currentUser[1];
                surnameTextbox.Text = currentUser[2];
                IdTextbox.Text = currentUser[0];
            }
        }

        private void LoadCandidates()
        {
            XmlDocument candidates = new XmlDocument();
            candidates.Load("Candidates.xml");

            foreach (XmlNode node in candidates.DocumentElement)
            {
                candidatesListBox.Items.Add(node.Attributes[1].InnerText);
            }
        }

        public Form2()
        {
            InitializeComponent();
            LoadCandidates();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.Show();
        }
    }
}
