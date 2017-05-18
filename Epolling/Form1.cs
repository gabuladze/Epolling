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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(fetchUser(IdTextBox.Text));
            // show form2
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

            return user;
        }
    }
}
