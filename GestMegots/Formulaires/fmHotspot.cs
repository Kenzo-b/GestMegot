using GestMegots.Entitees;
using System.Text.RegularExpressions;
using GestMegots.Class;
using GestMegots.Models;
using static GestMegots.Class.MoveFm;

namespace GestMegots.Formulaires
{
    public partial class FmHotspot : Form
    {
        public FmHotspot()
        {
            InitializeComponent();
            this.lbLogedUser.Text = @$"user: {Session.Pseudo}";
            this.dataGridView1.DataSource = HotspotModel.AllHotspots();
            this.cb_categorie.DataSource = CategoryModel.AllCategory();
            this.cb_categorie.DisplayMember = "name";
            this.cb_categorie.ValueMember = "id";
            this.cb_secteur.DataSource = SectorModel.AllSectors();
            this.cb_secteur.DisplayMember = "name";
            this.cb_secteur.ValueMember = "id";
            this.cb_materiel.DataSource = MaterielModel.AllMateriel();
            this.cb_materiel.DisplayMember = "reference";
            this.cb_materiel.ValueMember = "reference";
        }

        private Hotspot FormToHotspot()
        {
            return new Hotspot.Builder()
                .WithIdHS(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                .WithCoordoGPS(tb_GPS.Text)
                .WithNom(tb_nom.Text)
                .WithAdresse(tb_adresse.Text)
                .WithTerrasse(cb_terrasse.Checked ? 1 : 0)
                .WithLeSecteur(SectorModel.GetSectorById(int.Parse(cb_secteur.SelectedValue.ToString())))
                .WithLaCategorie(CategoryModel.GetCategoryById(int.Parse(cb_categorie.SelectedValue.ToString())))
                .WithLeMateriel(MaterielModel.GetMatById(int.Parse(cb_materiel.SelectedValue.ToString())))
                .Build();
        }

        private bool IsValidGps()
        {
            return Regex.Match(tb_GPS.Text, "^[-+]?([1-8]?\\d(\\.\\d+)?|90(\\.0+)?),\\s*[-+]?(180(\\.0+)?|((1[0-7]\\d)|([1-9]?\\d))(\\.\\d+)?)$").Success;
        }

        private bool IsEmpty()
        {
            return tb_adresse.Text == string.Empty || tb_GPS.Text == string.Empty || tb_nom.Text == string.Empty;
        }

        private void ReloadGridView()
        {
            dataGridView1.DataSource = HotspotModel.AllHotspots();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_GPS.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_nom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_adresse.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cb_terrasse.Checked = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) == 1;
            cb_secteur.SelectedIndex = cb_secteur.FindStringExact(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            cb_categorie.SelectedIndex = cb_categorie.FindStringExact(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            cb_materiel.SelectedIndex = cb_materiel.FindStringExact(dataGridView1.CurrentRow.Cells[7].Value.ToString());
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtMaterielClick(object sender, EventArgs e)
        {
            SwitchFm.To(SwitchFm.Forms.FmMateriel);
        }

        private void BtCollectClick(object sender, EventArgs e)
        {
            SwitchFm.To(SwitchFm.Forms.FmCollect);
        }

        private void bt_User_Click(object sender, EventArgs e)
        {
            SwitchFm.To(SwitchFm.Forms.FmUser);
        }
        
        private void lbLogout_Click(object sender, EventArgs e)
        {
            SwitchFm.ToLoginFm();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (IsEmpty() || !IsValidGps())
            {
                MessageBox.Show(@"champs vide ou valeur incorrecte");
                return;
            }
            HotspotModel.AddHotspot(FormToHotspot());
            ReloadGridView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsEmpty() || !IsValidGps())
            {
                MessageBox.Show(@"champs vide ou valeur incorrecte");
                return;
            }
            if (!BtnUtils.VerifyDecision()) return;
            HotspotModel.UpdateHotspot(FormToHotspot());
            ReloadGridView();
        }

        private void bt_dell_Click(object sender, EventArgs e)
        {
            if (!BtnUtils.VerifyDecision()) return;
            HotspotModel.RemoveHotspot(FormToHotspot());
            ReloadGridView();
        }
        
        private void OnMouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }
    }
}