using GestMegots.Entitees;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestMegots.Modeles
{
    internal class CategorieModele
    {
        public static Categorie ReaderToCategorie(MySqlDataReader lecteur)
        { 
            return new Categorie.Builder()
                .WithId(int.Parse(lecteur[0].ToString()))
                .WithName(lecteur[1].ToString())
                .WithRemarque(lecteur[2].ToString())
                .Build();
        }
        
        public static List<Categorie> ToutesLesCategories()
        {
            List<Categorie> lesCat = new List<Categorie>();
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM CATEGORIE order by libelle";
            MySqlDataReader lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                lesCat.Add(ReaderToCategorie(lecteur));
            }
            connex.Close();
            return lesCat;

        }
        public static Categorie GetCategorieById(int id)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categorie where idCategorie = @IdCategorie";
            cmd.Parameters.AddWithValue("@IdCategorie", id);
            MySqlDataReader lecteur = cmd.ExecuteReader();
            
            lecteur.Read();
            Categorie uneCat = ReaderToCategorie(lecteur);

            connex.Close();
            return uneCat;

        }

    }
}
