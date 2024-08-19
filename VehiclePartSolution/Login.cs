using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace VehiclePartSolution
{
    public partial class Login : Form
    {

        string connection_string;

        public Login()
        {
            InitializeComponent();

            connection_string = ConfigurationManager.ConnectionStrings["DB_Connection_String"].ConnectionString;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txt_username.Text;
            password = txt_password.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Both username and password required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM SYS_Users WHERE username  = @username AND password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("user_id"));
                            string fullName = reader["first_name"].ToString() + ' ' + reader["last_name"].ToString();
                            string role = reader.GetString(reader.GetOrdinal("role"));

                            LoggerSession.full_name = fullName;
                            LoggerSession.user_id = userId;
                            LoggerSession.role = role;

                            if (role == "1")
                            {
                                MessageBox.Show($"You are logged in as Admin.");
                                AdminView adminview = new AdminView();
                                adminview.Show();
                            }
                            else if (role == "2")
                            {
                                CustomerView customerview = new CustomerView();
                                customerview.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Register register =  new Register();
            register.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
