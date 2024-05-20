using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Modeles
{
    public class CollecteModele
    {
        public static Collecte ReaderToCollecte(MySqlDataReader lecteur)
        {
            return new Collecte.Builder()
                .WithId(int.Parse(lecteur[0].ToString()))
                .WithNbMegot(int.Parse(lecteur[1].ToString()))
                .WithMateriel(MaterielModele.GetMatByid(int.Parse(lecteur[2].ToString())))
                .WithDateCollecte(lecteur.GetDateTime("date_collecte"))
                .build();
        }

        public static List<Collecte> ToutesLesCollecte()
        {
            List<Collecte> lesCollectes = new List<Collecte>();
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM collecte";
            MySqlDataReader lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                lesCollectes.Add(ReaderToCollecte(lecteur));
            }
            
            connex.Close();
            return lesCollectes;
        }

        public static Collecte GetCollecteByid(int id)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM collecte WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader lecteur = cmd.ExecuteReader();
            lecteur.Read();
            Collecte UneCollecte = ReaderToCollecte(lecteur);
            connex.Close();
            return UneCollecte;
        }
        
        public static void AjouterCollect(Collecte collecte)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "INSERT INTO collecte(nb_megot, fk_materiel, date_collecte) VALUE (@nb_megot, @fk_materiel, @date_collecte)";
            cmd.Parameters.AddWithValue("@nb_megot", collecte.NbMegot);
            cmd.Parameters.AddWithValue("@fk_materiel", collecte.Mat.Reference);
            cmd.Parameters.AddWithValue("@date_collecte", collecte.DateCollecte);
            cmd.ExecuteNonQuery();
            connex.Close();
        }

        public static void ModifierCollect(Collecte collecte)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "UPDATE collecte set nb_megot = @nb_megot, fk_materiel = @fk_materiel, date_collecte = @date_collecte WHERE id = @id";
            cmd.Parameters.AddWithValue("@nb_megot", collecte.NbMegot);
            cmd.Parameters.AddWithValue("@fk_materiel", collecte.Mat);
            cmd.Parameters.AddWithValue("@date_collecte", collecte.DateCollecte);
            cmd.Parameters.AddWithValue("@id", collecte.Id);
            cmd.ExecuteNonQuery();
            connex.Close();
        }

        public static void SuppCollecte(Collecte collecte)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "DELETE FROM collecte WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", collecte.Id);
            cmd.ExecuteNonQuery();
            connex.Close();
        }
    }
}


