using GestMegots.entities;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    internal static class CategoryModel
    {
        private static Categorie ReaderToCategory(MySqlDataReader reader)
        { 
            return new Categorie.Builder()
                .WithId(int.Parse(reader[0].ToString()))
                .WithName(reader[1].ToString())
                .WithRemarque(reader[2].ToString())
                .Build();
        }
        
        public static List<Categorie> AllCategory()
        {
            List<Categorie> cats = new List<Categorie>();
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM CATEGORIE order by libelle";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cats.Add(ReaderToCategory(reader));
            }
            return cats;

        }
        public static Categorie GetCategoryById(int id)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categorie where idCategorie = @IdCategorie";
            cmd.Parameters.AddWithValue("@IdCategorie", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read(); 
            return ReaderToCategory(reader);
        }
    }
}
