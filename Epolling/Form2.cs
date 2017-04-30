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
        public Form2()
        {
            InitializeComponent();
        }

        public string _nameTextbox
        {
            get { return nameTextbox.Text; }
            set { nameTextbox.Text = value; }
        }

        public string _surnameTextbox
        {
            get { return surnameTextbox.Text; }
            set { surnameTextbox.Text = value; }
        }
    }
}
