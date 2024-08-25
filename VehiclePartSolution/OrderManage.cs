using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            InitializeDataGridView();
            LoadCarInCars();
            LoadCarInParts();
            ClearCarSideFields();
            ClearPartsSideFields();
            comboBoxCarInParts.SelectedIndexChanged += new EventHandler(comboBoxCarInParts_SelectedIndexChanged);
            comboBoxCarInCar.SelectedIndexChanged += new EventHandler(comboBoxCarInCar_SelectedIndexChanged); 
            comboBoxParts.SelectedIndexChanged += new EventHandler(comboBoxParts_SelectedIndexChanged);

        }

        private void ClearCarSideFields()
        {
            txtModelInCar.Text = string.Empty;
            numPriceInCar.Value = numPriceInCar.Minimum;
            txtYearInCar.Text = string.Empty;
            numAvailableStockInCar.Value = numAvailableStockInCar.Minimum;
            numOrderStockInCar.Value = numOrderStockInCar.Minimum;

        }

        private void ClearPartsSideFields()
        {
            numPriceInParts.Value = numPriceInParts.Minimum;
            numAvailableStockInParts.Value = numAvailableStockInParts.Minimum;
            txtRemarkInParts.Text = string.Empty;
            comboBoxParts.SelectedIndex = -1;
            numOrderStockInParts.Value = numOrderStockInParts.Minimum;
        }

        private void InitializeDataGridView()
        {
            dataGridViewCarParts.ColumnCount = 8;
            dataGridViewCarParts.Columns[0].Name = "Item";
            dataGridViewCarParts.Columns[1].Name = "Description";
            dataGridViewCarParts.Columns[2].Name = "Price";
            dataGridViewCarParts.Columns[3].Name = "Quantity";
            dataGridViewCarParts.Columns[4].Name = "Subtotal";
            dataGridViewCarParts.Columns[5].Name = "ItemCode";
            dataGridViewCarParts.Columns["ItemCode"].Visible = false;
            dataGridViewCarParts.Columns[6].Name = "ItemType";
            dataGridViewCarParts.Columns["ItemType"].Visible = false;
            dataGridViewCarParts.Columns[7].Name = "ItemTypeId";
            dataGridViewCarParts.Columns["ItemTypeId"].Visible = false;
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

        private void CalculateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridViewCarParts.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            txtNetTotal.Text = total.ToString();
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
            if (dataGridViewCarParts.Rows.Count == 0)
            {
                MessageBox.Show("No items in the cart to place an order.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    // Insert Order
                    string insertOrderQuery = "INSERT INTO Orders (customer_id, order_date, order_status, total_price) " +
                                              "VALUES (@CustomerId, @OrderDate, @OrderStatus, @TotalPrice); " +
                                              "SELECT SCOPE_IDENTITY();";

                    SqlCommand orderCommand = new SqlCommand(insertOrderQuery, connection, transaction);
                    orderCommand.Parameters.AddWithValue("@CustomerId", LoggerSession.user_id); 
                    orderCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    orderCommand.Parameters.AddWithValue("@OrderStatus", "Complete"); // Set the appropriate status
                    orderCommand.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(txtNetTotal.Text));

                    int orderId = Convert.ToInt32(orderCommand.ExecuteScalar());

                    // Insert Order Details
                    foreach (DataGridViewRow row in dataGridViewCarParts.Rows)
                    { 
                        string itemType = row.Cells["ItemType"].Value.ToString().Contains("Cars") ? "Cars" : "Parts";
                        int itemId = Convert.ToInt16 (row.Cells["ItemCode"].Value);
                        decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                        decimal subTotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                        string insertOrderDetailsQuery = "INSERT INTO Order_details (order_id, item_type, item_id, quantity, price, item_type_id) " +
                                                         "VALUES (@OrderId, @ItemType, @ItemId, @Quantity, @Price, @ItemTypeId)";

                        SqlCommand orderDetailsCommand = new SqlCommand(insertOrderDetailsQuery, connection, transaction);
                        orderDetailsCommand.Parameters.AddWithValue("@OrderId", orderId);
                        orderDetailsCommand.Parameters.AddWithValue("@ItemType", itemType);
                        orderDetailsCommand.Parameters.AddWithValue("@ItemId", itemId);
                        orderDetailsCommand.Parameters.AddWithValue("@Quantity", quantity);
                        orderDetailsCommand.Parameters.AddWithValue("@Price", subTotal);
                        orderDetailsCommand.Parameters.Add("@ItemTypeId", SqlDbType.Decimal);

                        if (itemType == "Parts")
                        {
                            decimal itemTypeId = Convert.ToDecimal(row.Cells["ItemTypeId"].Value);
                            orderDetailsCommand.Parameters["@ItemTypeId"].Value = itemTypeId;
                        }
                        else
                        {
                            orderDetailsCommand.Parameters["@ItemTypeId"].Value = 0; 
                        }

                        orderDetailsCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Order placed successfully!");
                    btnTableClear_Click(sender,e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while placing the order: " + ex.Message);
                }
            }
        }

        private void btnAddtoCartInCar_Click(object sender, EventArgs e)
        {
            if (numOrderStockInCar.Value <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero for the car.");
                return;
            }

            if (comboBoxCarInCar.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a car.");
            }

            string item = comboBoxCarInCar.Text;
            string description = txtModelInCar.Text;
            decimal price = numPriceInCar.Value;
            decimal quantity = numOrderStockInCar.Value;
            decimal subtotal = price * quantity;
            int itemCode = comboBoxCarInCar.SelectedIndex+1;
            string itemType = "Cars"; 
            int carId = 0;
            dataGridViewCarParts.Rows.Add(item, description, price, quantity, subtotal, itemCode, itemType, carId);
            CalculateTotal();
            ClearCarSideFields();
        }

        private void btnAddtoCartInParts_Click(object sender, EventArgs e)
        {
            if (numOrderStockInParts.Value <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero for the parts.");
                return;
            }

            if (comboBoxCarInParts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a part.");
                return;
            }

            string item = comboBoxCarInParts.Text ?? "parts";
            string description = $"{comboBoxParts.Text} - {txtRemarkInParts.Text}";
            decimal price = numPriceInParts.Value;
            decimal quantity = numOrderStockInParts.Value;
            decimal subtotal = price * quantity;
            int item_code = comboBoxCarInParts.SelectedIndex+1;
            string itemType = "Parts";
            int carId = comboBoxCarInParts.SelectedIndex + 1;
            dataGridViewCarParts.Rows.Add(item, description, price, quantity, subtotal, item_code, itemType,carId);
            CalculateTotal();
            ClearPartsSideFields();
        }

        private void btnTableClear_Click(object sender, EventArgs e)
        {
            dataGridViewCarParts.Rows.Clear(); 
            txtNetTotal.Text = string.Empty;
        }
    }
}
