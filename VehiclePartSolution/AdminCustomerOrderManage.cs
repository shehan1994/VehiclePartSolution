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
    public partial class AdminCustomerOrderManage : Form
    {
        private string connection_string;
        public AdminCustomerOrderManage()
        {
            connection_string = ConfigurationManager.ConnectionStrings["DB_Connection_String"].ConnectionString;

            InitializeComponent();
            LoadOrder();
        }

        private void LoadOrder()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = @"SELECT u.[first_name], u.[last_name], o.[order_id],o.[order_status], o.[order_date], od.[item_type], od.[quantity], od.[price]," +
                    " o.[total_price]  FROM [Orders] o " +
                    "JOIN [Order_details] od ON o.[order_id] = od.[order_id] " +
                    "JOIN [SYS_Users] u ON o.[customer_id] = u.[user_id]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable orderListTable = new DataTable();
                adapter.Fill(orderListTable);


                if (orderListTable != null && orderListTable.Rows.Count > 0)
                {
                    GridViewOrderOnAdmin.DataSource = orderListTable;
                    GridViewOrderOnAdmin.Columns["first_name"].HeaderText = "First Name";
                    GridViewOrderOnAdmin.Columns["last_name"].HeaderText = "Last Name";
                    GridViewOrderOnAdmin.Columns["order_status"].HeaderText = "Order Status";
                    GridViewOrderOnAdmin.Columns["order_id"].HeaderText = "Order ID";
                    GridViewOrderOnAdmin.Columns["order_date"].HeaderText = "Order Date";
                    GridViewOrderOnAdmin.Columns["item_type"].HeaderText = "Item Type";
                    GridViewOrderOnAdmin.Columns["quantity"].HeaderText = "Quantity";
                    GridViewOrderOnAdmin.Columns["price"].HeaderText = "Price";
                    GridViewOrderOnAdmin.Columns["total_price"].HeaderText = "Total Amount";
                }
                else
                {
                    // Handle the case where there are no records
                    MessageBox.Show("No order history found for this customer.");
                }
            }
        }

        private void AdminCustomerOrderManage_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminView admin = new AdminView();
            admin.Show();
            this.Close();
        }
    }
}
