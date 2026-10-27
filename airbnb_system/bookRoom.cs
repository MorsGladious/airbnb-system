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
    public partial class bookRoom : UserControl
    {
        public bookRoom()
        {
            InitializeComponent();
            displayrooms();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayrooms();
        }

        public void displayrooms()
        {
            roomsData rData = new roomsData();

            List<roomsData> listData = rData.roomsDataList();

            dataGridView1.DataSource = listData;



        }
        private int getID = 0;
        private decimal regprice = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                bookRoom_roomID.Text = row.Cells[1].Value.ToString();
                bookRoom_roomType.Text = row.Cells[2].Value.ToString();
                bookRoom_roomName.Text = row.Cells[3].Value.ToString();
                bookRoom_regprice.Text = (Convert.ToInt32(row.Cells[4].Value)).ToString("0,00");
                
                regprice = Convert.ToDecimal(row.Cells[4].Value);
                
                bookRoom_imageViewer.ImageLocation = row.Cells[5].Value.ToString();

                bookRoom_roomStatus.Text = row.Cells[6].Value.ToString();
            }


            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookRoom_scheduleBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = bookRoom_from.Value;
            DateTime toDate = bookRoom_to.Value;

            TimeSpan countDays = toDate - fromDate;

            
            int days = countDays.Days;

            decimal totalPrice = (days * regprice);

            if (totalPrice < 0)
            {
                MessageBox.Show("A data de saída não pode ser anterior à data de entrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookRoom_total.Text = "0,00";
            }else if (totalPrice == 0)
            {
                bookRoom_total.Text = regprice.ToString("0,00");
            }
            else
            {
                bookRoom_total.Text = (days * regprice).ToString("0,00");
            }



            
        }

        private void bookRoom_bookBtn_Click(object sender, EventArgs e)
        {
            if(regprice == 0 || bookRoom_total.Text == "0,00")
            {
                MessageBox.Show("Selecione todos os campos para reservar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (bookRoom_roomStatus.Text == "Ocupado")
            {
                MessageBox.Show("O quarto selecionado está ocupado. Por favor, selecione outro quarto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                airbnbData.roomID = bookRoom_roomID.Text;
                airbnbData.fromDate = bookRoom_from.Value;
                airbnbData.toDate = bookRoom_to.Value;
                airbnbData.price = bookRoom_total.Text;

                Form formbg = new Form();
                try
                {
                    using (clientInfo ciForm = new clientInfo())
                    {


                        ciForm.Owner = formbg;
                        ciForm.ShowDialog();

                        formbg.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao tentar reservar o quarto: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    formbg.Dispose();
                }
            }
            
        }

        public void clearFields()
        {
            bookRoom_roomID.Text = "---------";
            bookRoom_roomType.Text = "---------";
            bookRoom_roomName.Text = "---------";
            bookRoom_regprice.Text = "0,00";
            bookRoom_imageViewer.Image = null;
            bookRoom_roomStatus.Text = "---------";
            bookRoom_total.Text = "0,00";
        }

        private void bookRoom_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        
    }
    
}
