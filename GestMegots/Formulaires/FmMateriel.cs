using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestMegots.Entitees;
using GestMegots.Modeles;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_hotspot_Click(object sender, EventArgs e)
        {
            FmHotspot f = new FmHotspot();
            f.Show();
            this.Hide();
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
            Materiel leMat = FormToMat();
            leMat.DateInstal = DateTime.Now;
            MaterielModele.AjouterMateriel(leMat);
            this.dataGridView1.DataSource = MaterielModele.TousLesMateriel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            MaterielModele.ChangerMateriel(FormToMat());
            this.dataGridView1.DataSource = MaterielModele.TousLesMateriel();
        }

        private void bt_dell_Click(object sender, EventArgs e)
        {
            MaterielModele.SupprimerMateriel(FormToMat());
            this.dataGridView1.DataSource = MaterielModele.TousLesMateriel();
        }
    }
}
