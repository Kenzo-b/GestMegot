using GestMegots.Class;
using GestMegots.Entitees;
using GestMegots.Models;
using Org.BouncyCastle.Asn1.Cmp;
using static GestMegots.Class.MoveFm;

namespace GestMegots.Formulaires;

public partial class FmUser : Form
{
    public FmUser()
    {
        InitializeComponent();
        lbLogedUser.Text = @$"user: {Session.Pseudo}";
        dataGridView1.DataSource = UserModel.ToutLesUsers();
        cb_service.DataSource = ServiceModele.ToutLesServices();
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
            .WithService(ServiceModele.GetServiceById(int.Parse(cb_service.SelectedValue.ToString())))
            .WithHabLevel(int.Parse(nud_habLevel.Value.ToString()))
            .build();
    }

    private bool IsEmpty()
    {
        return tb_passwd.Text == string.Empty || tb_pseudo.Text == string.Empty;
    }

    private void ReloadGridView()
    {
        dataGridView1.DataSource = UserModel.ToutLesUsers();
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

    private void button4_Click_1(object sender, EventArgs e)
    {
        if (!IsEmpty())
        {
            User user = FormToUser();
            user.Passwd = Hashing.ToSha256(user.Passwd);
            UserModel.AjouterUser(user);
            ReloadGridView();
        }
        else
        {
            MessageBox.Show(@"veuillez completer les champs vide");
        }
    }

    private void button6_Click(object sender, EventArgs e)
    {
        if (!IsEmpty())
        {
            User user = FormToUser();
            if (user.Passwd != UserModel.GetUserById(user.Id).Passwd)
            {
                user.Passwd = Hashing.ToSha256(user.Passwd);
            }
            if (!BtnUtils.VerifyDecision()) return;
            UserModel.ChangerUser(user);
            ReloadGridView();
        }
        else
        {
            MessageBox.Show(@"veuillez completer les champs vide");
        }
    }

    private void bt_dell_Click(object sender, EventArgs e)
    { 
        if(!BtnUtils.VerifyDecision()) return;
        UserModel.SupprimerUser(FormToUser());
        ReloadGridView();
    }
    
    private void lbLogout_Click(object sender, EventArgs e)
    {
        Session.UnsetSession();
        SwitchFm.To(SwitchFm.Forms.FmLogin);
    }
    
    private void OnMouseMove(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        ReleaseCapture();
        SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
    }
}
