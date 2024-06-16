using System.Text.RegularExpressions;
using GestMegots.Class;
using GestMegots.entities;
using GestMegots.Models;
using static GestMegots.Class.MoveFm;

namespace GestMegots.Formulaires;

public partial class FmUser : Form
{
    public FmUser()
    {
        InitializeComponent();
        lbLogedUser.Text = @$"user: {Session.Pseudo}";
        dataGridView1.DataSource = UserModel.AllUsers();
        cb_service.DataSource = ServiceModel.AllServices();
        cb_service.DisplayMember = "nom";
        cb_service.ValueMember = "id";
        nud_habLevel.Minimum = 1;
        nud_habLevel.Maximum = 3;
    }

    private User FormToUser()
    {
        return new User.Builder()
            .WithId(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            .WithPseudo(tb_pseudo.Text)
            .WithPasswd(tb_passwd.Text)
            .WithService(ServiceModel.GetServiceById(int.Parse(cb_service.SelectedValue.ToString())))
            .WithHabLevel(int.Parse(nud_habLevel.Value.ToString()))
            .build();
    }

    private const string WeakPasswordMsg = @"le mot de passe doit avoir une taille de 12 charactère, soit minimum:\n\n" + 
                                           @"- 3 minuscule,\n" + 
                                           @"- 2 Majuscules,\n" + 
                                           @"- 2 chiffres,\n" + 
                                           @"- 1 Charactère spécial";

    private bool IsEmpty()
    {
        return tb_passwd.Text == string.Empty || tb_pseudo.Text == string.Empty;
    }

    private bool IsStrengthPassword(string password)
    {
        return Regex.Match(password, "^(?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{12}$").Success;
    }

    private void ReloadGridView()
    {
        dataGridView1.DataSource = UserModel.AllUsers();
    }


    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        tb_pseudo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        tb_passwd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        cb_service.SelectedIndex = cb_service.FindStringExact(dataGridView1.CurrentRow.Cells[3].Value.ToString());
        nud_habLevel.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value.ToString());
    }

    private void pictureBox2_Click_1(object sender, EventArgs e)
    {
        Application.Exit();
    }
    
    private void bt_hotspot_Click(object sender, EventArgs e)
    {
        SwitchFm.To(SwitchFm.Forms.FmHotspot);
    }

    private void BtMaterielClick(object sender, EventArgs e)
    {
        SwitchFm.To(SwitchFm.Forms.FmMateriel);
    }

    private void BtCollectClick(object sender, EventArgs e)
    {
        SwitchFm.To(SwitchFm.Forms.FmCollect);
    }
    
    private void lbLogout_Click(object sender, EventArgs e)
    {
        SwitchFm.ToLoginFm();
    }

    private void button4_Click_1(object sender, EventArgs e)
    {
        if(IsEmpty())
        {
            MessageBox.Show(@"Veuillez completer les champs vide");
            return;
        }
        if(UserModel.IsSamePassword(tb_pseudo.Text, tb_pseudo.Text))
        {
            MessageBox.Show(@"ce pseudo est deja utilisé");
            return;
        }
        if (!IsStrengthPassword(tb_passwd.Text))
        {
            MessageBox.Show(WeakPasswordMsg);
            return;
        }
        User user = FormToUser();
        user.Passwd = Hashing.ToSha256(user.Passwd);
        UserModel.AddUser(user);
        ReloadGridView();
        
    }

    private void button6_Click(object sender, EventArgs e)
    {
        if (IsEmpty())
        {
            MessageBox.Show(@"veuillez completer les champs vide");
            return;
        }
        User user = FormToUser();
        if (!UserModel.IsSamePassword(tb_pseudo.Text, tb_passwd.Text)) user.Passwd = Hashing.ToSha256(user.Passwd);
        if (!BtnUtils.VerifyDecision()) return;
        UserModel.UpdateUser(user);
        ReloadGridView();
    }

    private void bt_dell_Click(object sender, EventArgs e)
    { 
        if(!BtnUtils.VerifyDecision()) return;
        UserModel.RemoveUser(FormToUser());
        ReloadGridView();
    }
    
    private void OnMouseMove(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        ReleaseCapture();
        SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
    }
}
