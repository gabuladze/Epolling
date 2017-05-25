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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int userId = checkUser(IdTextBox.Text);
            if (userId > 0)
            {
                Form2 frm = new Form2(userId);
                // show form2
                frm.FormClosed += frm_FormClosed;
                frm.Show();

                IdTextBox.Text = "";
                Visible = false;
            } else
            {
                MessageBox.Show("Invalid id!");
            }
        }

        private void frm_FormClosed(object sender, EventArgs e)
        {
            Visible = true;
        }

        private int checkUser(string id)
        {
            int userId = 0;
            string constring = @"Data Source=THINKCENTRE\SQLEXPRESS;Initial Catalog=Epolling;Integrated Security=true";
            using (SqlConnection ConnectToDB = new SqlConnection(constring))
            {
                using (SqlCommand DBCommand = new SqlCommand("SELECT * FROM users WHERE id_number = @UserIdNumber", ConnectToDB))
                {
                    DBCommand.Parameters.AddWithValue("@UserIdNumber", IdTextBox.Text);

                    ConnectToDB.Open();

                    using (SqlDataReader reader = DBCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            if (reader.GetInt32(reader.GetOrdinal("voting_completed")) == 0)
                            {
                                userId = reader.GetInt32(reader.GetOrdinal("id"));
                            }
                            else
                            {
                                MessageBox.Show("You have already voted!");
                            }
                        }
                    }

                    ConnectToDB.Close();
                }
            }
            return userId;
        }
    }
}
