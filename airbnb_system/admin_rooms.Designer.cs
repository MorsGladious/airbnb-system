namespace airbnb_system
{
    partial class admin_rooms
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rooms_clearbtn = new System.Windows.Forms.Button();
            this.rooms_rmbtn = new System.Windows.Forms.Button();
            this.rooms_updbtn = new System.Windows.Forms.Button();
            this.rooms_addbtn = new System.Windows.Forms.Button();
            this.rooms_importbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rooms_picture = new System.Windows.Forms.PictureBox();
            this.rooms_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rooms_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rooms_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rooms_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rooms_roomsID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 383);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dados dos quartos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(21, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 317);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rooms_clearbtn);
            this.panel2.Controls.Add(this.rooms_rmbtn);
            this.panel2.Controls.Add(this.rooms_updbtn);
            this.panel2.Controls.Add(this.rooms_addbtn);
            this.panel2.Controls.Add(this.rooms_importbtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.rooms_status);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rooms_price);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rooms_name);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rooms_type);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rooms_roomsID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 272);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rooms_clearbtn
            // 
            this.rooms_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.rooms_clearbtn.FlatAppearance.BorderSize = 0;
            this.rooms_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_clearbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_clearbtn.ForeColor = System.Drawing.Color.White;
            this.rooms_clearbtn.Location = new System.Drawing.Point(520, 199);
            this.rooms_clearbtn.Name = "rooms_clearbtn";
            this.rooms_clearbtn.Size = new System.Drawing.Size(141, 44);
            this.rooms_clearbtn.TabIndex = 23;
            this.rooms_clearbtn.Text = "Limpar";
            this.rooms_clearbtn.UseVisualStyleBackColor = false;
            this.rooms_clearbtn.Click += new System.EventHandler(this.rooms_clearbtn_Click);
            // 
            // rooms_rmbtn
            // 
            this.rooms_rmbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.rooms_rmbtn.FlatAppearance.BorderSize = 0;
            this.rooms_rmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_rmbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_rmbtn.ForeColor = System.Drawing.Color.White;
            this.rooms_rmbtn.Location = new System.Drawing.Point(357, 199);
            this.rooms_rmbtn.Name = "rooms_rmbtn";
            this.rooms_rmbtn.Size = new System.Drawing.Size(141, 44);
            this.rooms_rmbtn.TabIndex = 22;
            this.rooms_rmbtn.Text = "Remover";
            this.rooms_rmbtn.UseVisualStyleBackColor = false;
            this.rooms_rmbtn.Click += new System.EventHandler(this.rooms_rmbtn_Click);
            // 
            // rooms_updbtn
            // 
            this.rooms_updbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.rooms_updbtn.FlatAppearance.BorderSize = 0;
            this.rooms_updbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_updbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_updbtn.ForeColor = System.Drawing.Color.White;
            this.rooms_updbtn.Location = new System.Drawing.Point(192, 199);
            this.rooms_updbtn.Name = "rooms_updbtn";
            this.rooms_updbtn.Size = new System.Drawing.Size(141, 44);
            this.rooms_updbtn.TabIndex = 21;
            this.rooms_updbtn.Text = "Atualizar";
            this.rooms_updbtn.UseVisualStyleBackColor = false;
            this.rooms_updbtn.Click += new System.EventHandler(this.rooms_updbtn_Click);
            // 
            // rooms_addbtn
            // 
            this.rooms_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.rooms_addbtn.FlatAppearance.BorderSize = 0;
            this.rooms_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_addbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_addbtn.ForeColor = System.Drawing.Color.White;
            this.rooms_addbtn.Location = new System.Drawing.Point(29, 199);
            this.rooms_addbtn.Name = "rooms_addbtn";
            this.rooms_addbtn.Size = new System.Drawing.Size(141, 44);
            this.rooms_addbtn.TabIndex = 20;
            this.rooms_addbtn.Text = "Adicionar";
            this.rooms_addbtn.UseVisualStyleBackColor = false;
            this.rooms_addbtn.Click += new System.EventHandler(this.rooms_addbtn_Click);
            // 
            // rooms_importbtn
            // 
            this.rooms_importbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.rooms_importbtn.FlatAppearance.BorderSize = 0;
            this.rooms_importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_importbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_importbtn.ForeColor = System.Drawing.Color.White;
            this.rooms_importbtn.Location = new System.Drawing.Point(769, 175);
            this.rooms_importbtn.Name = "rooms_importbtn";
            this.rooms_importbtn.Size = new System.Drawing.Size(126, 36);
            this.rooms_importbtn.TabIndex = 19;
            this.rooms_importbtn.Text = "Importar";
            this.rooms_importbtn.UseVisualStyleBackColor = false;
            this.rooms_importbtn.Click += new System.EventHandler(this.rooms_importbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.rooms_picture);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(769, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 144);
            this.panel3.TabIndex = 18;
            // 
            // rooms_picture
            // 
            this.rooms_picture.Location = new System.Drawing.Point(0, 0);
            this.rooms_picture.Name = "rooms_picture";
            this.rooms_picture.Size = new System.Drawing.Size(126, 144);
            this.rooms_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rooms_picture.TabIndex = 0;
            this.rooms_picture.TabStop = false;
            // 
            // rooms_status
            // 
            this.rooms_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_status.FormattingEnabled = true;
            this.rooms_status.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Ocupado"});
            this.rooms_status.Location = new System.Drawing.Point(475, 71);
            this.rooms_status.Name = "rooms_status";
            this.rooms_status.Size = new System.Drawing.Size(208, 28);
            this.rooms_status.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Status:";
            // 
            // rooms_price
            // 
            this.rooms_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_price.Location = new System.Drawing.Point(475, 25);
            this.rooms_price.Name = "rooms_price";
            this.rooms_price.Size = new System.Drawing.Size(208, 27);
            this.rooms_price.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Preço:";
            // 
            // rooms_name
            // 
            this.rooms_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_name.Location = new System.Drawing.Point(153, 73);
            this.rooms_name.Name = "rooms_name";
            this.rooms_name.Size = new System.Drawing.Size(228, 27);
            this.rooms_name.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome do Quarto:";
            // 
            // rooms_type
            // 
            this.rooms_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_type.FormattingEnabled = true;
            this.rooms_type.Items.AddRange(new object[] {
            "Quarto Único",
            "Quarto Duplo"});
            this.rooms_type.Location = new System.Drawing.Point(153, 116);
            this.rooms_type.Name = "rooms_type";
            this.rooms_type.Size = new System.Drawing.Size(228, 28);
            this.rooms_type.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo:";
            // 
            // rooms_roomsID
            // 
            this.rooms_roomsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_roomsID.Location = new System.Drawing.Point(153, 31);
            this.rooms_roomsID.Name = "rooms_roomsID";
            this.rooms_roomsID.Size = new System.Drawing.Size(228, 27);
            this.rooms_roomsID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID do Quarto:";
            // 
            // admin_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "admin_rooms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(944, 709);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rooms_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox rooms_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rooms_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rooms_roomsID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox rooms_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rooms_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rooms_importbtn;
        private System.Windows.Forms.PictureBox rooms_picture;
        private System.Windows.Forms.Button rooms_clearbtn;
        private System.Windows.Forms.Button rooms_rmbtn;
        private System.Windows.Forms.Button rooms_updbtn;
        private System.Windows.Forms.Button rooms_addbtn;
    }
}
