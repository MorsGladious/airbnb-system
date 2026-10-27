using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace airbnb_system
{
    public partial class clientInfo : Form
    {

        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\NEWTON SAMBO\\Documents\\AirBnB.mdf\";Integrated Security=True;Connect Timeout=30";
        public clientInfo()
        {
            InitializeComponent();
            displayBookID();
        }

        private void clientclose_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        public void displayBookID()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                int getBookID = 0;

                string selectBID = "SELECT COUNT(id) FROM customers";

                using(SqlCommand cmd = new SqlCommand(selectBID, connect))
                {
                    getBookID = Convert.ToInt32(cmd.ExecuteScalar());

                    if(Convert.ToInt32(getBookID) == 0)
                    {
                        getBookID += 1;
                    }
                    else
                    {
                        getBookID += 1;
                    }
                    

                }

                client_bookID.Text = $"BID-{getBookID}";
            }
        }

        private void client_bookNowBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Queres fazer uma reserva agora?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (client_fullname.Text == "" || client_gender.SelectedIndex == -1 || client_address.Text == "" ||
               client_email.Text == "" || client_phone.Text == "" || airbnbData.roomID == "")
                {
                    MessageBox.Show("Por favor preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string insertData = "INSERT INTO customers (id_reserva, fullname, email, phone, gender, address, Quarto_id, price, status_pagamento, status, date_from, date_to, date_book)" +
                            " VALUES (@id_reserva, @fullname, @email, @phone, @gender, @address, @roomid, @price, @statusP, @status, @datefrom, @dateto, @datebook)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id_reserva", client_bookID.Text);
                            cmd.Parameters.AddWithValue("@fullname", client_fullname.Text);
                            cmd.Parameters.AddWithValue("@email", cEmail.Text);
                            cmd.Parameters.AddWithValue("@phone", cPhone.Text);
                            cmd.Parameters.AddWithValue("@gender", client_gender.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@address", client_address.Text);
                            cmd.Parameters.AddWithValue("@roomid", airbnbData.roomID);
                            cmd.Parameters.AddWithValue("@price", airbnbData.price);
                            cmd.Parameters.AddWithValue("@statusP", "Pago");
                            cmd.Parameters.AddWithValue("@status", "Checked In");
                            cmd.Parameters.AddWithValue("@datefrom", airbnbData.fromDate);
                            cmd.Parameters.AddWithValue("@dateto", airbnbData.toDate);

                            DateTime hoje = DateTime.Today;
                            cmd.Parameters.AddWithValue("@datebook", hoje);

                            cmd.ExecuteNonQuery();

                            updateRoomStatus();

                            MessageBox.Show("Reserva feita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                        }
                    }
                }
            }
           
        }

        public void updateRoomStatus()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string updateStatus = "UPDATE rooms SET status = @status WHERE Quarto_id = @roomid";

                using (SqlCommand cmd = new SqlCommand(updateStatus, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Ocupado");
                    cmd.Parameters.AddWithValue("@roomid", airbnbData.roomID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void client_clrBtn_Click(object sender, EventArgs e)
        {
            client_fullname.Text = "";
            client_email.Text = "";
            client_phone.Text = "";
            client_gender.SelectedIndex = -1;
            client_address.Text = "";

        }
    }
}
