using GestMegots.Class;

namespace GestMegots.Formulaires
{
    partial class FmHotspot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmHotspot));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            cb_materiel = new ComboBox();
            cb_categorie = new ComboBox();
            cb_secteur = new ComboBox();
            cb_terrasse = new CheckBox();
            tb_adresse = new TextBox();
            tb_nom = new TextBox();
            tb_GPS = new TextBox();
            bt_update = new Button();
            bt_dell = new Button();
            bt_add = new Button();
            lbMat = new Label();
            lbCategorie = new Label();
            lbSecteur = new Label();
            lbTerasse = new Label();
            lbNom = new Label();
            lbAdresse = new Label();
            lbCoordo = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            bt_hotspot = new Button();
            bt_materiel = new Button();
            bt_collect = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            bt_user = new Button();
            lbLogout = new Label();
            lbLogedUser = new Label();
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
            panel2.Controls.Add(cb_materiel);
            panel2.Controls.Add(cb_categorie);
            panel2.Controls.Add(cb_secteur);
            panel2.Controls.Add(cb_terrasse);
            panel2.Controls.Add(tb_adresse);
            panel2.Controls.Add(tb_nom);
            panel2.Controls.Add(tb_GPS);
            panel2.Controls.Add(bt_update);
            panel2.Controls.Add(bt_dell);
            panel2.Controls.Add(bt_add);
            panel2.Controls.Add(lbMat);
            panel2.Controls.Add(lbCategorie);
            panel2.Controls.Add(lbSecteur);
            panel2.Controls.Add(lbTerasse);
            panel2.Controls.Add(lbNom);
            panel2.Controls.Add(lbAdresse);
            panel2.Controls.Add(lbCoordo);
            panel2.Location = new Point(36, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 185);
            panel2.TabIndex = 9;
            // 
            // cb_materiel
            // 
            cb_materiel.FlatStyle = FlatStyle.Flat;
            cb_materiel.FormattingEnabled = true;
            cb_materiel.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_materiel.Location = new Point(529, 109);
            cb_materiel.Name = "cb_materiel";
            cb_materiel.Size = new Size(150, 23);
            cb_materiel.TabIndex = 28;
            // 
            // cb_categorie
            // 
            cb_categorie.FlatStyle = FlatStyle.Flat;
            cb_categorie.FormattingEnabled = true;
            cb_categorie.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categorie.Location = new Point(529, 76);
            cb_categorie.Name = "cb_categorie";
            cb_categorie.Size = new Size(150, 23);
            cb_categorie.TabIndex = 27;
            // 
            // cb_secteur
            // 
            cb_secteur.FlatStyle = FlatStyle.Flat;
            cb_secteur.FormattingEnabled = true;
            cb_secteur.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_secteur.Location = new Point(529, 45);
            cb_secteur.Name = "cb_secteur";
            cb_secteur.Size = new Size(150, 23);
            cb_secteur.TabIndex = 26;
            // 
            // cb_terrasse
            // 
            cb_terrasse.AutoSize = true;
            cb_terrasse.FlatStyle = FlatStyle.Flat;
            cb_terrasse.Location = new Point(529, 14);
            cb_terrasse.Name = "cb_terrasse";
            cb_terrasse.Size = new Size(12, 11);
            cb_terrasse.TabIndex = 25;
            cb_terrasse.UseVisualStyleBackColor = true;
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
            // tb_nom
            // 
            tb_nom.BackColor = Color.White;
            tb_nom.BorderStyle = BorderStyle.None;
            tb_nom.Location = new Point(154, 47);
            tb_nom.Name = "tb_nom";
            tb_nom.Size = new Size(164, 16);
            tb_nom.TabIndex = 23;
            // 
            // tb_GPS
            // 
            tb_GPS.BackColor = Color.White;
            tb_GPS.BorderStyle = BorderStyle.None;
            tb_GPS.Location = new Point(154, 14);
            tb_GPS.Name = "tb_GPS";
            tb_GPS.Size = new Size(164, 16);
            tb_GPS.TabIndex = 22;
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
            // lbMat
            // 
            lbMat.AutoSize = true;
            lbMat.ForeColor = Color.DarkOliveGreen;
            lbMat.Location = new Point(464, 109);
            lbMat.Name = "lbMat";
            lbMat.Size = new Size(50, 15);
            lbMat.TabIndex = 18;
            lbMat.Text = "Matériel";
            // 
            // lbCategorie
            // 
            lbCategorie.AutoSize = true;
            lbCategorie.ForeColor = Color.DarkOliveGreen;
            lbCategorie.Location = new Point(464, 76);
            lbCategorie.Name = "lbCategorie";
            lbCategorie.Size = new Size(58, 15);
            lbCategorie.TabIndex = 17;
            lbCategorie.Text = "Catégorie";
            // 
            // lbSecteur
            // 
            lbSecteur.AutoSize = true;
            lbSecteur.ForeColor = Color.DarkOliveGreen;
            lbSecteur.Location = new Point(464, 47);
            lbSecteur.Name = "lbSecteur";
            lbSecteur.Size = new Size(46, 15);
            lbSecteur.TabIndex = 16;
            lbSecteur.Text = "Secteur";
            // 
            // lbTerasse
            // 
            lbTerasse.AutoSize = true;
            lbTerasse.ForeColor = Color.DarkOliveGreen;
            lbTerasse.Location = new Point(464, 14);
            lbTerasse.Name = "lbTerasse";
            lbTerasse.Size = new Size(48, 15);
            lbTerasse.TabIndex = 15;
            lbTerasse.Text = "Terrasse";
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.ForeColor = Color.DarkOliveGreen;
            lbNom.Location = new Point(44, 43);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(34, 15);
            lbNom.TabIndex = 14;
            lbNom.Text = "Nom";
            // 
            // lbAdresse
            // 
            lbAdresse.AutoSize = true;
            lbAdresse.ForeColor = Color.DarkOliveGreen;
            lbAdresse.Location = new Point(44, 76);
            lbAdresse.Name = "lbAdresse";
            lbAdresse.Size = new Size(48, 15);
            lbAdresse.TabIndex = 13;
            lbAdresse.Text = "Adresse";
            // 
            // lbCoordo
            // 
            lbCoordo.AutoSize = true;
            lbCoordo.ForeColor = Color.DarkOliveGreen;
            lbCoordo.Location = new Point(44, 14);
            lbCoordo.Name = "lbCoordo";
            lbCoordo.Size = new Size(102, 15);
            lbCoordo.TabIndex = 12;
            lbCoordo.Text = "Coordonnées GPS";
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
            label2.Size = new Size(222, 30);
            label2.TabIndex = 0;
            label2.Text = "Gestion des Hotspots";
            // 
            // bt_hotspot
            // 
            bt_hotspot.BackColor = Color.LemonChiffon;
            bt_hotspot.Enabled = false;
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
            // bt_Collect
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
            bt_user.TabIndex = 8;
            bt_user.Text = "Utilisateur";
            bt_user.UseVisualStyleBackColor = false;
            bt_user.Click += bt_User_Click;
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
            // FmHotspot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1183, 740);
            Controls.Add(lbLogedUser);
            Controls.Add(lbLogout);
            Controls.Add(bt_user);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(bt_collect);
            Controls.Add(bt_materiel);
            Controls.Add(bt_hotspot);
            Controls.Add(panel1);
            this.Load += (object DatagramSender, EventArgs e) => BtnUtils.SetButtonVisibility(this);
            MouseMove += OnMouseMove;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FmHotspot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
        private Label lbMat;
        private Label lbCategorie;
        private Label lbSecteur;
        private Label lbTerasse;
        private Label lbNom;
        private Label lbAdresse;
        private Label lbCoordo;
        private ComboBox cb_materiel;
        private ComboBox cb_categorie;
        private ComboBox cb_secteur;
        private CheckBox cb_terrasse;
        private TextBox tb_adresse;
        private TextBox tb_nom;
        private TextBox tb_GPS;
        private PictureBox pictureBox2;
        private Button bt_user;
        private Label lbLogout;
        private Label lbLogedUser;
    }
}