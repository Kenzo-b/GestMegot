using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Modeles
{
    public static class CollecteModele
    {
        private static MySqlCommand AddParameters(MySqlCommand cmd, Collecte uneCollecte)
        {
            foreach (var param in CollecteParameter(uneCollecte).Where(param => cmd.CommandText.Contains(param.Key)))
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
        
        public static Dictionary<string, object> CollecteParameter(Collecte uneCollecte)
        {
            var objects = new Dictionary<string, object>()
            {
                { "@id", uneCollecte.Id },
                { "@nb_megot", uneCollecte.NbMegot },
                { "@fk_materiel", uneCollecte.Mat?.Reference },
                { "@date_collecte", uneCollecte.DateCollecte }
            };
            return objects;
        }
        
        private static Collecte ReaderToCollecte(MySqlDataReader lecteur)
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
            cmd = AddParameters(cmd, new Collecte.Builder().WithId(id).build());
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
            cmd = AddParameters(cmd, collecte);
            cmd.ExecuteNonQuery();
            connex.Close();
        }

        public static void ModifierCollect(Collecte collecte)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "UPDATE collecte set nb_megot = @nb_megot, fk_materiel = @fk_materiel, date_collecte = @date_collecte WHERE id = @id";
            cmd = AddParameters(cmd, collecte);
            cmd.ExecuteNonQuery();
            connex.Close();
        }

        public static void SuppCollecte(Collecte collecte)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "DELETE FROM collecte WHERE id = @id";
            cmd = AddParameters(cmd, collecte);
            cmd.ExecuteNonQuery();
            connex.Close();
        }
    }
}


