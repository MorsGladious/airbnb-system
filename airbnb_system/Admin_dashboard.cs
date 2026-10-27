using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace airbnb_system
{
    public partial class Admin_dashboard : UserControl
    {
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\NEWTON SAMBO\\Documents\\AirBnB.mdf\";Integrated Security=True;Connect Timeout=30";

        public Admin_dashboard()
        {
            InitializeComponent();
            displayTotalStaff();
            displayAvailableRooms();
            displayProfitToday();
            displayProfiTotal();
            displayAllRooms();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayTotalStaff();
            displayAvailableRooms();
            displayProfitToday();
            displayProfiTotal();
            displayAllRooms();
        }

        public void displayAllRooms()
        {
            roomsData rData = new roomsData();
            List<roomsData> listData = rData.roomsDataList();
            dataGridView1.DataSource = listData;
        }


        public void displayTotalStaff()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM users WHERE role = 'Funcionário'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        totalStaff.Text = result.ToString();
                    }
                }
            }
        }


        public void displayAvailableRooms()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM rooms WHERE status = 'Activo' OR status = 'Disponível'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        avRooms.Text = result.ToString();
                    }
                }
            }

        }


        public void displayProfitToday()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT SUM(price) FROM customers WHERE date_book = @datebook";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    DateTime hoje = DateTime.Today;
                    cmd.Parameters.AddWithValue("@datebook", hoje);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        profitToday.Text = result.ToString() + ",00 KZ";
                    }
                }
            }

        }

        public void displayProfiTotal()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT SUM(price) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {


                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        totalProfit.Text = result.ToString() + ",00 KZ";
                    }
                }
            }
        }

    }
}

