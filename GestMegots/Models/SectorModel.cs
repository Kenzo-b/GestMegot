using GestMegots.entities;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    internal static class SectorModel
    {
        private static MySqlCommand AddParameters(MySqlCommand cmd, Sector sector)
        {
            foreach (var param in SectorParameters(sector).Where(param => cmd.CommandText.Contains(param.Key)))
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
        
        private static Dictionary<string, object> SectorParameters(Sector sector)
        {
            return new Dictionary<string, object>
            {
                { "@idSecteur", sector.Id },
                { "@libelle", sector.Name }
            };
        }
        
        private static Sector ReaderToSector(MySqlDataReader reader)
        {
            return new Sector.Builder()
                .WithId(int.Parse(reader[0].ToString()))
                .WithName(reader[1].ToString())
                .Build();
        }
        
        public static List<Sector> AllSectors()
        {
            List<Sector> sectors = new List<Sector>();
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM secteur order by libelle";
            MySqlDataReader reader = cmd.ExecuteReader();    
            while (reader.Read())
            {
                sectors.Add(ReaderToSector(reader));
            }
            return sectors;

        }
        public static Sector GetSectorById(int id)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM secteur where idSecteur = @idSecteur";
            cmd = AddParameters(cmd, new Sector.Builder().WithId(id).Build());
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return ReaderToSector(reader);
        }

        public static void AddSector(Sector sector)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO secteur(libelle) VALUE (@libelle)";
            cmd = AddParameters(cmd, sector);
            cmd.ExecuteNonQuery();
        }
        
        public static void UpdateSector(Sector sector)
        {

            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE secteur SET libelle = @libelle WHERE idSecteur = @idSecteur";
            cmd = AddParameters(cmd, sector);
            cmd.ExecuteNonQuery();
        }
        public static void RemoveSector(Sector sector)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM secteur WHERE idSecteur = @idSecteur";
            cmd = AddParameters(cmd, sector);
            cmd.ExecuteNonQuery();
        }
    }
}
