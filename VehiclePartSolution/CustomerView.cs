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

        private void btnCarOrder_Click(object sender, EventArgs e)
        {
            CarManage car = new CarManage();
            car.Show();
        }

        private void btnCarPartsOrder_Click(object sender, EventArgs e)
        {
            CarPartsManage carParts = new CarPartsManage();        
            carParts.Show();   
        }
    }
}
