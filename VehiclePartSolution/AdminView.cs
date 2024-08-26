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
    public partial class AdminView : Form
    {
        string connection_string;
        public AdminView()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["DB_Connection_String"].ConnectionString;
            loadCustomerCount();
            loadUserCount();
            loadCarCount();
            loadCarPartsCount(); 
            loadOrderCount(); 
        }

        private void loadCustomerCount()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "SELECT COUNT(*) FROM SYS_Users WHERE role = 2";
                SqlCommand command = new SqlCommand(query, connection);
               
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    lableCustomers.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close(); 
                }
            }
        }

        private void loadUserCount()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "SELECT COUNT(*) FROM SYS_Users WHERE role = 1";
                SqlCommand command = new SqlCommand(query, connection);
               
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    lableUsers.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void loadCarCount()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "SELECT SUM(stock) AS TotalStock FROM Cars";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    lableCars.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void loadCarPartsCount()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "SELECT SUM(stock) AS TotalStock FROM CarParts";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    lableCarPartsCount.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void loadOrderCount()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "SELECT COUNT(*) FROM Orders";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    lableOrderCount.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        

        private void btnCar_Click(object sender, EventArgs e)
        {
            CarManage car = new CarManage();
            car.Show();
            this.Hide();
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            CarPartsManage carParts = new CarPartsManage();
            carParts.Show();
            this.Hide();
        }

        private void btnLoginOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
