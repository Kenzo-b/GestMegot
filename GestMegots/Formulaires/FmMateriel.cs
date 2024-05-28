using GestMegots.Entitees;
using GestMegots.Modeles;
using System.Text.RegularExpressions;
using GestMegots.Class;

namespace GestMegots.Formulaires
{
    public partial class FmMateriel : Form
    {
        public FmMateriel()
        {
            InitializeComponent();
            dataGridView1.DataSource = MaterielModele.TousLesMateriel();
            this.cb_type.DataSource = TypeModele.ToutLesTypes();
            this.cb_type.DisplayMember = "Libelle";
            this.cb_type.ValueMember = "idType";
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_couleur.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_adresse.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_GPS.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cb_type.SelectedIndex = cb_type.FindStringExact(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            cb_op.Checked = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()) == 1;
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
            return tb_GPS.Text == string.Empty || tb_adresse.Text == string.Empty || tb_couleur.Text == string.Empty;
        }

        private void ReloadGridView()
        {
            dataGridView1.DataSource = MaterielModele.TousLesMateriel();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_hotspot_Click(object sender, EventArgs e)
        {
            SwitchFm.To(SwitchFm.Forms.FmHotspot);
        }
        
        private void BtnCollecteClick(object sender, EventArgs e)
        {
            SwitchFm.To(SwitchFm.Forms.FmCollecte);
        }
        
        private void bt_User_Click(object sender, EventArgs e)
        {
            SwitchFm.To(SwitchFm.Forms.FmUser);
        }

        private Materiel FormToMat()
        {
            return new Materiel.Builder()
                .WithReference(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                .WithCouleur(tb_couleur.Text)
                .WithDateInstal(DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()))
                .WithAdresse(tb_adresse.Text)
                .WithCoordoGPS(tb_GPS.Text)
                .WithLeType(TypeModele.GetTypeMaterielById(int.Parse(cb_type.SelectedValue.ToString())))
                .WithOp(cb_op.Checked ? 1 : 0)
                .build();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (!IsEmpty() && IsValidGps())
            {
                Materiel leMat = FormToMat();
                leMat.DateInstal = DateTime.Now;
                MaterielModele.AjouterMateriel(leMat);
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
                MaterielModele.ChangerMateriel(FormToMat());
                ReloadGridView(); 
            }
            else
            {
                MessageBox.Show("champs vide ou valeur incorrecte");            
            }
        }

        private void bt_dell_Click(object sender, EventArgs e)
        {
            MaterielModele.SupprimerMateriel(FormToMat());
            ReloadGridView();
        }
    }
}
