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

        public string[] _currentUser
        {
            get { return currentUser; }
            set {
                currentUser = value;
                nameTextbox.Text = currentUser[1];
                surnameTextbox.Text = currentUser[2];
                IdTextbox.Text = currentUser[3];
            }
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
