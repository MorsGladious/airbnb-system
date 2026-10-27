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
    public partial class admin_adduser : UserControl
    {
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\NEWTON SAMBO\\Documents\\AirBnB.mdf\";Integrated Security=True;Connect Timeout=30";
        public admin_adduser()
        {
            InitializeComponent();

            displayData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayData();
        }

        public void displayData()
        {
            dataUsuario uData = new dataUsuario();
            dataGridView1.DataSource = uData.listUsersData();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Adduser_delbtn_Click(object sender, EventArgs e)
        {
            if (Adduser_user.Text == "" || Adduser_password.Text == ""
                || Adduser_role.SelectedIndex == -1 || Adduser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Deseja apagar os dados do usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string updateData = "DELETE FROM users WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", Adduser_user.Text.Trim());

                            cmd.ExecuteNonQuery();
                            displayData();

                            MessageBox.Show("Usuário apagado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void Adduser_addbtn_Click(object sender, EventArgs e)
        {
            if (Adduser_user.Text == "" || Adduser_password.Text == ""
                || Adduser_role.SelectedIndex == -1 || Adduser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string checkUsern = "SELECT username FROM users WHERE username = @usern";

                    using (SqlCommand checkU = new SqlCommand(checkUsern, connect))
                    {
                        checkU.Parameters.AddWithValue("@usern", Adduser_user.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable table = new DataTable();

                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            string tempUsern = Adduser_user.Text.Substring(0, 1).ToUpper() + Adduser_user.Text.Substring(1);
                            MessageBox.Show($"{tempUsern} já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Adduser_password.Text.Length < 8)
                        {
                            MessageBox.Show("Palavra-passe muito curta! Minimo 8 caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, role, status, date_register)" +
                                "VALUES (@usern, @pass, @role, @status, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", Adduser_user.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", Adduser_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", Adduser_role.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", Adduser_status.SelectedItem.ToString());
                                
                                DateTime hoje = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", hoje);

                                cmd.ExecuteNonQuery();
                                ClearFields();


                                MessageBox.Show("Usuário adicionado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
            }
        }


        public void ClearFields()
        {
            Adduser_user.Text = "";
            Adduser_password.Text = "";
            Adduser_role.SelectedIndex = -1;
            Adduser_status.SelectedIndex = -1;
        }
        private void Adduser_clrbtn_Click(object sender, EventArgs e)
        {
                        ClearFields();
        }

        private void Adduser_updbtn_Click(object sender, EventArgs e)
        {
            if (Adduser_user.Text == "" || Adduser_password.Text == ""
                || Adduser_role.SelectedIndex == -1 || Adduser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Deseja atualizar os dados do usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                       string updateData = "UPDATE users SET password = @pass, role = @role, status = @status WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@pass", Adduser_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", Adduser_role.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@status", Adduser_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@usern", Adduser_user.Text.Trim());

                            cmd.ExecuteNonQuery();
                           displayData();

                            MessageBox.Show("Usuário atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private int getID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                Adduser_user.Text = row.Cells[1].Value.ToString();
                Adduser_password.Text = row.Cells[2].Value.ToString();
                Adduser_role.Text = row.Cells[3].Value.ToString();
                Adduser_status.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}

