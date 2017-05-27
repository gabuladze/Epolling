using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Epolling
{
    public partial class SettingsForm : Form
    {
        string status = "";
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'epollingDataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.epollingDataSet1.users);
            // TODO: This line of code loads data into the 'epollingDataSet1.user_roles' table. You can move, or remove it, as needed.
            this.user_rolesTableAdapter.Fill(this.epollingDataSet1.user_roles);
            // TODO: This line of code loads data into the 'epollingDataSet.candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.epollingDataSet.candidates);
            // TODO: This line of code loads data into the 'epollingDataSet.parties' table. You can move, or remove it, as needed.
            this.partiesTableAdapter.Fill(this.epollingDataSet.parties);

            string constring = @"Data Source=THINKCENTRE\SQLEXPRESS;Initial Catalog=Epolling;Integrated Security=true";
            using (SqlConnection ConnectToDB = new SqlConnection(constring))
            {
                using (SqlCommand DBCommand = new SqlCommand("SELECT value FROM settings WHERE name='status'", ConnectToDB))
                {
                    ConnectToDB.Open();

                    using (SqlDataReader reader = DBCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            status = reader.GetString(reader.GetOrdinal("value"));
                        }
                    }

                    ConnectToDB.Close();
                }
            }

            electionStatus.Text = (status == "1") ? "Completed" : "Ongoing";

        }

        private void saveCandidatesButton_Click(object sender, EventArgs e)
        {
            candidatesBindingSource.EndEdit();
            candidatesTableAdapter.Update(epollingDataSet.candidates);
            MessageBox.Show("Candidates have been updated!");
        }

        private void savePartiesButton_Click(object sender, EventArgs e)
        {
            partiesBindingSource.EndEdit();
            partiesTableAdapter.Update(epollingDataSet.parties);
            MessageBox.Show("Parties have been updated!");
        }

        private void toggleElectionStatusButton_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=THINKCENTRE\SQLEXPRESS;Initial Catalog=Epolling;Integrated Security=true";
            using (SqlConnection ConnectToDB = new SqlConnection(constring))
            {
                using (SqlCommand DBCommand = new SqlCommand("UPDATE settings SET value=@Value WHERE name='state'", ConnectToDB))
                {
                    string value = (status == "1") ? "0" : "1";
                    DBCommand.Parameters.AddWithValue("@Value", value);

                    ConnectToDB.Open();
                    DBCommand.ExecuteNonQuery();
                    ConnectToDB.Close();
                }
            }
            electionStatus.Text = (status == "1") ? "Ongoing" : "Completed";
            status = (status == "1") ? "0" : "1";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.candidatesTableAdapter.FillBy(this.epollingDataSet.candidates);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void saveUserRolesButton_Click(object sender, EventArgs e)
        {
            userrolesBindingSource.EndEdit();
            user_rolesTableAdapter.Update(epollingDataSet.user_roles);
            MessageBox.Show("User roles have been updated!");
        }

        private void saveUsersButton_Click(object sender, EventArgs e)
        {
            usersBindingSource.EndEdit();
            usersTableAdapter.Update(epollingDataSet.users);
            MessageBox.Show("Users have been updated!");
        }
    }
}
