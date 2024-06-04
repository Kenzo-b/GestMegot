using GestMegots.Class;

namespace GestMegots.Formulaires
{
    partial class FmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmUser));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            nud_habLevel = new NumericUpDown();
            lb_habLevel = new Label();
            cb_service = new ComboBox();
            tb_passwd = new TextBox();
            tb_pseudo = new TextBox();
            bt_update = new Button();
            bt_dell = new Button();
            bt_add = new Button();
            lbService = new Label();
            lbPasswd = new Label();
            lbPseudo = new Label();
            lbLogout = new Label();
            lbLogedUser = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            bt_hotspot = new Button();
            bt_materiel = new Button();
            bt_collect = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            bt_user = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_habLevel).BeginInit();
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
            panel1.MouseMove += OnMouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(808, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 45);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(nud_habLevel);
            panel2.Controls.Add(lb_habLevel);
            panel2.Controls.Add(cb_service);
            panel2.Controls.Add(tb_passwd);
            panel2.Controls.Add(tb_pseudo);
            panel2.Controls.Add(bt_update);
            panel2.Controls.Add(bt_dell);
            panel2.Controls.Add(bt_add);
            panel2.Controls.Add(lbService);
            panel2.Controls.Add(lbPasswd);
            panel2.Controls.Add(lbPseudo);
            panel2.Location = new Point(36, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 185);
            panel2.TabIndex = 9;
            // 
            // nud_habLevel
            // 
            nud_habLevel.Location = new Point(529, 45);
            nud_habLevel.Name = "nud_habLevel";
            nud_habLevel.Size = new Size(150, 23);
            nud_habLevel.TabIndex = 28;
            nud_habLevel.Controls[1].KeyPress += new KeyPressEventHandler((s, e) => e.Handled = true);
            // 
            // lb_habLevel
            // 
            lb_habLevel.AutoSize = true;
            lb_habLevel.Location = new Point(442, 47);
            lb_habLevel.Name = "lb_habLevel";
            lb_habLevel.Size = new Size(69, 15);
            lb_habLevel.TabIndex = 27;
            lb_habLevel.Text = "Habilitation";
            // 
            // cb_service
            // 
            cb_service.FlatStyle = FlatStyle.Flat;
            cb_service.FormattingEnabled = true;
            cb_service.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_service.Location = new Point(529, 15);
            cb_service.Name = "cb_service";
            cb_service.Size = new Size(150, 23);
            cb_service.TabIndex = 26;
            // 
            // tb_passwd
            // 
            tb_passwd.BackColor = Color.White;
            tb_passwd.BorderStyle = BorderStyle.None;
            tb_passwd.Location = new Point(154, 47);
            tb_passwd.Name = "tb_passwd";
            tb_passwd.Size = new Size(164, 16);
            tb_passwd.TabIndex = 23;
            // 
            // tb_pseudo
            // 
            tb_pseudo.BackColor = Color.White;
            tb_pseudo.BorderStyle = BorderStyle.None;
            tb_pseudo.Location = new Point(154, 14);
            tb_pseudo.Name = "tb_pseudo";
            tb_pseudo.Size = new Size(164, 16);
            tb_pseudo.TabIndex = 22;
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
            // bt_add
            // 
            bt_add.BackColor = Color.DarkOliveGreen;
            bt_add.FlatStyle = FlatStyle.Flat;
            bt_add.ForeColor = Color.LemonChiffon;
            bt_add.Location = new Point(154, 150);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 30);
            bt_add.TabIndex = 19;
            bt_add.Text = "&Ajouter";
            bt_add.UseVisualStyleBackColor = false;
            bt_add.Click += button4_Click_1;
            // 
            // lbService
            // 
            lbService.AutoSize = true;
            lbService.ForeColor = Color.DarkOliveGreen;
            lbService.Location = new Point(465, 15);
            lbService.Name = "lbService";
            lbService.Size = new Size(44, 15);
            lbService.TabIndex = 16;
            lbService.Text = "Service";
            // 
            // lbPasswd
            // 
            lbPasswd.AutoSize = true;
            lbPasswd.ForeColor = Color.DarkOliveGreen;
            lbPasswd.Location = new Point(44, 43);
            lbPasswd.Name = "lbPasswd";
            lbPasswd.Size = new Size(77, 15);
            lbPasswd.TabIndex = 14;
            lbPasswd.Text = "mot de passe";
            // 
            // lbPseudo
            // 
            lbPseudo.AutoSize = true;
            lbPseudo.ForeColor = Color.DarkOliveGreen;
            lbPseudo.Location = new Point(44, 14);
            lbPseudo.Name = "lbPseudo";
            lbPseudo.Size = new Size(46, 15);
            lbPseudo.TabIndex = 12;
            lbPseudo.Text = "pseudo";
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
            label2.Size = new Size(234, 30);
            label2.TabIndex = 0;
            label2.Text = "Gestion des Utilisateur";
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
            // bt_materiel
            // 
            bt_materiel.BackColor = Color.LemonChiffon;
            bt_materiel.FlatAppearance.BorderSize = 0;
            bt_materiel.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            bt_materiel.FlatStyle = FlatStyle.Flat;
            bt_materiel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            bt_materiel.ForeColor = Color.DarkOliveGreen;
            bt_materiel.Location = new Point(44, 315);
            bt_materiel.Name = "bt_materiel";
            bt_materiel.Size = new Size(174, 64);
            bt_materiel.TabIndex = 1;
            bt_materiel.Text = "Matériels";
            bt_materiel.UseVisualStyleBackColor = false;
            bt_materiel.Click += BtMaterielClick;
            // 
            // bt_collect
            // 
            bt_collect.BackColor = Color.LemonChiffon;
            bt_collect.FlatAppearance.BorderSize = 0;
            bt_collect.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            bt_collect.FlatStyle = FlatStyle.Flat;
            bt_collect.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            bt_collect.ForeColor = Color.DarkOliveGreen;
            bt_collect.Location = new Point(44, 400);
            bt_collect.Name = "bt_collect";
            bt_collect.Size = new Size(174, 64);
            bt_collect.TabIndex = 2;
            bt_collect.Text = "Collectes";
            bt_collect.UseVisualStyleBackColor = false;
            bt_collect.Click += BtCollectClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
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
            // bt_user
            // 
            bt_user.BackColor = Color.LemonChiffon;
            bt_user.FlatAppearance.BorderSize = 0;
            bt_user.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            bt_user.FlatStyle = FlatStyle.Flat;
            bt_user.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            bt_user.ForeColor = Color.DarkOliveGreen;
            bt_user.Location = new Point(44, 485);
            bt_user.Name = "bt_user";
            bt_user.Size = new Size(174, 64);
            bt_user.TabIndex = 7;
            bt_user.Text = "Utilisateur";
            bt_user.UseVisualStyleBackColor = false;
            bt_user.Enabled = false;
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
            // FmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1183, 740);
            Controls.Add(bt_user);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(bt_collect);
            Controls.Add(bt_materiel);
            Controls.Add(bt_hotspot);
            Controls.Add(lbLogout);
            Controls.Add(lbLogedUser);
            Controls.Add(panel1);
            this.Load += (object DatagramSender, EventArgs e) => BtnUtils.SetButtonVisibility(this);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_habLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MouseMove += OnMouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button bt_hotspot;
        private Button bt_materiel;
        private Button bt_collect;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button bt_update;
        private Button bt_dell;
        private Button bt_add;
        private Label lbService;
        private Label lbPasswd;
        private Label lbPseudo;
        private Label lbLogout;
        private Label lbLogedUser;
        private ComboBox cb_service;
        private TextBox tb_passwd;
        private TextBox tb_pseudo;
        private PictureBox pictureBox2;
        private NumericUpDown nud_habLevel;
        private Label lb_habLevel;
        private Button bt_user;
    }
}