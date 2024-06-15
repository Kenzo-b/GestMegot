using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    public static class CollectModel
    {
        private static MySqlCommand AddParameters(MySqlCommand cmd, Collecte collect)
        {
            foreach (var param in CollectParameter(collect).Where(param => cmd.CommandText.Contains(param.Key)))
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
        
        private static Dictionary<string, object> CollectParameter(Collecte collect)
        {
            var objects = new Dictionary<string, object>
            {
                { "@id", collect.Id },
                { "@nb_megot", collect.NbMegot },
                { "@fk_materiel", collect.Mat?.Reference },
                { "@date_collecte", collect.DateCollecte }
            };
            return objects;
        }
        
        private static Collecte ReaderToCollect(MySqlDataReader reader)
        {
            return new Collecte.Builder()
                .WithId(int.Parse(reader[0].ToString()))
                .WithNbMegot(int.Parse(reader[1].ToString()))
                .WithMateriel(MaterielModel.GetMatById(int.Parse(reader[2].ToString())))
                .WithDateCollecte(reader.GetDateTime("date_collecte"))
                .build();
        }

        public static List<Collecte> AllCollect()
        {
            List<Collecte> collects = new List<Collecte>();
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM collecte";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                collects.Add(ReaderToCollect(reader));
            }
            return collects;
        }

        public static Collecte GetCollectById(int id)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM collecte WHERE id = @id";
            cmd = AddParameters(cmd, new Collecte.Builder().WithId(id).build());
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return ReaderToCollect(reader);
        }
        
        public static void AddCollect(Collecte collect)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO collecte(nb_megot, fk_materiel, date_collecte) VALUE (@nb_megot, @fk_materiel, @date_collecte)";
            cmd = AddParameters(cmd, collect);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateCollect(Collecte collect)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE collecte set nb_megot = @nb_megot, fk_materiel = @fk_materiel, date_collecte = @date_collecte WHERE id = @id";
            cmd = AddParameters(cmd, collect);
            cmd.ExecuteNonQuery();
        }

        public static void RemoveCollect(Collecte collect)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM collecte WHERE id = @id";
            cmd = AddParameters(cmd, collect);
            cmd.ExecuteNonQuery();
        }
    }
}


