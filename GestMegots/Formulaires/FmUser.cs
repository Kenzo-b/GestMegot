using GestMegots.Entitees;
using GestMegots.Modeles;

namespace GestMegots.Formulaires;

public partial class FmUser : Form
{
    public FmUser()
    {
        InitializeComponent();
        dataGridView1.DataSource = UserModel.ToutLesUsers();
        cb_service.DataSource = ServiceModele.ToutLesServices();
        this.cb_service.DisplayMember = "nom";
        this.cb_service.ValueMember = "id";
        nud_habLevel.Minimum = 1;
        nud_habLevel.Maximum = 3;
    }

    public User FormToUser()
    {
        return new User.Builder()
            .WithId(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            .WithPseudo(tb_pseudo.Text)
            .WithPasswd(tb_passwd.Text)
            .WithService(ServiceModele.GetServiceById(int.Parse(cb_service.SelectedValue.ToString())))
            .WithHabLevel(int.Parse(nud_habLevel.Value.ToString()))
            .build();
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

    private void btnMaterielClick(object sender, EventArgs e)
    {
        FmMateriel f = new FmMateriel();
        f.Show();
        this.Hide();
    }

    private void btnCollecteClick(object sender, EventArgs e)
    {
        FmCollecte f = new FmCollecte();
        f.Show();
        this.Hide();
    }

    private void button4_Click_1(object sender, EventArgs e)
    {
        User user = FormToUser();
        user.Passwd = Hashing.ToSha256(user.Passwd);
        UserModel.AjouterUser(user);
        ReloadGridView();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        User user = FormToUser();
        if (user.Passwd != UserModel.GetUserById(user.Id).Passwd)
        {
            user.Passwd = Hashing.ToSha256(user.Passwd);
        }
        UserModel.ChangerUser(user);
        ReloadGridView();
    }

    private void bt_dell_Click(object sender, EventArgs e)
    {
        UserModel.SupprimerUser(FormToUser());
        ReloadGridView();
    }
}
