using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehiclePartSolution
{
    public partial class CarPartsManage : Form
    {
        private string connection_string;
        private int part_id = 0;

        public CarPartsManage()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["DB_Connection_String"].ConnectionString;
            LoadCar();
            LoadParts();
            ClearFields();
            GridViewCarParts.CellClick += GridViewCarParts_CellClick;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);

        }

        private void ClearFields()
        {
            txtPartName.Text = string.Empty;
            txtRemark.Text = string.Empty;
            txtSearch.Text = string.Empty;
            numPrice.Value = numPrice.Minimum;
            numStock.Value = numStock.Minimum;
            comboBoxCar.SelectedIndex = -1;
            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;
        }

        private void LoadCar()
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

                        comboBoxCar.DisplayMember = "CarValues";
                        comboBoxCar.ValueMember = "car_id";

                        // Create a new DataColumn to hold the combined Make and Model
                        carTable.Columns.Add("CarValues", typeof(string), "Brand + ' ' + Model");

                        comboBoxCar.DataSource = carTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadParts()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    string query = "SELECT * FROM CarParts";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable carsList = new DataTable();
                    adapter.Fill(carsList);

                    carsList.Columns.Add("Car", typeof(string));

                    foreach (DataRow row in carsList.Rows)
                    {
                        try
                        {
                            int car_id = Convert.ToInt32(row["car_id"]);

                            string carQuery = "SELECT brand, model FROM Cars WHERE car_id = @car_id";
                            using (SqlCommand command = new SqlCommand(carQuery, connection))
                            {
                                command.Parameters.AddWithValue("@car_id", car_id);
                                connection.Open();
                                SqlDataReader reader = command.ExecuteReader();
                                if (reader.Read())
                                {
                                    string make = reader["brand"].ToString();
                                    string model = reader["model"].ToString();
                                    row["Car"] = make + " " + model;
                                }
                                reader.Close();
                                connection.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while retrieving Part details: " + ex.Message);
                            connection.Close();
                        }
                    }

                    GridViewCarParts.DataSource = carsList;

                    GridViewCarParts.Columns["car_id"].Visible = false;
                    GridViewCarParts.Columns["part_id"].Visible = false;

                    GridViewCarParts.Columns["part_name"].HeaderText = "Part Name"; 
                    GridViewCarParts.Columns["part_name"].Width = 200;
                    GridViewCarParts.Columns["price"].HeaderText = "Price";
                    GridViewCarParts.Columns["stock"].HeaderText = "Stock";
                    GridViewCarParts.Columns["remark"].HeaderText = "Remark";
                    GridViewCarParts.Columns["remark"].Width = 200;

                    if (GridViewCarParts.Columns["Car"] != null)
                    {
                        GridViewCarParts.Columns["Car"].Visible = true;
                        GridViewCarParts.Columns["Car"].HeaderText = "Car";
                        GridViewCarParts.Columns["Car"].Width = 150;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading car parts data: " + ex.Message);
                    connection.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (numStock.Value == 0)
            {
                MessageBox.Show("Please select quantity");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO CarParts ( car_id, part_name, price,stock, remark) VALUES (@car_id,@partName, @price, @stock,@remark)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@car_id", comboBoxCar.SelectedValue);
                        command.Parameters.AddWithValue("@partName", txtPartName.Text );
                        command.Parameters.AddWithValue("@price", numPrice.Value);
                        command.Parameters.AddWithValue("@stock", numStock.Value);
                        command.Parameters.AddWithValue("@remark", txtRemark.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Car Part successfully created!");
                        ClearFields();
                        LoadParts(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void GridViewCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = GridViewCarParts.Rows[e.RowIndex];
                part_id = int.Parse(selectedRow.Cells[0].Value?.ToString());
                txtPartName.Text = selectedRow.Cells[2].Value?.ToString();
                comboBoxCar.SelectedValue = Convert.ToInt32(selectedRow.Cells[1].Value);
                numPrice.Value = Convert.ToDecimal(selectedRow.Cells[3].Value);
                numStock.Value = Convert.ToInt32(selectedRow.Cells[4].Value);
                txtRemark.Text = selectedRow.Cells[5].Value?.ToString();
                btnClear.Visible = true;
                btnDelete.Visible = true;
                btnEdit.Visible = true;
                btnSave.Visible = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE CarParts SET part_name = @partName, car_id = @car_id, price = @price, stock = @stock, remark = @remark WHERE part_id = @part_id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@partName", txtPartName.Text);
                        command.Parameters.AddWithValue("@car_id", comboBoxCar.SelectedValue);
                        command.Parameters.AddWithValue("@price", numPrice.Value);
                        command.Parameters.AddWithValue("@stock", numStock.Value);
                        command.Parameters.AddWithValue("@remark", txtRemark.Text);
                        command.Parameters.AddWithValue("@part_id", part_id);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Car Part edited successfully!");
                        ClearFields();
                        LoadParts();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }

        private void txtSearch_KeyUp(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();
            DataTable carTable = (DataTable)GridViewCarParts.DataSource;

            if (string.IsNullOrEmpty(filterText))
            {
                carTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string rowFilter = $"Convert(part_name, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(price, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Car, 'System.String') LIKE '%{filterText}%'";
                carTable.DefaultView.RowFilter = rowFilter;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
