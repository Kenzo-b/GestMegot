using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    internal static class SectorModel
    {
        private static MySqlCommand AddParameters(MySqlCommand cmd, Secteur sector)
        {
            foreach (var param in SectorParameters(sector).Where(param => cmd.CommandText.Contains(param.Key)))
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
        
        private static Dictionary<string, object> SectorParameters(Secteur sector)
        {
            return new Dictionary<string, object>
            {
                { "@idSecteur", sector.Id },
                { "@libelle", sector.Name }
            };
        }
        
        private static Secteur ReaderToSector(MySqlDataReader reader)
        {
            return new Secteur.Builder()
                .WithId(int.Parse(reader[0].ToString()))
                .WithName(reader[1].ToString())
                .Build();
        }
        
        public static List<Secteur> AllSectors()
        {
            List<Secteur> sectors = new List<Secteur>();
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM SECTEUR order by libelle";
            MySqlDataReader reader = cmd.ExecuteReader();    
            while (reader.Read())
            {
                sectors.Add(ReaderToSector(reader));
            }
            return sectors;

        }
        public static Secteur GetSectorById(int id)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM SECTEUR where idSecteur = @idSecteur";
            cmd = AddParameters(cmd, new Secteur.Builder().WithId(id).Build());
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return ReaderToSector(reader);
        }

        public static void AddSector(Secteur sector)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO secteur(libelle) VALUE (@libelle)";
            cmd = AddParameters(cmd, sector);
            cmd.ExecuteNonQuery();
        }
        
        public static void UpdateSector(Secteur sector)
        {

            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE secteur SET libelle = @libelle WHERE idSecteur = @idSecteur";
            cmd = AddParameters(cmd, sector);
            cmd.ExecuteNonQuery();
        }
        public static void RemoveSector(Secteur sector)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM secteur WHERE idSecteur = @idSecteur";
            cmd = AddParameters(cmd, sector);
            cmd.ExecuteNonQuery();
        }
    }
}
