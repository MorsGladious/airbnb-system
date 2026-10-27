using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace airbnb_system
{
    public partial class admin_customers : UserControl
    {

        public admin_customers()
        {
            InitializeComponent();

            displayCustomers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomers();
        }

        public void displayCustomers()
        {
            customerData cData = new customerData();

            List<customerData> listData = cData.customerListData();

            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
