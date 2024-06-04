using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    internal static class MaterielModele
    {
        private static MySqlCommand AddParameters(MySqlCommand cmd, Materiel materiel)
        {
            foreach (var param in MaterialParameter(materiel).Where(param => cmd.CommandText.Contains(param.Key)))
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
        
        private static Dictionary<string,object> MaterialParameter(Materiel materiel)
        {
            return new Dictionary<string, object>
            {
                { "@couleurs", materiel.Couleurs },
                { "@dateInstallation", materiel.DateInstal },
                { "@adresse", materiel.Adresse },
                { "@coordoGPS", materiel.CoordoGps },
                { "@fkType", materiel.LeType?.IdType },
                { "@op", materiel.Op },
                { "@reference", materiel.Reference }
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

        public static List<Materiel> AllMateriel()
        {
            List<Materiel> materiels = new List<Materiel>();
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM materiel";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                materiels.Add(ReaderToMat(reader));
            }
            return materiels;
        }

        public static Materiel GetMatById(int id)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM materiel WHERE reference = @reference";
            cmd = AddParameters(cmd, new Materiel.Builder().WithReference(id).build());
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return ReaderToMat(reader);
        }

        public static void AddMateriel(Materiel unMat)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO materiel(couleurs, dateInstallation, adresse, coordoGPS, fkType, op) VALUE (@couleurs, @dateInstallation, @adresse, @coordoGPS, @fkType, @op)";
            cmd = AddParameters(cmd, unMat);
            cmd.ExecuteNonQuery();
        }
        
        public static void RemoveMateriel(Materiel unMat)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM materiel WHERE reference = @reference";
            cmd = AddParameters(cmd, unMat);
            cmd.ExecuteNonQuery();
        }
        
        public static void UpdateMateriel(Materiel unMat)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE materiel SET couleurs = @couleurs, dateInstallation = @dateInstallation, adresse = @adresse, coordoGPS = @coordoGPS, fkType = @fkType, op = @op WHERE reference = @reference";
            cmd = AddParameters(cmd, unMat);
            cmd.ExecuteNonQuery();
        }
    }
}
