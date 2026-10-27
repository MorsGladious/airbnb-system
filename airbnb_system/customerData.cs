using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace airbnb_system
{
    
    internal class customerData
    {
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\NEWTON SAMBO\\Documents\\AirBnB.mdf\";Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string BookID { set; get; }
        public string Fullname { set; get; }
        public string Email { set; get; }
        public string Telefone { set; get; }
        public string Gender { set; get; }
        public string Address { set; get; }
        public string RoomID { set; get; }
        public string Price { set; get; }
        public string StatusPagamento { set; get; }
        public string Status { set; get; }
        public string CheckIn { set; get; }
        public string CheckOut { set; get; }
        public string BookDate { set; get; }





        public List<customerData> customerListData()
        {
            List<customerData> listData = new List<customerData>();

            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM customers";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        customerData cData = new customerData();

                        cData.ID = (int)reader["id"];
                        cData.BookID = reader["id_reserva"].ToString();
                        cData.Fullname = reader["fullname"].ToString();
                        cData.Email = reader["email"].ToString();
                        cData.Telefone = reader["phone"].ToString();
                        cData.Gender = reader["gender"].ToString();
                        cData.Address = reader["address"].ToString();
                        cData.RoomID = reader["Quarto_id"].ToString();
                        cData.Price = reader["price"].ToString();
                        cData.StatusPagamento = reader["status_pagamento"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.CheckIn = reader["date_from"].ToString();
                        cData.CheckOut = reader["date_to"].ToString();
                        cData.BookDate = reader["date_book"].ToString();

                        listData.Add(cData);
                    }
                }
                
            }
            return listData;
        }
    }
}
