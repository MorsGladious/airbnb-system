using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace airbnb_system
{
    internal class roomsData
    {

        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\NEWTON SAMBO\\Documents\\AirBnB.mdf\";Integrated Security=True;Connect Timeout=30";

        public int id { get; set; }
        public string Quarto_id { get; set; }
        public string Tipo { get; set; }
        public string Quarto_nome { get; set; }
        public string Preco { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public string date_register { get; set; }

        public List<roomsData> roomsDataList()
        {
            List<roomsData> listData = new List<roomsData>();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM rooms WHERE date_delete IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        roomsData rdata= new roomsData();

                        rdata.id = (int)(reader["id"]);
                        rdata.Quarto_id = reader["Quarto_id"].ToString();
                        rdata.Tipo = reader["Tipo"].ToString();
                        rdata.Quarto_nome = reader["Quarto_nome"].ToString();
                        rdata.Preco = reader["Preco"].ToString();
                        rdata.Image = reader["image_path"].ToString();
                        rdata.Status = reader["Status"].ToString();
                        rdata.date_register = reader["date_register"].ToString();   

                        listData.Add(rdata);
                    }

                }
                return listData;
            }
        }
    }
}