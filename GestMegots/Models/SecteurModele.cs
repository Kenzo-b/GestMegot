using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    internal class SecteurModele
    {
        private static MySqlCommand AddParameters(MySqlCommand cmd, Secteur unSect)
        {
            foreach (var param in SecteurParameters(unSect).Where(param => cmd.CommandText.Contains(param.Key)))
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
        
        private static Dictionary<string, object> SecteurParameters(Secteur unSect)
        {
            return new Dictionary<string, object>
            {
                { "@idSecteur", unSect.Id },
                { "@libelle", unSect.Name }
            };
        }
        
        public static Secteur ReaderToSecteur(MySqlDataReader lecteur)
        {
            return new Secteur.Builder()
                .WithId(int.Parse(lecteur[0].ToString()))
                .WithName(lecteur[1].ToString())
                .Build();
        }
        
        public static List<Secteur> TousLesSecteurs()
        {
            List<Secteur> lesSect = new List<Secteur>();
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM SECTEUR order by libelle";
            MySqlDataReader lecteur = cmd.ExecuteReader();    
            while (lecteur.Read())
            {
                lesSect.Add(ReaderToSecteur(lecteur));
            }
            return lesSect;

        }
        public static Secteur GetSecteurById(int id)
        {
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM SECTEUR where idSecteur = @idSecteur";
            cmd = AddParameters(cmd, new Secteur.Builder().WithId(id).Build());
            MySqlDataReader lecteur = cmd.ExecuteReader();
            lecteur.Read();
            return ReaderToSecteur(lecteur);
        }

        public static void AjoutSecteur(Secteur unSect)
        {
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "INSERT INTO secteur(libelle) VALUE (@libelle)";
            cmd = AddParameters(cmd, unSect);
            cmd.ExecuteNonQuery();
        }
        
        public static void ModifierSecteur(Secteur unSect)
        {

            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "UPDATE secteur SET libelle = @libelle WHERE idSecteur = @idSecteur";
            cmd = AddParameters(cmd, unSect);
            cmd.ExecuteNonQuery();
        }
        public static void SupprimerSecteur(Secteur unSect)
        {
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "DELETE FROM secteur WHERE idSecteur = @idSecteur";
            cmd = AddParameters(cmd, unSect);
            cmd.ExecuteNonQuery();
        }
    }
}
