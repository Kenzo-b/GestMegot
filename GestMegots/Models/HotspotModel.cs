using GestMegots.entities;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    public static class HotspotModel
    {
        private static MySqlCommand AddParameters(MySqlCommand cmd, Hotspot hotspot)
        {
            foreach (var param in HotspotParameter(hotspot).Where(param => cmd.CommandText.Contains(param.Key) ))
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
        
        private static Dictionary<string, object> HotspotParameter(Hotspot hotspot)
        {
            return new Dictionary<string, object>
            {
                { "@coordoGPS", hotspot.CoordoGps },
                { "@nom", hotspot.Nom },
                { "@adresse", hotspot.Adresse },
                { "@terrasse", hotspot.Terrasse },
                { "@fkSecteur", hotspot.LeSector?.Id },
                { "@fkCategorie", hotspot.LaCategorie?.Id },
                { "@fkMateriel", hotspot.LeMateriel?.Reference }
            };
        }
        
        private static Hotspot ReaderToHotspot(MySqlDataReader reader)
        {
            Hotspot unHs = new Hotspot.Builder()    
                .WithIdHS(int.Parse(reader[0].ToString()))
                .WithCoordoGPS(reader[1].ToString())
                .WithNom(reader[2].ToString())
                .WithAdresse(reader[3].ToString())
                .WithTerrasse(int.Parse(reader[4].ToString()))
                .WithLeSecteur(SectorModel.GetSectorById(int.Parse(reader[5].ToString())))
                .WithLaCategorie(CategoryModel.GetCategoryById(int.Parse(reader[6].ToString())))
                .WithLeMateriel(MaterielModel.GetMatById(int.Parse(reader[7].ToString())))
                .Build();
            return unHs;
        }
        
        public static List<Hotspot> AllHotspots()
        {
            List<Hotspot> hotspots = new List<Hotspot>();
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM HOTSPOT";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                hotspots.Add(ReaderToHotspot(reader));
            }
            return hotspots;

        }
        public static Hotspot GetHotspotById(int id)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM HOTSPOT WHERE idHS = @idHS";
            cmd = AddParameters(cmd, new Hotspot.Builder().WithIdHS(id).Build());
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return ReaderToHotspot(reader);

        }

        public static void AddHotspot(Hotspot hotspot)
        {
            MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO hotspot( coordoGPS, nom, adresse, terrasse, fkSecteur, fkCategorie, fkMateriel) VALUE  (@coordoGPS, @nom, @adresse, @terrasse, @fkSecteur, @fkCategorie, @fkMateriel)";
            cmd = AddParameters(cmd, hotspot);
            cmd.ExecuteNonQuery();
        }
        public static void UpdateHotspot(Hotspot hotspot)
        {

            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE `hotspot` SET `coordoGPS` = @coordoGPS, `nom`=@nom, `adresse`=@adresse, `terrasse`=@terrasse, `fkSecteur`=@fkSecteur, `fkCategorie`=@fkCategorie, `fkMateriel` = @fkMateriel WHERE `idHS` = @idHS  ";
            cmd = AddParameters(cmd, hotspot);
            cmd.ExecuteNonQuery();
        }
        public static void RemoveHotspot(Hotspot hotspot)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM `hotspot`  WHERE `hotspot`.`idHS` = @idHS  ";
            cmd = AddParameters(cmd, hotspot);
            cmd.ExecuteNonQuery();
        }

    }
}
