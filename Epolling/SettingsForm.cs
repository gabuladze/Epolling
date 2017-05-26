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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'epollingDataSet.candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.epollingDataSet.candidates);
            // TODO: This line of code loads data into the 'epollingDataSet.parties' table. You can move, or remove it, as needed.
            this.partiesTableAdapter.Fill(this.epollingDataSet.parties);

        }
    }
}
