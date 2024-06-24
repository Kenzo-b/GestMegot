using GestMegots.entities;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    internal static class TypeModel
    {
        private static MySqlCommand AddParameter(MySqlCommand cmd, TypeMateriel type)
        {
            foreach (var param in TypeParameter(type).Where(param => cmd.CommandText.Contains(param.Key)))
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
        
        private static Dictionary<string, object> TypeParameter(TypeMateriel unType)
        {
            return new Dictionary<string, object>
            {
                { "@idType", unType.IdType },
                { "@libelle", unType?.Libelle },
                { "@contenance", unType.Contenance },
                { "@sacIntegrer", unType.SacIntegre }
            };
        }
        
        private static TypeMateriel ReaderToType(MySqlDataReader reader)
        {
            
            return new TypeMateriel.Builder()
                .WithIdType(int.Parse(reader[0].ToString()))
                .WithLibelle(reader[1].ToString())
                .WithContenance(double.Parse(reader[2].ToString()))
                .WithSacIntegre(int.Parse(reader[3].ToString()))
                .build();
        }
        
        public static List<TypeMateriel> AllTypes()
        {
            List<TypeMateriel> types = new List<TypeMateriel>();
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM type";
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                types.Add(ReaderToType(reader));
            }
            return types;
        }

        public static TypeMateriel GetTypeMaterielById(int id)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM type WHERE idType = @idType";
            cmd = AddParameter(cmd, new TypeMateriel.Builder().WithIdType(id).build());
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return ReaderToType(reader);
        }

        public static void AddType(TypeMateriel typeMateriel)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO type(libelle, contenance, sacIntegre) VALUE (@libelle, @contenance, @sacIntegrer)";
            cmd = AddParameter(cmd, typeMateriel);
            cmd.ExecuteNonQuery();
        }

        public static void RemoveType(TypeMateriel typeMateriel)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM type WHERE idType = @idType";
            cmd = AddParameter(cmd, typeMateriel);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateType(TypeMateriel typeMateriel)
        {
            using MySqlConnection connect = Connection.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE type SET libelle = @libelle, contenance = @contenance, sacIntegre = @sacIntegre WHERE idType = @idType";
            cmd = AddParameter(cmd, typeMateriel);
            cmd.ExecuteNonQuery();
        }
    }
}
