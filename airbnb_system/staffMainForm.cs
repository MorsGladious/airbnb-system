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
    public partial class staffMainForm : Form
    {
        public staffMainForm()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do aplicativo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja terminar a sua sessão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 lgnform = new Form1();
                lgnform.Show();

                this.Hide();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void staffdashboard_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            bookRoom1.Visible = false;
            admin_customers1.Visible = false;

            Admin_dashboard adDashboard = admin_dashboard1 as Admin_dashboard;

            if (adDashboard != null)
            {
                adDashboard.refreshData();
            }
        }

        private void staffBookRoom_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            bookRoom1.Visible = true;
            admin_customers1.Visible = false;

            bookRoom broom = bookRoom1 as bookRoom;

            if (broom != null)
            {
                broom.refreshData();
            }

        }

        private void staffcustomers_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            bookRoom1.Visible = false;
            admin_customers1.Visible = true;

            admin_customers adcustomer = admin_customers1 as admin_customers;

            if (adcustomer != null)
            {
                adcustomer.refreshData();
            }
        }
    }
}
