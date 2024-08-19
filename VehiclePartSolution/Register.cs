using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehiclePartSolution
{
    public partial class Register : Form
    {
        string connection_string;

        public Register()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["DB_Connection_String"].ConnectionString;


            comboRole.Items.Add("Admin");
            comboRole.Items.Add("Customer");
            comboRole.SelectedIndex = 0;
        }

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phNum = txtPhone.Text;
            string address = txtAddress.Text;

            string selectedValue = comboRole.SelectedItem.ToString();
            string roleValue = "";
            if (selectedValue == "Admin")
            {
                roleValue = "1";
                MessageBox.Show("Please contact Admin");
                return;
            }
            else if (selectedValue == "Customer")
            {
                roleValue = "2";
            }

            // Check if the username or password fields are empty
            if (
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phNum) ||
                string.IsNullOrWhiteSpace(address) ||
                roleValue == "")
            {
                MessageBox.Show("Please required all the fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "INSERT INTO SYS_Users (username, password, role, first_name, last_name, email, phone_number, address) " +
                               "VALUES (@username, @password, @role, @firstName, @lastName, @email, @phone, @address)";
                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", roleValue);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", phNum);
                command.Parameters.AddWithValue("@address", address);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("User registed successfully! Please Login to continue.");
                        Login login = new Login();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No rows inserted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
