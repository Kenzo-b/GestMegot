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

    private void btLogin_Click(object sender, EventArgs e)
    {
        if (!UserModel.IsSamePassword(tb_pseudo.Text, tb_Mdp.Text))
        {
            MessageBox.Show(@"pseudo ou mot de passe invalide");
            return;
        }
        User user = UserModel.GetUserByPseudo(tb_pseudo.Text);
        Session.SetSession(user.Ability, true, user.Pseudo);
        SwitchFm.ToDefaultFm();
    }

    private void OnMouseMove(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        ReleaseCapture();
        SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
    }
}