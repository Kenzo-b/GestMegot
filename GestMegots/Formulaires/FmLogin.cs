using System.Diagnostics;
using GestMegots.Class;
using GestMegots.Entitees;
using GestMegots.Modeles;

namespace GestMegots.Formulaires;

public partial class FmLogin : Form
{
    public FmLogin()
    {
        InitializeComponent();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private static void LoadForm()
    {
        switch (Session.SessionHab)
        {
            case 1:
                SwitchFm.To(SwitchFm.Forms.FmCollecte);
                break;
            case 2:
                SwitchFm.To(SwitchFm.Forms.FmHotspot);
                break;
            case 3:
                SwitchFm.To(SwitchFm.Forms.FmUser);
                break;
        }
    }

    private void Login()
    {
        User user = UserModel.GetUserByPseudo(tb_pseudo.Text);
        if (user.Passwd == Hashing.ToSha256(tb_Mdp.Text))
        {
            Session.SetSession(user.Habilitation, true, user.Pseudo);
            LoadForm();
        }
        else
        {
            MessageBox.Show("pseudo ou mot de passe invalide");
        }
    }

    private void btLogin_Click(object sender, EventArgs e)
    {
        Login();
    }
}