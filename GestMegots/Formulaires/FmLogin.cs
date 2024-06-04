using GestMegots.Class;
using GestMegots.Entitees;
using GestMegots.Models;
using static GestMegots.Class.MoveFm;

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
                SwitchFm.To(SwitchFm.Forms.FmCollect);
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

    private void OnMouseMove(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        ReleaseCapture();
        SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
    }
}