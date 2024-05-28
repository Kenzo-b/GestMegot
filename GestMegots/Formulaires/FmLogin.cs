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

    private User FormToUser()
    {
        return UserModel.GetUserByPseudo(tb_pseudo.Text);
    }

    private void loadForm()
    {
        switch (Session.SessionHab)
        {
            case 1:
                break;
        }
    }

    private void Loging()
    {
        User user = UserModel.GetUserByPseudo(tb_pseudo.Text);
        if (user.Passwd == Hashing.ToSha256(tb_pseudo.Text))
        {
            Session.SessionHab = user.Habilitation;
            Session.LoggedIn = true;
        }
        else
        {
            MessageBox.Show("pseudo ou mot de passe invalide");
        }
    }
    
}