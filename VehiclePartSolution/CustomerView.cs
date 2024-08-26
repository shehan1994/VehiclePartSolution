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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VehiclePartSolution
{
    public partial class CustomerView : Form
    {
        private string connection_string;
        public CustomerView()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["DB_Connection_String"].ConnectionString;
            LoadOrderHistory();

        }

        private void LoadOrderHistory()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = @"SELECT u.[first_name], u.[last_name], o.[order_id],o.[order_status], o.[order_date], od.[item_type], od.[quantity], od.[price]," +
                    " o.[total_price]  FROM [Orders] o " +
                    "JOIN [Order_details] od ON o.[order_id] = od.[order_id] " +
                    "JOIN [SYS_Users] u ON o.[customer_id] = u.[user_id] WHERE o.[customer_id] = "+LoggerSession.user_id;
                Console.WriteLine("sql :"+query);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable orderListTable = new DataTable();
                adapter.Fill(orderListTable);
                

                if (orderListTable != null && orderListTable.Rows.Count > 0)
                {
                    gridViewOrderHistory.DataSource = orderListTable; 
                    gridViewOrderHistory.Columns["first_name"].HeaderText = "First Name";
                    gridViewOrderHistory.Columns["last_name"].HeaderText = "Last Name";
                    gridViewOrderHistory.Columns["order_status"].HeaderText = "Order Status";
                    gridViewOrderHistory.Columns["order_id"].HeaderText = "Order ID";
                    gridViewOrderHistory.Columns["order_date"].HeaderText = "Order Date";
                    gridViewOrderHistory.Columns["item_type"].HeaderText = "Item Type";
                    gridViewOrderHistory.Columns["quantity"].HeaderText = "Quantity";
                    gridViewOrderHistory.Columns["price"].HeaderText = "Price";
                    gridViewOrderHistory.Columns["total_price"].HeaderText = "Total Amount";
                }
                else
                {
                    // Handle the case where there are no records
                    MessageBox.Show("No order history found for this customer.");
                }
            }
        }

        private void btnPlaceOrder_Click_1(object sender, EventArgs e)
        {
            OrderManage orderManage = new OrderManage();
            orderManage.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login =  new Login();
            login.Show();
            this.Close();
        }
    }
}
