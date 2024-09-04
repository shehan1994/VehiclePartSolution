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
    public partial class UserManage : Form
    {
        private string connection_string;
        private int user_id = 0;
        public UserManage()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["DB_Connection_String"].ConnectionString;
            LoadUsers();
            GridViewUsers.CellClick += GridViewUsers_CellClick;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp); 
        }

        private void ClearFields()
        {
            txtUsername.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSearch.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnRegister.Visible = true;
        }

        private void LoadUsers()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "SELECT user_id,username, role, first_name, last_name, email, phone_number, address from SYS_Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable userListTable = new DataTable();
                adapter.Fill(userListTable);


                if (userListTable != null && userListTable.Rows.Count > 0)
                {

                    foreach (DataRow row in userListTable.Rows)
                    {
                        if (row["role"] != DBNull.Value)
                        {
                            int role = Convert.ToInt32(row["role"]);
                            row["role"] = role == 1 ? "Admin" : (role == 2 ? "Customer" : "Unknown");
                        }
                    }

                    GridViewUsers.DataSource = userListTable;
                    GridViewUsers.Columns["user_id"].HeaderText = "User ID";
                    GridViewUsers.Columns["user_id"].Width = 50;
                    GridViewUsers.Columns["username"].HeaderText = "User Name";
                    GridViewUsers.Columns["username"].Width = 100;
                    GridViewUsers.Columns["role"].HeaderText = "Role";
                    GridViewUsers.Columns["first_name"].HeaderText = "First Name";
                    GridViewUsers.Columns["first_name"].Width = 200;
                    GridViewUsers.Columns["last_name"].HeaderText = "Last Name";
                    GridViewUsers.Columns["last_name"].Width = 200;
                    GridViewUsers.Columns["email"].HeaderText = "Email";
                    GridViewUsers.Columns["phone_number"].HeaderText = "Phone No.";
                    GridViewUsers.Columns["address"].HeaderText = "Address";
                    GridViewUsers.Columns["address"].Width = 300;
                }
                else
                {
                    // Handle the case where there are no records
                    MessageBox.Show("No order history found for this customer.");
                }
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = txtSearch.Text.Trim();
            DataTable carTable = (DataTable)GridViewUsers.DataSource;

            if (carTable != null)
            {
                if (string.IsNullOrEmpty(filterText))
                {
                    carTable.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    string rowFilter = $"Convert(username, 'System.String') LIKE '%{filterText}%' " +
                                  $"OR Convert(first_name, 'System.String') LIKE '%{filterText}%'" +
                                  $"OR Convert(last_name, 'System.String') LIKE '%{filterText}%'" +
                                  $"OR Convert(address, 'System.String') LIKE '%{filterText}%'" +
                                  $"OR Convert(phone_number, 'System.String') LIKE '%{filterText}%'" +
                                  $"OR Convert(role, 'System.String') LIKE '%{filterText}%'" +
                                  $"OR Convert(email, 'System.String') LIKE '%{filterText}%'";
                    carTable.DefaultView.RowFilter = rowFilter;
                }
            }
        }

        private void GridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = GridViewUsers.Rows[e.RowIndex];
                user_id = int.Parse(selectedRow.Cells[0].Value?.ToString());
                txtUsername.Text = selectedRow.Cells[1].Value?.ToString();
                txtFirstName.Text = selectedRow.Cells[3].Value?.ToString();
                txtLastName.Text = selectedRow.Cells[4].Value?.ToString();
                txtEmail.Text = selectedRow.Cells[5].Value?.ToString();
                txtPhone.Text = selectedRow.Cells[6].Value?.ToString();
                txtAddress.Text = selectedRow.Cells[7].Value?.ToString();
                btnClear.Visible = true;
                btnDelete.Visible = true;
                btnEdit.Visible = true;
                btnRegister.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminView admin = new AdminView();
            admin.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (user_id == null || user_id == 0)
            {
                MessageBox.Show("Please select a User to edit.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE SYS_Users SET username = @username, first_name = @first_name, last_name = @last_name, email = @email, phone_number = @phone_number, address= @address  WHERE user_id = @user_id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", user_id);
                        command.Parameters.AddWithValue("@username", txtUsername.Text);
                        command.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                        command.Parameters.AddWithValue("@last_name", txtLastName.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.Parameters.AddWithValue("@phone_number", txtPhone.Text);
                        command.Parameters.AddWithValue("@address", txtAddress.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Car edited successfully!");
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }
    }
}
