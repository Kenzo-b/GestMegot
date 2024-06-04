using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    public static class HotspotModele
    {
        private static MySqlCommand AddParameters(MySqlCommand cmd, Hotspot unHs)
        {
            foreach (var param in HotspotParameter(unHs).Where(param => cmd.CommandText.Contains(param.Key) ))
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
        
        private static Dictionary<string, object> HotspotParameter(Hotspot unHs)
        {
            return new Dictionary<string, object>
            {
                { "@coordoGPS", unHs.CoordoGps },
                { "@nom", unHs.Nom },
                { "@adresse", unHs.Adresse },
                { "@terrasse", unHs.Terrasse },
                { "@fkSecteur", unHs.LeSecteur?.Id },
                { "@fkCategorie", unHs.LaCategorie?.Id },
                { "@fkMateriel", unHs.LeMateriel?.Reference }
            };
        }
        
        private static Hotspot ReaderToHotspot(MySqlDataReader lecteur)
        {
            Hotspot unHs = new Hotspot.Builder()    
                .WithIdHS(int.Parse(lecteur[0].ToString()))
                .WithCoordoGPS(lecteur[1].ToString())
                .WithNom(lecteur[2].ToString())
                .WithAdresse(lecteur[3].ToString())
                .WithTerrasse(int.Parse(lecteur[4].ToString()))
                .WithLeSecteur(SecteurModele.GetSecteurById(int.Parse(lecteur[5].ToString())))
                .WithLaCategorie(CategoryModel.GetCategoryById(int.Parse(lecteur[6].ToString())))
                .WithLeMateriel(MaterielModele.GetMatById(int.Parse(lecteur[7].ToString())))
                .Build();
            return unHs;
        }
        
        public static List<Hotspot> TousLesHotspots()
        {
            List<Hotspot> lesHp = new List<Hotspot>();
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM HOTSPOT";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lesHp.Add(ReaderToHotspot(reader));
            }
            return lesHp;

        }
        public static Hotspot GetHotspotById(int id)
        {
            using MySqlConnection connexHs = Connection.Open();
            MySqlCommand cmd = connexHs.CreateCommand();
            cmd.CommandText = "SELECT * FROM HOTSPOT WHERE idHS = @idHS";
            cmd = AddParameters(cmd, new Hotspot.Builder().WithIdHS(id).Build());
            MySqlDataReader lecteur = cmd.ExecuteReader();
            lecteur.Read();
            return ReaderToHotspot(lecteur);

        }

        public static void AjoutHotspot(Hotspot unHs)
        {
            MySqlConnection connexHs = Connection.Open();
            MySqlCommand cmd = connexHs.CreateCommand();
            cmd.CommandText = "INSERT INTO hotspot( coordoGPS, nom, adresse, terrasse, fkSecteur, fkCategorie, fkMateriel) VALUE  (@coordoGPS, @nom, @adresse, @terrasse, @fkSecteur, @fkCategorie, @fkMateriel)";
            cmd = AddParameters(cmd, unHs);
            cmd.ExecuteNonQuery();
        }
        public static void ModifierHotspot(Hotspot unHs)
        {

            using MySqlConnection connexHs = Connection.Open();
            MySqlCommand cmd = connexHs.CreateCommand();
            cmd.CommandText = "UPDATE `hotspot` SET `coordoGPS` = @coordoGPS, `nom`=@nom, `adresse`=@adresse, `terrasse`=@terrasse, `fkSecteur`=@fkSecteur, `fkCategorie`=@fkCategorie, `fkMateriel` = @fkMateriel WHERE `idHS` = @idHS  ";
            cmd = AddParameters(cmd, unHs);
            cmd.ExecuteNonQuery();
        }
        public static void RemoveHotspot(Hotspot unHs)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM `hotspot`  WHERE `hotspot`.`idHS` = @idHS  ";
            cmd = AddParameters(cmd, unHs);
            cmd.ExecuteNonQuery();
        }

    }
}
