using GestMegots.Entitees;
using System.Text.RegularExpressions;
using GestMegots.Class;
using GestMegots.Models;
using static GestMegots.Class.MoveFm;

namespace GestMegots.Formulaires
{
    public partial class FmMateriel : Form
    {
        public FmMateriel()
        {
            InitializeComponent();
            lbLogedUser.Text = $"user: {Session.Pseudo}";
            dataGridView1.DataSource = MaterielModele.AllMateriel();
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
            return Regex.Match(tb_GPS.Text, "^[-+]?([1-8]?\\d(\\.\\d+)?|90(\\.0+)?),\\s*[-+]?(180(\\.0+)?|((1[0-7]\\d)|([1-9]?\\d))(\\.\\d+)?)$").Success;
        }

        private bool IsEmpty()
        {
            return tb_GPS.Text == string.Empty || tb_adresse.Text == string.Empty || tb_couleur.Text == string.Empty;
        }

        private void ReloadGridView()
        {
            dataGridView1.DataSource = MaterielModele.AllMateriel();
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
        private void BtAddClick(object sender, EventArgs e)
        {
            if (IsEmpty() || !IsValidGps())
            {
                MessageBox.Show("champs vide ou valeur incorrecte");
            }
            Materiel leMat = FormToMat();
            leMat.DateInstal = DateTime.Now;
            MaterielModele.AddMateriel(leMat);
            ReloadGridView(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsEmpty() || !IsValidGps())
            {
                MessageBox.Show("champs vide ou valeur incorrecte");  
                return;
            }
            if (!BtnUtils.VerifyDecision()) return;
            MaterielModele.UpdateMateriel(FormToMat());
            ReloadGridView(); 
        }

        private void bt_dell_Click(object sender, EventArgs e)
        {
            if (!BtnUtils.VerifyDecision()) return;
            MaterielModele.RemoveMateriel(FormToMat());
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
