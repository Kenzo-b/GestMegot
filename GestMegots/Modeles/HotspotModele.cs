using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Modeles
{
    public static class HotspotModele
    {
        /// <summary>
        /// Take a MySqlDataReader that read to Return an Hotspot object with the data get from the reader
        /// </summary>
        /// <param name="lecteur">The reader</param>
        /// <returns name="">Hotspot object</returns>
        public static Hotspot ReaderToHotspot(MySqlDataReader lecteur)
        {
            Hotspot unHs = new Hotspot.Builder()    
                .WithIdHS(int.Parse(lecteur[0].ToString()))
                .WithCoordoGPS(lecteur[1].ToString())
                .WithNom(lecteur[2].ToString())
                .WithAdresse(lecteur[3].ToString())
                .WithTerrasse(int.Parse(lecteur[4].ToString()))
                .WithLeSecteur(SecteurModele.GetSecteurById(int.Parse(lecteur[5].ToString())))
                .WithLaCategorie(CategorieModele.GetCategorieById(int.Parse(lecteur[6].ToString())))
                .WithLeMateriel(MaterielModele.GetMatByid(int.Parse(lecteur[7].ToString())))
                .Build();
            return unHs;
        }
        
        public static List<Hotspot> TousLesHotspots()
        {
            List<Hotspot> lesHp = new List<Hotspot>();
        
            MySqlConnection connexHs = Connection.Ouvrir();
            MySqlCommand cmd = connexHs.CreateCommand();
            cmd.CommandText = "SELECT * FROM HOTSPOT";
            MySqlDataReader lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                lesHp.Add(ReaderToHotspot(lecteur));
            }
            connexHs.Close();
            return lesHp;

        }
        public static Hotspot GetHotspotById(int id)
        {
            MySqlConnection connexHs = Connection.Ouvrir();
            MySqlCommand cmd = connexHs.CreateCommand();
            cmd.CommandText = "SELECT * FROM HOTSPOT WHERE idHS = @idHS";
            cmd.Parameters.Add("@idHS", MySqlDbType.Int32).Value = id;
            MySqlDataReader lecteur = cmd.ExecuteReader();
            lecteur.Read();

            Hotspot unHs = ReaderToHotspot(lecteur);

            connexHs.Close();
            return unHs;

        }

        public static void AjoutHotspot(Hotspot unHs)
        {
            MySqlConnection connexHs = Connection.Ouvrir();
            MySqlCommand cmd = connexHs.CreateCommand();
            //INSERT INTO `hotspot` (`idHS`, `coordoGPS`, `nom`, `adresse`, `terrasse`, `fkSecteur`, `fkCategorie`, `fkMateriel`) VALUES (NULL, '123456;123456', 'Couleur Café', 'rue de la gare', '1', '2', '1', NULL);
            cmd.CommandText = "INSERT INTO hotspot( `coordoGPS`, `nom`, `adresse`, `terrasse`, `fkSecteur`, `fkCategorie`, 'fkMateriel') VALUE  (@coordoGPS, @nom, @adresse, @terrasse, @fkSecteur, @fkCategorie, @fkMateriel)";
            cmd.Parameters.Add("@coordoGPS", MySqlDbType.VarString).Value = unHs.CoordoGps;
            cmd.Parameters.Add("@nom", MySqlDbType.VarString).Value = unHs.Nom;
            cmd.Parameters.Add("@adresse", MySqlDbType.VarString).Value = unHs.Adresse;
            cmd.Parameters.Add("@terrasse", MySqlDbType.Bit).Value = unHs.Terrasse;
            cmd.Parameters.Add("@fkSecteur", MySqlDbType.Int32).Value = unHs.LeSecteur.Id;
            cmd.Parameters.Add("@fkCategorie", MySqlDbType.Int32).Value = unHs.LaCategorie.Id;
            cmd.Parameters.Add("@fkMateriel", MySqlDbType.Int32).Value = unHs.LeMateriel.Reference;

            int nb = cmd.ExecuteNonQuery();


        }
        public static void ModifierHotspot(Hotspot unHs)
        {

            MySqlConnection connexHs = Connection.Ouvrir();
            MySqlCommand cmd = connexHs.CreateCommand();
            //UPDATE `hotspot` SET `coordoGPS` = '1234' WHERE `hotspot`.`idHS` = 8;
            cmd.CommandText = "UPDATE `hotspot` SET `coordoGPS` = @coordo, `nom`=@nom, `adresse`=@adresse, `terrasse`=@terrasse, `fkSecteur`=@secteur, `fkCategorie`=@categorie, fkMateriel = @fkMateriel WHERE `idHS` = @idHS  ";
            cmd.Parameters.Add("@coordo", MySqlDbType.VarChar).Value = unHs.CoordoGps;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = unHs.Nom;
            cmd.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = unHs.Adresse;
            cmd.Parameters.Add("@terrasse", MySqlDbType.Bit).Value = unHs.Terrasse;
            cmd.Parameters.Add("@secteur", MySqlDbType.Int32).Value = unHs.LeSecteur.Id;
            cmd.Parameters.Add("@categorie", MySqlDbType.Int32).Value = unHs.LaCategorie.Id;
            cmd.Parameters.Add("@fkMateriel", MySqlDbType.Int32).Value = unHs.LeMateriel.Reference.ToString();
            cmd.Parameters.Add("@idHS", MySqlDbType.Int32).Value = unHs.IdHs;

            int nb = cmd.ExecuteNonQuery();
            connexHs.Close();

        }
        public static void SupprimerHotspot(Hotspot unHs)
        {
            MySqlConnection connexHs = Connection.Ouvrir();
            MySqlCommand cmd = connexHs.CreateCommand();
            cmd.CommandText = "DELETE FROM `hotspot`  WHERE `hotspot`.`idHS` = @idHS  ";
            cmd.Parameters.Add("@idHS", MySqlDbType.Int32).Value = unHs.IdHs;

            int nb = cmd.ExecuteNonQuery();
            connexHs.Close();

        }

    }
}
