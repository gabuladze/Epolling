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
    public partial class LoginForm : Form
    {
        string[] currentUser = new string[3];

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Fetch textbox value
            string userId = IdTextBox.Text;
            XmlDocument users = new XmlDocument();
            users.Load("Users.xml");

            foreach (XmlNode node in users.DocumentElement)
            {
                string id = node.Attributes[0].InnerText;
                if (id == userId)
                {
                    currentUser[0] = id;
                    currentUser[1] = node.Attributes[1].InnerText;
                    currentUser[2] = node.Attributes[2].InnerText;
                }
            }

            // show form2
            Form2 frm = new Form2();
            frm.Show();
            frm._nameTextbox = currentUser[1];
            frm._surnameTextbox = currentUser[2];

            Visible = false;
        }
    }
}
