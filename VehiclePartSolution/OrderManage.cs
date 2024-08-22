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
    public partial class OrderManage : Form
    {
        private string connection_string;
        public OrderManage()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["DB_Connection_String"].ConnectionString;
            LoadCarInCars();
            LoadCarInParts();
            ClearFields();
            comboBoxCarInParts.SelectedIndexChanged += new EventHandler(comboBoxCarInParts_SelectedIndexChanged);
            comboBoxCarInCar.SelectedIndexChanged += new EventHandler(comboBoxCarInCar_SelectedIndexChanged); 
            comboBoxParts.SelectedIndexChanged += new EventHandler(comboBoxParts_SelectedIndexChanged);
        }

        private void ClearFields()
        {
           /* txtPartName.Text = string.Empty;
            txtRemark.Text = string.Empty;
            txtSearch.Text = string.Empty;
            numPrice.Value = numPrice.Minimum;
            numStock.Value = numStock.Minimum;
            comboBoxCar.SelectedIndex = -1;
            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;*/
        }

        private void LoadCarInCars()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Cars";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable carTable = new DataTable();
                        carTable.Load(reader);

                        comboBoxCarInCar.DisplayMember = "CarValues";
                        comboBoxCarInCar.ValueMember = "car_id";

                        carTable.Columns.Add("CarValues", typeof(string), "Brand + ' ' + Model");

                        comboBoxCarInCar.DataSource = carTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadCarInParts()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Cars";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable carPartTable = new DataTable();
                        carPartTable.Load(reader);

                        comboBoxCarInParts.DisplayMember = "CarValues";
                        comboBoxCarInParts.ValueMember = "car_id";

                        carPartTable.Columns.Add("CarValues", typeof(string), "Brand + ' ' + Model");

                        comboBoxCarInParts.DataSource = carPartTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void comboBoxCarInCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCarInCar.SelectedValue != null)
            {
                int carId = (int)comboBoxCarInCar.SelectedValue;
                CarViewTextFill(carId);
            }
        }

        private void CarViewTextFill(int car_id)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT year, price, model, stock FROM Cars WHERE car_id = " + car_id + "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtModelInCar.Text = reader["model"].ToString();
                                numPriceInCar.Text = reader["price"].ToString();
                                txtYearInCar.Text = reader["year"].ToString();
                                numAvailableStockInCar.Text = reader["stock"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified Car.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void comboBoxParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxParts.SelectedValue != null)
            {
                int part_id = (int)comboBoxParts.SelectedValue;
                PartsViewTextFill(part_id);
            }
        }

        private void PartsViewTextFill(int part_id)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT part_name, price, stock, remark FROM CarParts WHERE part_id = " + part_id + "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                numPriceInParts.Text = reader["price"].ToString();
                                numAvailableStockInParts.Text = reader["stock"].ToString();
                                txtRemarkInParts.Text = reader["remark"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified Car.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void comboBoxCarInParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCarInParts.SelectedValue != null)
            {
                int carId = (int)comboBoxCarInParts.SelectedValue;
                LoadPartsData(carId);
            }
        }

        private void LoadPartsData(int car_id)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT part_id, part_name FROM CarParts WHERE car_id = " + car_id + "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable carPartTable = new DataTable();
                        carPartTable.Load(reader);

                        comboBoxParts.DisplayMember = "part_name";
                        comboBoxParts.ValueMember = "part_id";
                        comboBoxParts.DataSource = carPartTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
