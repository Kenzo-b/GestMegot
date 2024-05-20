using System.ComponentModel;

namespace GestMegots.Formulaires;

partial class FmCollecte
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FmCollecte));
        panel1 = new Panel();
        pictureBox2 = new PictureBox();
        panel2 = new Panel();
        cb_mat = new ComboBox();
        bt_update = new Button();
        bt_dell = new Button();
        button4 = new Button();
        lbMat = new Label();
        dataGridView1 = new DataGridView();
        label2 = new Label();
        bt_hotspot = new Button();
        button1 = new Button();
        button2 = new Button();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        lbNbMegot = new Label();
        NudNbMegot = new NumericUpDown();
        panel1.SuspendLayout();
        ((ISupportInitialize)pictureBox2).BeginInit();
        panel2.SuspendLayout();
        ((ISupportInitialize)dataGridView1).BeginInit();
        ((ISupportInitialize)pictureBox1).BeginInit();
        ((ISupportInitialize)NudNbMegot).BeginInit();
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
        panel2.Controls.Add(NudNbMegot);
        panel2.Controls.Add(lbNbMegot);
        panel2.Controls.Add(cb_mat);
        panel2.Controls.Add(bt_update);
        panel2.Controls.Add(bt_dell);
        panel2.Controls.Add(button4);
        panel2.Controls.Add(lbMat);
        panel2.Location = new Point(36, 99);
        panel2.Name = "panel2";
        panel2.Size = new Size(841, 185);
        panel2.TabIndex = 9;
        // 
        // cb_mat
        // 
        cb_mat.FlatStyle = FlatStyle.Flat;
        cb_mat.FormattingEnabled = true;
        cb_mat.Location = new Point(341, 42);
        cb_mat.Name = "cb_mat";
        cb_mat.Size = new Size(150, 23);
        cb_mat.TabIndex = 26;
        cb_mat.SelectedIndexChanged += cbMat_IndexChange;
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
        // lbMat
        // 
        lbMat.AutoSize = true;
        lbMat.ForeColor = Color.DarkOliveGreen;
        lbMat.Location = new Point(268, 45);
        lbMat.Name = "lbMat";
        lbMat.Size = new Size(50, 15);
        lbMat.TabIndex = 16;
        lbMat.Text = "Materiel";
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
        bt_hotspot.Location = new Point(44, 281);
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
        button1.Location = new Point(44, 375);
        button1.Name = "button1";
        button1.Size = new Size(174, 64);
        button1.TabIndex = 1;
        button1.Text = "Matériels";
        button1.UseVisualStyleBackColor = false;
        button1.Click += btnMaterielClick;
        // 
        // button2
        // 
        button2.BackColor = Color.LemonChiffon;
        button2.Enabled = false;
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        button2.ForeColor = Color.DarkOliveGreen;
        button2.Location = new Point(44, 476);
        button2.Name = "button2";
        button2.Size = new Size(174, 64);
        button2.TabIndex = 2;
        button2.Text = "Collectes";
        button2.UseVisualStyleBackColor = false;
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
        // lbNbMegot
        // 
        lbNbMegot.AutoSize = true;
        lbNbMegot.ForeColor = Color.DarkOliveGreen;
        lbNbMegot.Location = new Point(210, 84);
        lbNbMegot.Name = "lbNbMegot";
        lbNbMegot.Size = new Size(108, 15);
        lbNbMegot.TabIndex = 29;
        lbNbMegot.Text = "nombre de mégots";
        // 
        // NudNbMegot
        // 
        NudNbMegot.BorderStyle = BorderStyle.None;
        NudNbMegot.Location = new Point(341, 82);
        NudNbMegot.Name = "NudNbMegot";
        NudNbMegot.Size = new Size(150, 19);
        NudNbMegot.TabIndex = 30;
        // 
        // FmCollecte
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
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FmCollecte";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form2";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((ISupportInitialize)pictureBox2).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((ISupportInitialize)dataGridView1).EndInit();
        ((ISupportInitialize)pictureBox1).EndInit();
        ((ISupportInitialize)NudNbMegot).EndInit();
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
    private PictureBox pictureBox2;
    private ComboBox cb_mat;
    private Label lbMat;
    private Label lbNbMegot;
    private NumericUpDown NudNbMegot;
}