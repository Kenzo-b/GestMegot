using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Modeles;

public class UserModel
{
    public static User ReaderToUser(MySqlDataReader lecteur)
    {
        return new User.Builder()
            .WithId(int.Parse(lecteur[0].ToString()))
            .WithPseudo(lecteur[1].ToString())
            .WithPasswd(lecteur[2].ToString())
            .WithService(ServiceModele.GetServiceById(int.Parse(lecteur[3].ToString())))
            .WithHabLevel(int.Parse(lecteur[4].ToString()))
            .build();
    }
    
    public static List<User> ToutLesUsers()
    {
        List<User> lesServ = new List<User>();
        MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "SELECT * FROM user";
        MySqlDataReader lecteur = cmd.ExecuteReader();
        while(lecteur.Read())
        {
            lesServ.Add(ReaderToUser(lecteur));
        }
        connex.Close();
        return lesServ;
    }
    
    public static User GetUserById(int id)
    {
        MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "SELECT * FROM user WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        MySqlDataReader lecteur = cmd.ExecuteReader();
        lecteur.Read();
        User unServ = ReaderToUser(lecteur);
        connex.Close();
        return unServ;
    }
    
    public static void AjouterUser(User user)
    {

        MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "INSERT INTO user(pseudo, passwd, fk_service, hab_level) VALUE (@pseudo, @passwd, @fk_service, @hab_level)";
        cmd.Parameters.AddWithValue("@pseudo", user.Pseudo);
        cmd.Parameters.AddWithValue("@passwd", user.Passwd);
        cmd.Parameters.AddWithValue("@fk_service", user.Service.Id);
        cmd.Parameters.AddWithValue("@hab_level", user.Habilitation);
        cmd.ExecuteNonQuery();
        connex.Close();
    }
    
    public static void SupprimerUser(User user)
    {
        MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "DELETE FROM user WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", user.Id);
        cmd.ExecuteNonQuery();
        connex.Close();
    }
    
    public static void ChangerUser(User user)
    {
        MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "UPDATE User SET pseudo = @pseudo, passwd = @passwd, fk_service = @fk_service, hab_level = @hab_level WHERE id = @id";
        cmd.Parameters.AddWithValue("@pseudo", user.Pseudo);
        cmd.Parameters.AddWithValue("@passwd", user.Passwd);
        cmd.Parameters.AddWithValue("@fk_service", user.Service.Id);
        cmd.Parameters.AddWithValue("@hab_level", user.Habilitation);
        cmd.Parameters.AddWithValue("@id", user.Id);
        cmd.ExecuteNonQuery();
        connex.Close(); 
    }
}