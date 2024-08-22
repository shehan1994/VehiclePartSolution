using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehiclePartSolution
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click_1(object sender, EventArgs e)
        {
            OrderManage orderManage = new OrderManage();
            orderManage.Show();
            this.Hide();
        }
    }
}
