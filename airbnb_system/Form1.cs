using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Web;


namespace airbnb_system
{
    public partial class Form1 : Form
    {
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\NEWTON SAMBO\\Documents\\AirBnB.mdf\";Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lgn_registerbtn_Click(object sender, EventArgs e)
        {
            registrar regform = new registrar();
            regform.Show();

            this.Hide();
        }

        private void lgn_showPass_CheckedChanged(object sender, EventArgs e)
        {
            lgn_password.PasswordChar = lgn_showPass.Checked ? '\0' : '*';
        }

        private void lgn_btn_Click(object sender, EventArgs e)
        {
            if (lgn_user.Text == "" || lgn_password.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM users WHERE (username = @usern AND password = @pass) AND status = 'Activo'";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", lgn_user.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", lgn_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Activo");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show("Log in bem sucedido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", lgn_user.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass", lgn_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                if (userRole == "Administrador")
                                {

                                    AdminMainForm adminform = new AdminMainForm();
                                    adminform.Show();

                                    this.Hide();
                                }
                                else if (userRole == "Funcionário")
                                {
                                    staffMainForm staffform = new staffMainForm();
                                    staffform.Show();

                                    this.Hide();
                                }
                            }

                            
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou palavra-passe errados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void lgn_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
