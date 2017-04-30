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
        Form2 frm = new Form2();
        string[] currentUser = new string[3];

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Fetch textbox value
            currentUser = fetchUser(IdTextBox.Text);
            IdTextBox.Text = "";

            // show form2
            frm.Show();
            frm.FormClosed += frm_FormClosed;
            frm._nameTextbox = currentUser[1];
            frm._surnameTextbox = currentUser[2];

            Visible = false;
        }

        private void frm_FormClosed(object sender, EventArgs e)
        {
            Visible = true;
            Array.Clear(currentUser, 0, currentUser.Length);
        }

        private string[] fetchUser(string id)
        {
            string[] user = new string[4];
            XmlDocument users = new XmlDocument();
            users.Load("Users.xml");

            foreach (XmlNode node in users.DocumentElement)
            {
                if (node.Attributes[0].InnerText == id)
                {
                    user[0] = id;
                    user[1] = node.Attributes[1].InnerText;
                    user[2] = node.Attributes[2].InnerText;
                    user[3] = node.Attributes[3].InnerText;
                }
            }

            return user;
        }
    }
}
