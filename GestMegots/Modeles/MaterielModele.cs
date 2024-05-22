using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Modeles
{
    internal class MaterielModele
    {
        public static Materiel ReaderToMat(MySqlDataReader lecteur)
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
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM materiel";
            MySqlDataReader lecteur = cmd.ExecuteReader();
            while (lecteur.Read())
            {
                lesMateriels.Add(ReaderToMat(lecteur));
            }
            connex.Close();
            return lesMateriels;
        }

        public static Materiel GetMatByid(int id)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM materiel WHERE reference = @reference";
            cmd.Parameters.AddWithValue("@reference", id);
            MySqlDataReader lecteur = cmd.ExecuteReader();
            lecteur.Read();
            Materiel unMateriel = ReaderToMat(lecteur);
            connex.Close();
            return unMateriel;
        }

        public static void AjouterMateriel(Materiel unMat)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "INSERT INTO materiel(couleurs, dateInstallation, adresse, coordoGPS, fkType, op) VALUE (@couleurs, @dateInstallation, @adresse, @coordoGPS, @fkType, @op)";
            cmd.Parameters.AddWithValue("@couleurs", unMat.Couleurs);
            cmd.Parameters.AddWithValue("@dateInstallation", unMat.DateInstal);
            cmd.Parameters.AddWithValue("@adresse", unMat.Adresse);
            cmd.Parameters.AddWithValue("@coordoGPS", unMat.CoordoGps);
            cmd.Parameters.AddWithValue("@fkType", unMat.LeType.IdType);
            cmd.Parameters.AddWithValue("@op", unMat.Op);
            cmd.ExecuteNonQuery();
            connex.Close();
        }

        public static void SupprimerMateriel(Materiel unMat)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "DELETE FROM materiel WHERE reference = @reference";
            cmd.Parameters.AddWithValue("@reference", unMat.Reference);
            cmd.ExecuteNonQuery();
            connex.Close();
        }

        public static void ChangerMateriel(Materiel unMat)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "UPDATE materiel SET couleurs = @couleurs, dateInstallation = @dateInstallation, adresse = @adresse, coordoGPS = @coordoGPS, fkType = @fkType, op = @op WHERE reference = @reference";
            cmd.Parameters.AddWithValue("@couleurs", unMat.Couleurs);
            cmd.Parameters.AddWithValue("@dateInstallation", unMat.DateInstal);
            cmd.Parameters.AddWithValue("@adresse", unMat.Adresse);
            cmd.Parameters.AddWithValue("@coordoGPS", unMat.CoordoGps);
            cmd.Parameters.AddWithValue("@fkType", unMat.LeType.IdType);
            cmd.Parameters.AddWithValue("@op", unMat.Op);
            cmd.Parameters.AddWithValue("@reference", unMat.Reference);
            cmd.ExecuteNonQuery();
            connex.Close();
        }
    }
}
