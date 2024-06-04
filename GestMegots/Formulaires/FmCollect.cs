using System.Diagnostics;
using GestMegots.Class;
using GestMegots.Entitees;
using GestMegots.Models;

namespace GestMegots.Formulaires;

public partial class FmCollect : Form
{
    public FmCollect()
    {
        InitializeComponent();
        lbLogedUser.Text = @$"user: {Session.Pseudo}";
        dataGridView1.DataSource = CollectModel.AllCollect();
        this.cb_mat.DataSource = MaterielModele.AllMateriel();
        this.cb_mat.DisplayMember = "reference";
        this.cb_mat.ValueMember = "reference";
        this.NudNbMegot.Minimum = 1;
        this.NudNbMegot.Maximum = Convert.ToDecimal(MaterielModele.GetMatById(int.Parse(cb_mat.SelectedValue.ToString())).LeType.Contenance);
    }

    private void cbMat_IndexChange(object sender, EventArgs e)
    {
        NudNbMegot.Maximum = Convert.ToDecimal(MaterielModele.GetMatById(int.Parse(cb_mat.SelectedValue.ToString())).LeType.Contenance);
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        cb_mat.SelectedIndex = cb_mat.FindStringExact(dataGridView1.CurrentRow.Cells[2].Value.ToString());
        NudNbMegot.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[1].Value.ToString());
    }

    private void ReloadGridView()
    {
        dataGridView1.DataSource = CollectModel.AllCollect();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void bt_hotspot_Click(object sender, EventArgs e)
    {
        SwitchFm.To(SwitchFm.Forms.FmHotspot);
    }

    private void BtnMaterielClick(object sender, EventArgs e)
    {
        SwitchFm.To(SwitchFm.Forms.FmMateriel);
    }
    
    private void bt_User_Click(object sender, EventArgs e)
    {
        SwitchFm.To(SwitchFm.Forms.FmUser);
    }

    private Collecte FormToCollect()
    {
        return new Collecte.Builder()
            .WithId(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            .WithNbMegot(int.Parse(NudNbMegot.Value.ToString()))
            .WithMateriel(MaterielModele.GetMatById(int.Parse(cb_mat.SelectedValue.ToString())))
            .WithDateCollecte(DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()))
            .build();
    }
    private void BtAddClick(object sender, EventArgs e)
    {
        Collecte collect = FormToCollect();
        collect.DateCollecte = DateTime.Now;
        CollectModel.AddCollect(collect);
        ReloadGridView();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        if (!BtnUtils.VerifyDecision()) return;
        CollectModel.UpdateCollect(FormToCollect());
        ReloadGridView();
    }

    private void bt_dell_Click(object sender, EventArgs e)
    {
        if (!BtnUtils.VerifyDecision()) return;
        CollectModel.RemoveCollect(FormToCollect());
        ReloadGridView();
    }

    private void lbLogout_Click(object sender, EventArgs e)
    {
        Session.UnsetSession();
        SwitchFm.To(SwitchFm.Forms.FmLogin);
    }
}