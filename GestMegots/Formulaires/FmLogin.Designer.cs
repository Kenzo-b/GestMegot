using System.ComponentModel;

namespace GestMegots.Formulaires;

partial class FmLogin
{
    /// <summary>
    /// Required designer variable.
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FmLogin));
        panel1 = new Panel();
        pictureBox2 = new PictureBox();
        panel2 = new Panel();
        tb_Mdp = new TextBox();
        tb_pseudo = new TextBox();
        label2 = new Label();
        lbPseudo = new Label();
        lbMdp = new Label();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        btLogin = new Button();
        panel1.SuspendLayout();
        ((ISupportInitialize)pictureBox2).BeginInit();
        panel2.SuspendLayout();
        ((ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.LemonChiffon;
        panel1.Controls.Add(pictureBox2);
        panel1.Controls.Add(panel2);
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
        panel2.Controls.Add(btLogin);
        panel2.Controls.Add(tb_Mdp);
        panel2.Controls.Add(tb_pseudo);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(lbPseudo);
        panel2.Controls.Add(lbMdp);
        panel2.Location = new Point(36, 99);
        panel2.Name = "panel2";
        panel2.Size = new Size(841, 554);
        panel2.TabIndex = 9;
        // 
        // tb_Mdp
        // 
        tb_Mdp.BackColor = Color.White;
        tb_Mdp.BorderStyle = BorderStyle.None;
        tb_Mdp.Location = new Point(324, 265);
        tb_Mdp.Name = "tb_Mdp";
        tb_Mdp.Size = new Size(242, 16);
        tb_Mdp.TabIndex = 31;
        // 
        // tb_pseudo
        // 
        tb_pseudo.BackColor = Color.White;
        tb_pseudo.BorderStyle = BorderStyle.None;
        tb_pseudo.Location = new Point(324, 199);
        tb_pseudo.Name = "tb_pseudo";
        tb_pseudo.Size = new Size(242, 16);
        tb_pseudo.TabIndex = 30;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.DarkGreen;
        label2.Location = new Point(380, 102);
        label2.Name = "label2";
        label2.Size = new Size(120, 30);
        label2.TabIndex = 0;
        label2.Text = "Connexion";
        // 
        // lbPseudo
        // 
        lbPseudo.AutoSize = true;
        lbPseudo.ForeColor = Color.DarkOliveGreen;
        lbPseudo.Location = new Point(212, 199);
        lbPseudo.Name = "lbPseudo";
        lbPseudo.Size = new Size(46, 15);
        lbPseudo.TabIndex = 29;
        lbPseudo.Text = "Pseudo";
        // 
        // lbMdp
        // 
        lbMdp.AutoSize = true;
        lbMdp.ForeColor = Color.DarkOliveGreen;
        lbMdp.Location = new Point(181, 265);
        lbMdp.Name = "lbMdp";
        lbMdp.Size = new Size(77, 15);
        lbMdp.TabIndex = 16;
        lbMdp.Text = "Mot de passe";
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
        // btLogin
        // 
        btLogin.BackColor = Color.DarkOliveGreen;
        btLogin.FlatStyle = FlatStyle.Flat;
        btLogin.ForeColor = Color.LemonChiffon;
        btLogin.Location = new Point(324, 325);
        btLogin.Name = "btLogin";
        btLogin.Size = new Size(242, 30);
        btLogin.TabIndex = 21;
        btLogin.Text = "login";
        btLogin.UseVisualStyleBackColor = false;
        btLogin.Click += btLogin_Click;
        // 
        // FmLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkOliveGreen;
        ClientSize = new Size(1183, 740);
        Controls.Add(pictureBox1);
        Controls.Add(label1);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form2";
        panel1.ResumeLayout(false);
        ((ISupportInitialize)pictureBox2).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Label label2;
    private PictureBox pictureBox1;
    private Panel panel2;
    private PictureBox pictureBox2;
    private Label lbMdp;
    private Label lbPseudo;
    private TextBox tb_Mdp;
    private TextBox tb_pseudo;
    private Button btLogin;
}