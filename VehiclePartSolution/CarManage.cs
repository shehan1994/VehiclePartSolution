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
    public partial class CarManage : Form
    {
        string connection_string;
        private int car_id = 0;
        public CarManage()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["DB_Connection_String"].ConnectionString;
            LoadCars(); 
            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            GridViewCars.CellClick += CarsGridView_CellClick; 
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);

        }

        private void ClearFields()
        {
            txtBrand.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtSearch.Text = string.Empty;
            numPrice.Value = numPrice.Minimum;
            numStock.Value = numStock.Minimum;
            txtYear.Text = string.Empty;
            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;
        }

        private void LoadCars()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "SELECT * FROM Cars";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable carListTable = new DataTable();
                adapter.Fill(carListTable);
                GridViewCars.DataSource = carListTable;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Cars (brand, model, year, price, stock) VALUES (@brand, @model, @year, @price, @stock)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@brand", txtBrand.Text);
                        command.Parameters.AddWithValue("@model", txtModel.Text);
                        command.Parameters.AddWithValue("@year", txtYear.Text);
                        command.Parameters.AddWithValue("@price", numPrice.Value);
                        command.Parameters.AddWithValue("@stock", numStock.Value);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Car added successfully!");
                        ClearFields();
                        LoadCars();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void CarsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = GridViewCars.Rows[e.RowIndex];
                car_id = int.Parse(selectedRow.Cells[0].Value?.ToString());
                txtBrand.Text = selectedRow.Cells[1].Value?.ToString();
                txtModel.Text = selectedRow.Cells[2].Value?.ToString();
                txtYear.Text = selectedRow.Cells[3].Value?.ToString();
                numPrice.Value = Convert.ToDecimal(selectedRow.Cells[4].Value);
                numStock.Value = Convert.ToInt32(selectedRow.Cells[5].Value);
                btnClear.Visible = true;
                btnDelete.Visible = true;
                btnEdit.Visible = true;
                btnSave.Visible = false;
            }
        }

        private void GridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (car_id == null || car_id == 0)
            {
                MessageBox.Show("Please select a car to edit.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Cars SET brand = @brand, model = @model, year = @year, price = @price, stock = @stock WHERE car_id = @car_id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@brand", txtBrand.Text);
                        command.Parameters.AddWithValue("@model", txtModel.Text);
                        command.Parameters.AddWithValue("@year", txtYear.Text);
                        command.Parameters.AddWithValue("@price", numPrice.Value);
                        command.Parameters.AddWithValue("@stock", numStock.Value);
                        command.Parameters.AddWithValue("@car_id", car_id);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Car edited successfully!");
                        ClearFields();
                        LoadCars(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = txtSearch.Text.Trim();
            DataTable carTable = (DataTable)GridViewCars.DataSource;

            if (carTable != null)
            {
                if (string.IsNullOrEmpty(filterText))
                {
                    carTable.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    // Assuming column names in DataTable are: "brand", "model", "year", "price", "stock"
                    string rowFilter = $"Convert(car_id, 'System.String') LIKE '%{filterText}%' " +
                                  $"OR Convert(brand, 'System.String') LIKE '%{filterText}%'" +
                                  $"OR Convert(model, 'System.String') LIKE '%{filterText}%'" +
                                  $"OR Convert(price, 'System.String') LIKE '%{filterText}%'" +
                                  $"OR Convert(stock, 'System.String') LIKE '%{filterText}%'" +
                                  $"OR Convert(year, 'System.String') LIKE '%{filterText}%'";
                    carTable.DefaultView.RowFilter = rowFilter;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
