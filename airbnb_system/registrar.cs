using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System;

namespace airbnb_system
{
    public partial class registrar : Form
    {
       private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\NEWTON SAMBO\\Documents\\airbnb.mdf;Integrated Security=True;Connect Timeout=30";
        public registrar()
        {
            InitializeComponent();
        }

        private void register_signinbtn_Click(object sender, System.EventArgs e)
        {
            Form1 lgnform = new Form1();
            lgnform.Show();

            this.Hide();
        }

        private void close_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void register_showpass_CheckedChanged(object sender, System.EventArgs e)
        {
            register_password.PasswordChar = register_showpass.Checked ? '\0' : '*';
            register_cpassword.PasswordChar = register_showpass.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, System.EventArgs e)
        {
            if(register_user.Text == "" || register_password.Text == "" || register_cpassword.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string checkUsern = "SELECT username FROM users WHERE username = @usern";

                    using (SqlCommand checkU = new SqlCommand(checkUsern, connect))
                    {
                        checkU.Parameters.AddWithValue("@usern", register_user.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count != 0)
                        {
                            string tempEmail = register_user.Text.Substring(0, 1).ToUpper() + register_user.Text.Substring(1);
                            MessageBox.Show($"{tempEmail} já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(register_password.Text.Length < 8)
                        {
                            MessageBox.Show("Palavra-passe muito curta! Minimo 8 caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(register_password.Text != register_cpassword.Text)
                        {
                            MessageBox.Show("As palavras-passes não são iguais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string query = "INSERT INTO users (username, password, role, status, date_register)" +
                                "VALUES(@usern, @pass, @role, @status, @regdate)";

                            using(SqlCommand cmd = new SqlCommand(query, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", register_user.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role","Funcionário");
                                cmd.Parameters.AddWithValue("@status", "Activo");

                                DateTime hoje = DateTime.Today;
                                cmd.Parameters.AddWithValue("@regdate", hoje);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registro bem sucedido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 lgnform = new Form1();
                                lgnform.Show();

                                this.Hide();
                            }
                        }
                    }

                }
            }
        }

        private void registrar_Load(object sender, EventArgs e)
        {

        }
    }
}
