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
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.Show();
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(candidatesListBox.SelectedItem.ToString());
        }
    }
}
