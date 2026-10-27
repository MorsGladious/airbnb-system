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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          if(MessageBox.Show("Deseja sair do aplicativo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void AdminMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            
            
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

        private void admin_dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            admin_adduser1.Visible = false;
            admin_rooms1.Visible = false;
            admin_customers1.Visible = false;

            Admin_dashboard adDashboard = admin_dashboard1 as Admin_dashboard;

            if(adDashboard != null)
            {
                adDashboard.refreshData();
            }
        }

        private void Adduser_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_adduser1.Visible = true;
            admin_rooms1.Visible = false;
            admin_customers1.Visible = false;

            admin_adduser aduser = admin_adduser1 as admin_adduser;

            if(aduser != null)
            {
                aduser.refreshData();
            }
        }

        private void rooms_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_adduser1.Visible = false;
            admin_rooms1.Visible = true;
            admin_customers1.Visible = false;

            admin_rooms adrooms = admin_rooms1 as admin_rooms;

            if(adrooms != null)
            {
                adrooms.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_adduser1.Visible = false;
            admin_rooms1.Visible = false;
            admin_customers1.Visible = true;

            admin_customers adcustomer = admin_customers1 as admin_customers;

            if(adcustomer != null)
            {
                adcustomer.refreshData();
            }
        }
    }
}
