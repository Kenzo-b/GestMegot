using GestMegots.Entitees;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestMegots.Modeles
{
    internal class TypeModele
    {
        public static TypeMateriel ReaderToType(MySqlDataReader lecteur)
        {
            TypeMateriel unType = new TypeMateriel.Builder()
                .WithIdType(int.Parse(lecteur[0].ToString()))
                .WithLibelle(lecteur[1].ToString())
                .WithContenance(double.Parse(lecteur[2].ToString()))
                .WithSacIntegre(int.Parse(lecteur[3].ToString()))
                .build();
                
            return unType;
        }
        
        public static List<TypeMateriel> TousLesTypes()
        {
            List<TypeMateriel> lesTypes = new List<TypeMateriel>();
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM Type";
            MySqlDataReader lecteur = cmd.ExecuteReader();
            while(lecteur.Read())
            {
                lesTypes.Add(ReaderToType(lecteur));
            }
            connex.Close();
            return lesTypes;
        }

        public static TypeMateriel GetTypeMaterielById(int id)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "SELECT * FROM Type WHERE idType = @idType";
            cmd.Parameters.Add("@idType", MySqlDbType.Int32).Value = id;
            MySqlDataReader lecteur = cmd.ExecuteReader();
            lecteur.Read();
            TypeMateriel unType = ReaderToType(lecteur);
            connex.Close();
            return unType;
        }

        public static void AjouterType(TypeMateriel typeMateriel)
        {

            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "INSERT INTO type(libelle, contenance, type.sacIntegre) VALUE (@libelle, @contenance, @sacIntegrer)";
            cmd.Parameters.Add("@libelle", MySqlDbType.VarString).Value = typeMateriel.Libelle;
            cmd.Parameters.Add("@contenance", MySqlDbType.Double).Value = typeMateriel.Contenance;
            cmd.Parameters.Add("@sacIntegrer", MySqlDbType.Bit).Value = typeMateriel.SacIntegre;
            cmd.ExecuteNonQuery();
            connex.Close();
        }

        public static void SupprimerType(TypeMateriel typeMateriel)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "DELETE FROM type WHERE idType = @idType";
            cmd.Parameters.Add("@idType", MySqlDbType.Int32).Value = typeMateriel.IdType;
            cmd.ExecuteNonQuery();
            connex.Close();
        }

        public static void ChangerType(TypeMateriel typeMateriel)
        {
            MySqlConnection connex = Connection.Ouvrir();
            MySqlCommand cmd = connex.CreateCommand();
            cmd.CommandText = "UPDATE type SET libelle = @libelle, contenance = @contenance, sacIntegre = @sacIntegre WHERE idType = @idType";
            cmd.Parameters.Add("@libelle", MySqlDbType.VarString).Value = typeMateriel.Libelle;
            cmd.Parameters.Add("@contenance", MySqlDbType.Double).Value = typeMateriel.Contenance;
            cmd.Parameters.Add("@sacIntegre", MySqlDbType.Bit).Value = typeMateriel.SacIntegre;
            cmd.Parameters.Add("@idType", MySqlDbType.Int32).Value = typeMateriel.IdType;
            cmd.ExecuteNonQuery();
            connex.Close(); 
        }
    }
}
