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
        public UserManage()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["DB_Connection_String"].ConnectionString;
            LoadUsers();
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
        }

        private void LoadUsers()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "SELECT username, role, first_name, last_name, email, phone_number, address from SYS_Users";
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


        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminView admin = new AdminView();
            admin.Show();
            this.Close();
        }
    }
}
