namespace GestMegots.Formulaires
{
    partial class FmMateriel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMateriel));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            cb_type = new ComboBox();
            cb_op = new CheckBox();
            tb_adresse = new TextBox();
            tb_couleur = new TextBox();
            bt_update = new Button();
            bt_dell = new Button();
            button4 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lbLogout = new Label();
            lbLogedUser = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            bt_hotspot = new Button();
            button1 = new Button();
            button2 = new Button();
            bt_User = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tb_GPS = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(276, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 740);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(808, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 45);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tb_GPS);
            panel2.Controls.Add(cb_type);
            panel2.Controls.Add(cb_op);
            panel2.Controls.Add(tb_adresse);
            panel2.Controls.Add(tb_couleur);
            panel2.Controls.Add(bt_update);
            panel2.Controls.Add(bt_dell);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(36, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 185);
            panel2.TabIndex = 9;
            // 
            // cb_type
            // 
            cb_type.FlatStyle = FlatStyle.Flat;
            cb_type.FormattingEnabled = true;
            cb_type.Location = new Point(529, 45);
            cb_type.Name = "cb_type";
            cb_type.Size = new Size(150, 23);
            cb_type.TabIndex = 26;
            // 
            // cb_op
            // 
            cb_op.AutoSize = true;
            cb_op.FlatStyle = FlatStyle.Flat;
            cb_op.Location = new Point(546, 16);
            cb_op.Name = "cb_op";
            cb_op.Size = new Size(12, 11);
            cb_op.TabIndex = 25;
            cb_op.UseVisualStyleBackColor = true;
            // 
            // tb_adresse
            // 
            tb_adresse.BackColor = Color.White;
            tb_adresse.BorderStyle = BorderStyle.None;
            tb_adresse.Location = new Point(154, 76);
            tb_adresse.Multiline = true;
            tb_adresse.Name = "tb_adresse";
            tb_adresse.Size = new Size(164, 48);
            tb_adresse.TabIndex = 24;
            // 
            // tb_couleur
            // 
            tb_couleur.BackColor = Color.White;
            tb_couleur.BorderStyle = BorderStyle.None;
            tb_couleur.Location = new Point(154, 14);
            tb_couleur.Name = "tb_couleur";
            tb_couleur.Size = new Size(164, 16);
            tb_couleur.TabIndex = 22;
            // 
            // bt_update
            // 
            bt_update.BackColor = Color.DarkOliveGreen;
            bt_update.FlatStyle = FlatStyle.Flat;
            bt_update.ForeColor = Color.LemonChiffon;
            bt_update.Location = new Point(604, 150);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(75, 30);
            bt_update.TabIndex = 21;
            bt_update.Text = "&Modifier";
            bt_update.UseVisualStyleBackColor = false;
            bt_update.Click += button6_Click;
            // 
            // bt_dell
            // 
            bt_dell.BackColor = Color.DarkOliveGreen;
            bt_dell.FlatStyle = FlatStyle.Flat;
            bt_dell.ForeColor = Color.LemonChiffon;
            bt_dell.Location = new Point(371, 150);
            bt_dell.Name = "bt_dell";
            bt_dell.Size = new Size(75, 30);
            bt_dell.TabIndex = 20;
            bt_dell.Text = "&Supprimer";
            bt_dell.UseVisualStyleBackColor = false;
            bt_dell.Click += bt_dell_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOliveGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.LemonChiffon;
            button4.Location = new Point(154, 150);
            button4.Name = "button4";
            button4.Size = new Size(75, 30);
            button4.TabIndex = 19;
            button4.Text = "&Ajouter";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DarkOliveGreen;
            label7.Location = new Point(464, 47);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 16;
            label7.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkOliveGreen;
            label6.Location = new Point(464, 14);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 15;
            label6.Text = "Operationnel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkOliveGreen;
            label5.Location = new Point(44, 43);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 14;
            label5.Text = "coordoGPS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(44, 76);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 13;
            label4.Text = "Adresse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(44, 14);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 12;
            label3.Text = "Couleur";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 306);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(841, 372);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(305, 31);
            label2.Name = "label2";
            label2.Size = new Size(223, 30);
            label2.TabIndex = 0;
            label2.Text = "Gestion des Matériels";
            // 
            // bt_hotspot
            // 
            bt_hotspot.BackColor = Color.LemonChiffon;
            bt_hotspot.FlatAppearance.BorderSize = 0;
            bt_hotspot.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            bt_hotspot.FlatStyle = FlatStyle.Flat;
            bt_hotspot.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            bt_hotspot.ForeColor = Color.DarkOliveGreen;
            bt_hotspot.Location = new Point(44, 230);
            bt_hotspot.Name = "bt_hotspot";
            bt_hotspot.Size = new Size(174, 64);
            bt_hotspot.TabIndex = 0;
            bt_hotspot.Text = "Hotspots";
            bt_hotspot.UseVisualStyleBackColor = false;
            bt_hotspot.Click += bt_hotspot_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkOliveGreen;
            button1.Location = new Point(44, 315);
            button1.Name = "button1";
            button1.Size = new Size(174, 64);
            button1.TabIndex = 1;
            button1.Text = "Matériels";
            button1.UseVisualStyleBackColor = false;
            button1.Enabled = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LemonChiffon;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkOliveGreen;
            button2.Location = new Point(44, 400);
            button2.Name = "button2";
            button2.Size = new Size(174, 64);
            button2.TabIndex = 2;
            button2.Text = "Collectes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnCollecteClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 149);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // tb_GPS
            // 
            tb_GPS.BackColor = Color.White;
            tb_GPS.BorderStyle = BorderStyle.None;
            tb_GPS.Location = new Point(154, 42);
            tb_GPS.Name = "tb_GPS";
            tb_GPS.Size = new Size(164, 16);
            tb_GPS.TabIndex = 27;
            // 
            // bt_User
            // 
            bt_User.BackColor = Color.LemonChiffon;
            bt_User.FlatAppearance.BorderSize = 0;
            bt_User.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            bt_User.FlatStyle = FlatStyle.Flat;
            bt_User.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            bt_User.ForeColor = Color.DarkOliveGreen;
            bt_User.Location = new Point(44, 485);
            bt_User.Name = "bt_User";
            bt_User.Size = new Size(174, 64);
            bt_User.TabIndex = 8;
            bt_User.Text = "Utilisateur";
            bt_User.UseVisualStyleBackColor = false;
            bt_User.Click += bt_User_Click;
            // 
            // lbLogout
            // 
            lbLogout.AutoSize = true;
            lbLogout.ForeColor = Color.LemonChiffon;
            lbLogout.Location = new Point(82, 646);
            lbLogout.Name = "lbLogout";
            lbLogout.Size = new Size(87, 15);
            lbLogout.TabIndex = 9;
            lbLogout.Text = "se déconnecter";
            lbLogout.MouseEnter += (object sender, EventArgs e) => lbLogout.ForeColor = Color.DarkGreen;
            lbLogout.MouseLeave += (object sender, EventArgs e) => lbLogout.ForeColor = Color.LemonChiffon;
            lbLogout.Click += lbLogout_Click;
            // 
            // lbLogedUser
            // 
            lbLogedUser.AutoSize = true;
            lbLogedUser.ForeColor = Color.LemonChiffon;
            lbLogedUser.Location = new Point(82, 617);
            lbLogedUser.Name = "lbLogedUser";
            lbLogedUser.Size = new Size(128, 15);
            lbLogedUser.TabIndex = 10;
            lbLogedUser.Text = "";
            // 
            // FmMateriel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1183, 740);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bt_hotspot);
            Controls.Add(bt_User);
            Controls.Add(panel1);
            Controls.Add(lbLogedUser);
            Controls.Add(lbLogout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FmMateriel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button bt_hotspot;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button bt_update;
        private Button bt_dell;
        private Button button4;
        private Button bt_User;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lbLogout;
        private Label lbLogedUser;
        private CheckBox cb_op;
        private TextBox tb_adresse;
        private TextBox tb_couleur;
        private PictureBox pictureBox2;
        private ComboBox cb_type;
        private Label label7;
        private TextBox tb_GPS;
    }
}