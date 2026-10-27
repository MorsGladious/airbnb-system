namespace airbnb_system
{
    partial class staffMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sair = new System.Windows.Forms.Button();
            this.staffdashboard_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.staffcustomers_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.staffBookRoom_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.admin_customers1 = new airbnb_system.admin_customers();
            this.bookRoom1 = new airbnb_system.bookRoom();
            this.admin_dashboard1 = new airbnb_system.Admin_dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 49);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(153, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 708);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "AirBnB Management";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1267, 11);
            this.close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.staffdashboard_btn);
            this.panel2.Controls.Add(this.staffBookRoom_btn);
            this.panel2.Controls.Add(this.sair);
            this.panel2.Controls.Add(this.staffcustomers_btn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 721);
            this.panel2.TabIndex = 4;
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.ForeColor = System.Drawing.Color.White;
            this.sair.Location = new System.Drawing.Point(39, 663);
            this.sair.Margin = new System.Windows.Forms.Padding(4);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(236, 42);
            this.sair.TabIndex = 15;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // staffdashboard_btn
            // 
            this.staffdashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.staffdashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffdashboard_btn.FlatAppearance.BorderSize = 0;
            this.staffdashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.staffdashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.staffdashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffdashboard_btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffdashboard_btn.ForeColor = System.Drawing.Color.White;
            this.staffdashboard_btn.Location = new System.Drawing.Point(39, 254);
            this.staffdashboard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.staffdashboard_btn.Name = "staffdashboard_btn";
            this.staffdashboard_btn.Size = new System.Drawing.Size(236, 42);
            this.staffdashboard_btn.TabIndex = 11;
            this.staffdashboard_btn.Text = "Dashboard";
            this.staffdashboard_btn.UseVisualStyleBackColor = false;
            this.staffdashboard_btn.Click += new System.EventHandler(this.staffdashboard_btn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bem vindo, Usuário";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // staffcustomers_btn
            // 
            this.staffcustomers_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.staffcustomers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffcustomers_btn.FlatAppearance.BorderSize = 0;
            this.staffcustomers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.staffcustomers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.staffcustomers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffcustomers_btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffcustomers_btn.ForeColor = System.Drawing.Color.White;
            this.staffcustomers_btn.Location = new System.Drawing.Point(39, 354);
            this.staffcustomers_btn.Margin = new System.Windows.Forms.Padding(4);
            this.staffcustomers_btn.Name = "staffcustomers_btn";
            this.staffcustomers_btn.Size = new System.Drawing.Size(236, 42);
            this.staffcustomers_btn.TabIndex = 14;
            this.staffcustomers_btn.Text = "Clientes";
            this.staffcustomers_btn.UseVisualStyleBackColor = false;
            this.staffcustomers_btn.Click += new System.EventHandler(this.staffcustomers_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::airbnb_system.Properties.Resources.hotel_1_;
            this.pictureBox1.Location = new System.Drawing.Point(96, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // staffBookRoom_btn
            // 
            this.staffBookRoom_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.staffBookRoom_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffBookRoom_btn.FlatAppearance.BorderSize = 0;
            this.staffBookRoom_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.staffBookRoom_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.staffBookRoom_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBookRoom_btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBookRoom_btn.ForeColor = System.Drawing.Color.White;
            this.staffBookRoom_btn.Location = new System.Drawing.Point(39, 304);
            this.staffBookRoom_btn.Margin = new System.Windows.Forms.Padding(4);
            this.staffBookRoom_btn.Name = "staffBookRoom_btn";
            this.staffBookRoom_btn.Size = new System.Drawing.Size(236, 42);
            this.staffBookRoom_btn.TabIndex = 12;
            this.staffBookRoom_btn.Text = "Reservar Quarto";
            this.staffBookRoom_btn.UseVisualStyleBackColor = false;
            this.staffBookRoom_btn.Click += new System.EventHandler(this.staffBookRoom_btn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.admin_dashboard1);
            this.panel4.Controls.Add(this.bookRoom1);
            this.panel4.Controls.Add(this.admin_customers1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(353, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(947, 721);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // admin_customers1
            // 
            this.admin_customers1.Location = new System.Drawing.Point(0, 0);
            this.admin_customers1.Name = "admin_customers1";
            this.admin_customers1.Size = new System.Drawing.Size(944, 722);
            this.admin_customers1.TabIndex = 0;
            // 
            // bookRoom1
            // 
            this.bookRoom1.Location = new System.Drawing.Point(0, -1);
            this.bookRoom1.Name = "bookRoom1";
            this.bookRoom1.Size = new System.Drawing.Size(944, 722);
            this.bookRoom1.TabIndex = 1;
            // 
            // admin_dashboard1
            // 
            this.admin_dashboard1.Location = new System.Drawing.Point(-1, -1);
            this.admin_dashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.admin_dashboard1.Name = "admin_dashboard1";
            this.admin_dashboard1.Size = new System.Drawing.Size(944, 724);
            this.admin_dashboard1.TabIndex = 2;
            // 
            // staffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 770);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staffMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button staffdashboard_btn;
        private System.Windows.Forms.Button staffcustomers_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button staffBookRoom_btn;
        private System.Windows.Forms.Panel panel4;
        private Admin_dashboard admin_dashboard1;
        private bookRoom bookRoom1;
        private admin_customers admin_customers1;
    }
}