using System.Diagnostics;
using GestMegots.Class;
using GestMegots.Entitees;
using GestMegots.Modeles;

namespace GestMegots.Formulaires;

public partial class FmCollecte : Form
{
    public FmCollecte()
    {
        InitializeComponent();
        dataGridView1.DataSource = CollecteModele.ToutesLesCollecte();
        this.cb_mat.DataSource = MaterielModele.TousLesMateriel();
        this.cb_mat.DisplayMember = "reference";
        this.cb_mat.ValueMember = "reference";
        this.NudNbMegot.Minimum = 1;
        this.NudNbMegot.Maximum = Convert.ToDecimal(MaterielModele.GetMatByid(int.Parse(cb_mat.SelectedValue.ToString())).LeType.Contenance);
    }

    private void cbMat_IndexChange(object sender, EventArgs e)
    {
        NudNbMegot.Maximum = Convert.ToDecimal(MaterielModele.GetMatByid(int.Parse(cb_mat.SelectedValue.ToString())).LeType.Contenance);
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        cb_mat.SelectedIndex = cb_mat.FindStringExact(dataGridView1.CurrentRow.Cells[2].Value.ToString());
        NudNbMegot.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[1].Value.ToString());
    }

    private void ReloadGridView()
    {
        dataGridView1.DataSource = CollecteModele.ToutesLesCollecte();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void bt_hotspot_Click(object sender, EventArgs e)
    {
        SwitchFm.To(SwitchFm.Forms.FmHotspot);
    }

    private void btnMaterielClick(object sender, EventArgs e)
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
            .WithMateriel(MaterielModele.GetMatByid(int.Parse(cb_mat.SelectedValue.ToString())))
            .WithDateCollecte(DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()))
            .build();
    }
    private void button4_Click(object sender, EventArgs e)
    {
        Collecte laCollecte = FormToCollect();
        laCollecte.DateCollecte = DateTime.Now;
        CollecteModele.AjouterCollect(laCollecte);
        ReloadGridView();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        CollecteModele.ModifierCollect(FormToCollect());
        ReloadGridView();
    }

    private void bt_dell_Click(object sender, EventArgs e)
    {
        CollecteModele.SuppCollecte(FormToCollect());
        ReloadGridView();
    }
}