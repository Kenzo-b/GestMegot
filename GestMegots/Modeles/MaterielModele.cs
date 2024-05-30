using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Modeles
{
    internal static class MaterielModele
    {
        private static MySqlCommand AddParameters(MySqlCommand cmd, Materiel unMat)
        {
            foreach (var param in MaterialParameter(unMat).Where(param => cmd.CommandText.Contains(param.Key)))
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
        
        private static Dictionary<string,object> MaterialParameter(Materiel unMat)
        {
            return new Dictionary<string, object>
            {
                { "@couleurs", unMat.Couleurs },
                { "@dateInstallation", unMat.DateInstal },
                { "@adresse", unMat.Adresse },
                { "@coordoGPS", unMat.CoordoGps },
                { "@fkType", unMat.LeType?.IdType },
                { "@op", unMat.Op },
                { "@reference", unMat.Reference }
            };
        }
        
        private static Materiel ReaderToMat(MySqlDataReader lecteur)
        {
            return new Materiel.Builder()
                .WithReference(int.Parse(lecteur[0].ToString()))
                .WithCouleur(lecteur[1].ToString())
                .WithDateInstal(lecteur.GetDateTime("dateInstallation"))
                .WithAdresse(lecteur[3].ToString())
                .WithCoordoGPS(lecteur[4].ToString())
                .WithLeType(TypeModele.GetTypeMaterielById(int.Parse(lecteur[5].ToString())))
                .WithOp(int.Parse(lecteur[6].ToString()))
                .build();
        }

        public static List<Materiel> TousLesMateriel()
        {
            List<Materiel> lesMateriels = new List<Materiel>();
            using MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM materiel";
            MySqlDataReader lecteur = cmd.ExecuteReader();
            while (lecteur.Read())
            {
                lesMateriels.Add(ReaderToMat(lecteur));
            }
            return lesMateriels;
        }

        public static Materiel GetMatByid(int id)
        {
            using MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM materiel WHERE reference = @reference";
            cmd = AddParameters(cmd, new Materiel.Builder().WithReference(id).build());
            MySqlDataReader lecteur = cmd.ExecuteReader();
            lecteur.Read();
            return ReaderToMat(lecteur);
        }

        public static void AjouterMateriel(Materiel unMat)
        {
            using MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "INSERT INTO materiel(couleurs, dateInstallation, adresse, coordoGPS, fkType, op) VALUE (@couleurs, @dateInstallation, @adresse, @coordoGPS, @fkType, @op)";
            cmd = AddParameters(cmd, unMat);
            cmd.ExecuteNonQuery();
        }
        
        public static void SupprimerMateriel(Materiel unMat)
        {
            using MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "DELETE FROM materiel WHERE reference = @reference";
            cmd = AddParameters(cmd, unMat);
            cmd.ExecuteNonQuery();
        }
        
        public static void ChangerMateriel(Materiel unMat)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "UPDATE materiel SET couleurs = @couleurs, dateInstallation = @dateInstallation, adresse = @adresse, coordoGPS = @coordoGPS, fkType = @fkType, op = @op WHERE reference = @reference";
            cmd = AddParameters(cmd, unMat);
            cmd.ExecuteNonQuery();
            connex.Close();
        }
    }
}
