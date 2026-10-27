using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace airbnb_system
{
    internal class dataUsuario
    {
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\NEWTON SAMBO\\Documents\\AirBnB.mdf\";Integrated Security=True;Connect Timeout=30";
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        public DateTime date_register { get; set; }

        public List<dataUsuario> listUsersData()
        {
            List<dataUsuario> listData = new List<dataUsuario>();

            using(SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dataUsuario uData = new dataUsuario();

                        uData.id = (int)reader["id"];
                        uData.username = reader["username"].ToString();
                        uData.password = reader["password"].ToString();
                        uData.role = reader["role"].ToString();
                        uData.status = reader["status"].ToString();
                        uData.date_register = (DateTime)reader["date_register"];
                        
                        listData.Add(uData);
                    }
                }   
            }

            return listData;
        }
    }
}
