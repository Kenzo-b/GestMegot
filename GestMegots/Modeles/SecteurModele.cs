using GestMegots.Entitees;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestMegots.Modeles
{
    internal class SecteurModele
    {
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
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM SECTEUR order by libelle";
            MySqlDataReader lecteur = cmd.ExecuteReader();    
            while (lecteur.Read())
            {
                lesSect.Add(ReaderToSecteur(lecteur));
            }
            connex.Close();
            return lesSect;

        }
        public static Secteur GetSecteurById(int id)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM SECTEUR where idSecteur = @IdSecteur";
            cmd.Parameters.Add("@IdSecteur", MySqlDbType.Int32).Value = id;
            MySqlDataReader lecteur = cmd.ExecuteReader();
            lecteur.Read();

            Secteur unSec = ReaderToSecteur(lecteur);

            connex.Close();
            return unSec;
        }

        public static void AjoutSecteur(Secteur unSect)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "INSERT INTO secteur(libelle) VALUE (@libelle)";
            cmd.Parameters.Add("@libelle", MySqlDbType.Int32).Value = unSect.Name;
            cmd.ExecuteNonQuery();
            connex.Close();

        }
        public static void ModifierHotspot(Secteur unSect)
        {

            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "INSERT INTO secteur(libelle) VALUE (@libelle)";
            cmd.Parameters.Add("@libelle", MySqlDbType.Int32).Value = unSect.Name;
            cmd.ExecuteNonQuery();
            connex.Close();
        }
        public static void SupprimerHotspot(Secteur unSect)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "DELETE FROM secteur WHERE idSecteur = @idSecteur";
            cmd.Parameters.Add("@idSecteur", MySqlDbType.Int32 ).Value = unSect.Id;
            cmd.ExecuteNonQuery();
            connex.Close();
        }
    }
}
