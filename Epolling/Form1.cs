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

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // show form2
            frm._currentUser = fetchUser(IdTextBox.Text);
            frm.FormClosed += frm_FormClosed;
            frm.Show();

            IdTextBox.Text = "";
            Visible = false;
        }

        private void frm_FormClosed(object sender, EventArgs e)
        {
            Visible = true;
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
