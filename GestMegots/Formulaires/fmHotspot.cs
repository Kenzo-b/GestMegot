using GestMegots.Entitees;
using GestMegots.Modeles;
using System.Text.RegularExpressions;

namespace GestMegots.Formulaires
{
    public partial class FmHotspot : Form
    {
        public FmHotspot()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = HotspotModele.TousLesHotspots();
            this.cb_categorie.DataSource = CategorieModele.ToutesLesCategories();
            this.cb_categorie.DisplayMember = "name";
            this.cb_categorie.ValueMember = "id";
            this.cb_secteur.DataSource = SecteurModele.TousLesSecteurs();
            this.cb_secteur.DisplayMember = "name";
            this.cb_secteur.ValueMember = "id";
            this.cb_materiel.DataSource = MaterielModele.TousLesMateriel();
            this.cb_materiel.DisplayMember = "reference";
            this.cb_materiel.ValueMember = "reference";
        }

        public Hotspot FormToHotspot()
        {
            return new Hotspot.Builder()
                .WithIdHS(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                .WithCoordoGPS(tb_GPS.Text)
                .WithNom(tb_nom.Text)
                .WithAdresse(tb_adresse.Text)
                .WithTerrasse(cb_terrasse.Checked ? 1 : 0)
                .WithLeSecteur(SecteurModele.GetSecteurById(int.Parse(cb_secteur.SelectedValue.ToString())))
                .WithLaCategorie(CategorieModele.GetCategorieById(int.Parse(cb_categorie.SelectedValue.ToString())))
                .WithLeMateriel(MaterielModele.GetMatByid(int.Parse(cb_materiel.SelectedValue.ToString())))
                .Build();
        }
        
        private bool IsValidGps()
        {
            string pattern =
                "^[-+]?([1-8]?\\d(\\.\\d+)?|90(\\.0+)?),\\s*[-+]?(180(\\.0+)?|((1[0-7]\\d)|([1-9]?\\d))(\\.\\d+)?)$";
            Match m = Regex.Match(tb_GPS.Text, pattern);
            return m.Success;
        }

        private bool IsEmpty()
        {
            return tb_adresse.Text == string.Empty || tb_GPS.Text == string.Empty || tb_nom.Text == string.Empty;
        }

        private void ReloadGridView()
        {
            dataGridView1.DataSource = HotspotModele.TousLesHotspots();
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
        
        private void bt_User_Click(object sender, EventArgs e)
        {
            FmUser f = new FmUser();
            f.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!IsEmpty() && IsValidGps())
            {
                HotspotModele.AjoutHotspot(FormToHotspot());
                ReloadGridView();
            }
            else
            {
                MessageBox.Show("champs vide ou valeur incorrecte");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!IsEmpty() && IsValidGps())
            {
                HotspotModele.ModifierHotspot(FormToHotspot());
                ReloadGridView();
            }
            else
            {
                MessageBox.Show("champs vide ou valeur incorrecte");
            }
        }

        private void bt_dell_Click(object sender, EventArgs e)
        {
            HotspotModele.SupprimerHotspot(FormToHotspot());
            ReloadGridView();
        }
    }
}