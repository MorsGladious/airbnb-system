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
using System.IO;


namespace airbnb_system
{
    public partial class admin_rooms : UserControl
    {
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\NEWTON SAMBO\\Documents\\AirBnB.mdf\";Integrated Security=True;Connect Timeout=30";
        public admin_rooms()
        {
            InitializeComponent();
            displayroomsData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayroomsData();
        }

        public void displayroomsData()
        {
            roomsData rData = new roomsData();
            List<roomsData> listD = rData.roomsDataList();
            dataGridView1.DataSource = listD;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool isEmpty()
        {
            if (string.IsNullOrEmpty(rooms_roomsID.Text) || string.IsNullOrEmpty(rooms_name.Text) ||
                rooms_type.SelectedIndex == -1 || string.IsNullOrEmpty(rooms_price.Text)
                || rooms_status.SelectedIndex == -1 || rooms_picture.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void rooms_addbtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string checkRoomID = "SELECT Quarto_id from rooms WHERE Quarto_id = @Quarto_id";
                        using (SqlCommand checkRID = new SqlCommand(checkRoomID, connect))
                        {
                            checkRID.Parameters.AddWithValue("@Quarto_id", rooms_roomsID.Text.Trim());


                            SqlDataAdapter adapter = new SqlDataAdapter(checkRID);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(rooms_roomsID.Text + " já existe. Por favor, insira um ID diferente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO rooms(Quarto_id, tipo, Quarto_nome, Preco, image_path, Status, date_register)"
                                    + " VALUES(@Quarto_id, @tipo, @nome, @Preco, @image_path, @Status, @date_reg)";

                                string path = Path.Combine(@"E:\airbnb_system\airbnb_system\room directory\"
                                    + rooms_roomsID.Text.Trim());

                                string directoryPath = Directory.GetDirectoryRoot(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(rooms_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@Quarto_id", rooms_roomsID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@tipo", rooms_type.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@nome", rooms_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Preco", rooms_price.Text.Trim());

                                    cmd.Parameters.AddWithValue("@image_path", path);

                                    cmd.Parameters.AddWithValue("@Status", rooms_status.SelectedItem.ToString());


                                    DateTime hoje = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@date_reg", hoje);

                                    cmd.ExecuteNonQuery();
                                    clearFields();
                                    displayroomsData();

                                    MessageBox.Show("Quarto adicionado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void rooms_importbtn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog file = new OpenFileDialog();
                string imagePath = "";
                file.Filter = "Image Files (*.jpg; *. png)|*.jpg; *.png";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    rooms_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void rooms_updbtn_Click(object sender, EventArgs e)
        {

            if (isEmpty())
            {
                MessageBox.Show("Por favor, escolha um item primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show($"Deseja atualizar o ID {id} ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();
                            string updateData = "UPDATE rooms SET Quarto_id = @Quarto_id, tipo = @tipo, Quarto_nome = @nome, " +
                                "Preco = @Preco, image_path = @image_path, Status = @Status, date_update = @date_upd WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Quarto_id", rooms_roomsID.Text.Trim());
                                cmd.Parameters.AddWithValue("@tipo", rooms_type.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@nome", rooms_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@Preco", rooms_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@image_path", rooms_picture.ImageLocation);
                                cmd.Parameters.AddWithValue("@Status", rooms_status.SelectedItem.ToString());


                                DateTime hoje = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date_upd", hoje);
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();
                                displayroomsData();

                                MessageBox.Show("Quarto atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Algo deu errado ao atualizar o quarto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            
        }

        private int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                rooms_roomsID.Text = row.Cells[1].Value.ToString();
                rooms_type.Text = row.Cells[2].Value.ToString();
                rooms_name.Text = row.Cells[3].Value.ToString();
                
                rooms_price.Text = row.Cells[4].Value.ToString();

                rooms_picture.ImageLocation = row.Cells[5].Value.ToString();

                rooms_status.Text = row.Cells[6].Value.ToString();

            }
        }

        public void clearFields()
        {
            rooms_roomsID.Text = "";
            rooms_name.Text = "";
            rooms_type.SelectedIndex = -1;
            rooms_price.Text = "";
            rooms_status.SelectedIndex = -1;
            rooms_picture.Image = null;
        }
        private void rooms_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void rooms_rmbtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Por favor, escolha um item primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show($"Deseja remover o ID {id} ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();
                            string updateData = "UPDATE rooms SET date_delete = @date_del WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            { 

                                DateTime hoje = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date_del", hoje);
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();
                                displayroomsData();

                                MessageBox.Show("Quarto removido com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo deu errado ao atualizar o quarto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
