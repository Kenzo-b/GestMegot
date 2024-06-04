using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    internal class TypeModele
    {
        private static MySqlCommand AddParameter(MySqlCommand cmd, TypeMateriel unType)
        {
            foreach (var param in TypeParameter(unType).Where(param => cmd.CommandText.Contains(param.Key)))
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
                { "@libelle", unType.Libelle },
                { "@contenance", unType.Contenance },
                { "@sacIntegrer", unType.SacIntegre }
            };
        }
        
        private static TypeMateriel ReaderToType(MySqlDataReader lecteur)
        {
            return new TypeMateriel.Builder()
                .WithIdType(int.Parse(lecteur[0].ToString()))
                .WithLibelle(lecteur[1].ToString())
                .WithContenance(double.Parse(lecteur[2].ToString()))
                .WithSacIntegre(int.Parse(lecteur[3].ToString()))
                .build();
        }
        
        public static List<TypeMateriel> ToutLesTypes()
        {
            List<TypeMateriel> lesTypes = new List<TypeMateriel>();
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM Type";
            MySqlDataReader lecteur = cmd.ExecuteReader();
            while(lecteur.Read())
            {
                lesTypes.Add(ReaderToType(lecteur));
            }
            return lesTypes;
        }

        public static TypeMateriel GetTypeMaterielById(int id)
        {
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM Type WHERE idType = @idType";
            cmd = AddParameter(cmd, new TypeMateriel.Builder().WithIdType(id).build());
            MySqlDataReader lecteur = cmd.ExecuteReader();
            lecteur.Read();
            return ReaderToType(lecteur);
        }

        public static void AjouterType(TypeMateriel typeMateriel)
        {
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "INSERT INTO type(libelle, contenance, sacIntegre) VALUE (@libelle, @contenance, @sacIntegrer)";
            cmd = AddParameter(cmd, typeMateriel);
            cmd.ExecuteNonQuery();
        }

        public static void SupprimerType(TypeMateriel typeMateriel)
        {
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "DELETE FROM type WHERE idType = @idType";
            cmd = AddParameter(cmd, typeMateriel);
            cmd.ExecuteNonQuery();
        }

        public static void ChangerType(TypeMateriel typeMateriel)
        {
            using MySqlConnection connex = Connection.Open();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "UPDATE type SET libelle = @libelle, contenance = @contenance, sacIntegre = @sacIntegre WHERE idType = @idType";
            cmd = AddParameter(cmd, typeMateriel);
            cmd.ExecuteNonQuery();
        }
    }
}
