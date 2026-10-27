namespace airbnb_system
{
    partial class Form1
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
            this.lgn_registerbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lgn_user = new System.Windows.Forms.TextBox();
            this.lgn_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lgn_btn = new System.Windows.Forms.Button();
            this.lgn_showPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.lgn_registerbtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 495);
            this.panel1.TabIndex = 0;
            // 
            // lgn_registerbtn
            // 
            this.lgn_registerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.lgn_registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgn_registerbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn_registerbtn.ForeColor = System.Drawing.Color.White;
            this.lgn_registerbtn.Location = new System.Drawing.Point(30, 448);
            this.lgn_registerbtn.Name = "lgn_registerbtn";
            this.lgn_registerbtn.Size = new System.Drawing.Size(261, 33);
            this.lgn_registerbtn.TabIndex = 8;
            this.lgn_registerbtn.Text = "Registrar";
            this.lgn_registerbtn.UseVisualStyleBackColor = false;
            this.lgn_registerbtn.Click += new System.EventHandler(this.lgn_registerbtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(90, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Criar nova conta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "AirBnB Management";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::airbnb_system.Properties.Resources.hotel_1_;
            this.pictureBox1.Location = new System.Drawing.Point(114, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(633, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(15, 16);
            this.close.TabIndex = 1;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bem Vindo!";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário";
            // 
            // lgn_user
            // 
            this.lgn_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn_user.Location = new System.Drawing.Point(361, 189);
            this.lgn_user.Name = "lgn_user";
            this.lgn_user.Size = new System.Drawing.Size(272, 26);
            this.lgn_user.TabIndex = 4;
            this.lgn_user.TextChanged += new System.EventHandler(this.lgn_user_TextChanged);
            // 
            // lgn_password
            // 
            this.lgn_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn_password.Location = new System.Drawing.Point(361, 252);
            this.lgn_password.Name = "lgn_password";
            this.lgn_password.PasswordChar = '*';
            this.lgn_password.Size = new System.Drawing.Size(272, 26);
            this.lgn_password.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Palavra-Passe";
            // 
            // lgn_btn
            // 
            this.lgn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.lgn_btn.FlatAppearance.BorderSize = 0;
            this.lgn_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.lgn_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.lgn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgn_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn_btn.ForeColor = System.Drawing.Color.White;
            this.lgn_btn.Location = new System.Drawing.Point(411, 334);
            this.lgn_btn.Name = "lgn_btn";
            this.lgn_btn.Size = new System.Drawing.Size(164, 33);
            this.lgn_btn.TabIndex = 7;
            this.lgn_btn.Text = "Entrar";
            this.lgn_btn.UseVisualStyleBackColor = false;
            this.lgn_btn.Click += new System.EventHandler(this.lgn_btn_Click);
            // 
            // lgn_showPass
            // 
            this.lgn_showPass.AutoSize = true;
            this.lgn_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn_showPass.Location = new System.Drawing.Point(361, 285);
            this.lgn_showPass.Name = "lgn_showPass";
            this.lgn_showPass.Size = new System.Drawing.Size(148, 19);
            this.lgn_showPass.TabIndex = 8;
            this.lgn_showPass.Text = "Mostrar palavra-passe";
            this.lgn_showPass.UseVisualStyleBackColor = true;
            this.lgn_showPass.CheckedChanged += new System.EventHandler(this.lgn_showPass_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 495);
            this.Controls.Add(this.lgn_showPass);
            this.Controls.Add(this.lgn_btn);
            this.Controls.Add(this.lgn_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lgn_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lgn_user;
        private System.Windows.Forms.TextBox lgn_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lgn_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button lgn_registerbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox lgn_showPass;
    }
}

