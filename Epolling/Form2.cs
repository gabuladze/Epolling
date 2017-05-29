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
    public partial class Form2 : Form
    {
        int currentUserId = new int();

        public Form2(int userId)
        {
            currentUserId = userId;

            InitializeComponent();

            string constring = @"Data Source=THINKCENTRE\SQLEXPRESS;Initial Catalog=Epolling;Integrated Security=true";
            using (SqlConnection ConnectToDB = new SqlConnection(constring))
            {
                using (SqlCommand DBCommand = new SqlCommand("SELECT u.id as id, u.id_number as idnum, u.first_name as fname, u.last_name as lname, r.name as role FROM users u JOIN user_roles r ON u.role_id = r.id WHERE u.id = @CurrentUserId", ConnectToDB))
                {
                    DBCommand.Parameters.AddWithValue("@CurrentUserId", currentUserId);

                    ConnectToDB.Open();

                    using (SqlDataReader reader = DBCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {                        
                            // Display user info
                            nameTextbox.Text = reader.GetString(reader.GetOrdinal("fname"));
                            surnameTextbox.Text = reader.GetString(reader.GetOrdinal("lname"));
                            IdTextbox.Text = reader.GetString(reader.GetOrdinal("idnum"));

                            // Hide or show the settings button
                            settingsButton.Visible = reader.GetString(reader.GetOrdinal("role")) == "admin" ? true : false;
                        }
                    }

                    ConnectToDB.Close();
                }

                SqlCommand cmd = new SqlCommand("SELECT c.id, concat(c.name, ', ', p.name) as name FROM candidates c JOIN parties p ON c.party_id = p.id", ConnectToDB);
                DataSet candidatesDataSet = new DataSet();
                candidatesDataSet.Tables.Add("candidates");
                SqlDataAdapter candidatesDataAdapter = new SqlDataAdapter(cmd);

                SqlCommandBuilder sqb = new SqlCommandBuilder(candidatesDataAdapter);

                candidatesDataAdapter.Fill(candidatesDataSet, "candidates");
                candidatesListBox.DataSource = candidatesDataSet.Tables["candidates"];

                candidatesListBox.DisplayMember = "name";
                candidatesListBox.ValueMember = "id";
            }


        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.Show();
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            string candidateId = candidatesListBox.SelectedValue.ToString();

            string constring = @"Data Source=THINKCENTRE\SQLEXPRESS;Initial Catalog=Epolling;Integrated Security=true";
            using (SqlConnection ConnectToDB = new SqlConnection(constring))
            {
                using (SqlCommand DBCommand = new SqlCommand("UPDATE candidates SET votes = votes + 1 WHERE id = @CandidateId", ConnectToDB))
                {
                    DBCommand.Parameters.AddWithValue("@CandidateId", candidateId);

                    ConnectToDB.Open();
                    DBCommand.ExecuteNonQuery();
                    ConnectToDB.Close();
                }

                using (SqlCommand DBCommand = new SqlCommand("UPDATE users SET voting_completed = 1 WHERE id = @CurrentUserId", ConnectToDB))
                {
                    DBCommand.Parameters.AddWithValue("@CurrentUserId", currentUserId);

                    ConnectToDB.Open();
                    DBCommand.ExecuteNonQuery();
                    ConnectToDB.Close();
                }
            }

            MessageBox.Show("Your vote has been submitted! You will be logged out from the system.");
            this.Close();
        }
    }
}
