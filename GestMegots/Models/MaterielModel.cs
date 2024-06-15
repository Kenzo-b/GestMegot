using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    internal static class MaterielModel
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
        
        private static Materiel ReaderToMat(MySqlDataReader reader)
        {
            return new Materiel.Builder()
                .WithReference(int.Parse(reader[0].ToString()))
                .WithCouleur(reader[1].ToString())
                .WithDateInstal(reader.GetDateTime("dateInstallation"))
                .WithAdresse(reader[3].ToString())
                .WithCoordoGPS(reader[4].ToString())
                .WithLeType(TypeModel.GetTypeMaterielById(int.Parse(reader[5].ToString())))
                .WithOp(int.Parse(reader[6].ToString()))
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

        public static void AddMateriel(Materiel materiel)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO materiel(couleurs, dateInstallation, adresse, coordoGPS, fkType, op) VALUE (@couleurs, @dateInstallation, @adresse, @coordoGPS, @fkType, @op)";
            cmd = AddParameters(cmd, materiel);
            cmd.ExecuteNonQuery();
        }
        
        public static void RemoveMateriel(Materiel materiel)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM materiel WHERE reference = @reference";
            cmd = AddParameters(cmd, materiel);
            cmd.ExecuteNonQuery();
        }
        
        public static void UpdateMateriel(Materiel materiel)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE materiel SET couleurs = @couleurs, dateInstallation = @dateInstallation, adresse = @adresse, coordoGPS = @coordoGPS, fkType = @fkType, op = @op WHERE reference = @reference";
            cmd = AddParameters(cmd, materiel);
            cmd.ExecuteNonQuery();
        }
    }
}
