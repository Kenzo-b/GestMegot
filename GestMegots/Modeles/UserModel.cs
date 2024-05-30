using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Modeles;

public class UserModel
{
    private static MySqlCommand AddParameter(MySqlCommand cmd, User user)
    {
        foreach (var param in UserParameters(user).Where(param => cmd.CommandText.Contains(param.Key)))
        {
            cmd.Parameters.AddWithValue(param.Key, param.Value);
        }
        return cmd;
    }
    
    private static Dictionary<string, object> UserParameters(User user)
    {
        return new Dictionary<string, object>
        {
            {"@id", user.Id},
            {"@pseudo", user.Pseudo},
            {"@passwd", user.Passwd},
            {"@fk_service", user.Service?.Id },
            {"@hab_level", user.Habilitation }
        };
    }
    
    private static User ReaderToUser(MySqlDataReader lecteur)
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
        List<User> lesUsers = new List<User>();
        using MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "SELECT * FROM user";
        MySqlDataReader lecteur = cmd.ExecuteReader();
        while(lecteur.Read())
        {
            lesUsers.Add(ReaderToUser(lecteur));
        }
        return lesUsers;
    }
    
    public static User GetUserById(int id)
    {
        using MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "SELECT * FROM user WHERE id = @id";
        cmd = AddParameter(cmd, new User.Builder().WithId(id).build());
        MySqlDataReader lecteur = cmd.ExecuteReader();
        lecteur.Read();
        return ReaderToUser(lecteur);
    }

    public static User GetUserByPseudo(string pseudo)
    {
        MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "SELECT * FROM user WHERE pseudo = @pseudo";
        cmd.Parameters.AddWithValue("@pseudo", pseudo);
        MySqlDataReader lecteur = cmd.ExecuteReader();
        lecteur.Read();
        return ReaderToUser(lecteur);
    }
    
    public static void AjouterUser(User user)
    {

        using MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "INSERT INTO user(pseudo, passwd, fk_service, hab_level) VALUE (@pseudo, @passwd, @fk_service, @hab_level)";
        cmd = AddParameter(cmd, user);
        cmd.ExecuteNonQuery();
    }
    
    public static void SupprimerUser(User user)
    {
        using MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "DELETE FROM user WHERE id = @id";
        cmd = AddParameter(cmd, user);
        cmd.ExecuteNonQuery();
    }
    
    public static void ChangerUser(User user)
    {
        using MySqlConnection connex = Connection.Ouvrir();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "UPDATE User SET pseudo = @pseudo, passwd = @passwd, fk_service = @fk_service, hab_level = @hab_level WHERE id = @id";
        cmd = AddParameter(cmd, user);
        cmd.ExecuteNonQuery();
    }
}