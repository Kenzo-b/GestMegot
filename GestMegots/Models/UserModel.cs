using GestMegots.Class;
using GestMegots.entities;
using MySql.Data.MySqlClient;

namespace GestMegots.Models;

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
            {"@hab_level", user.Ability }
        };
    }
    
    private static User ReaderToUser(MySqlDataReader lecteur)
    {
        return new User.Builder()
            .WithId(int.Parse(lecteur[0].ToString()))
            .WithPseudo(lecteur[1].ToString())
            .WithPasswd(lecteur[2].ToString())
            .WithService(ServiceModel.GetServiceById(int.Parse(lecteur[3].ToString())))
            .WithHabLevel(int.Parse(lecteur[4].ToString()))
            .build();
    }
    
    public static List<User> AllUsers()
    {
        List<User> users = new List<User>();
        using MySqlConnection connect = Connection.Open();
        MySqlCommand cmd = connect.CreateCommand();
        cmd.CommandText = "SELECT * FROM user";
        MySqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read())
        { 
            users.Add(ReaderToUser(reader));
        }
        return users;
    }
    
    public static User GetUserById(int id)
    {
        using MySqlConnection connect = Connection.Open();
        MySqlCommand cmd = connect.CreateCommand();
        cmd.CommandText = "SELECT * FROM user WHERE id = @id";
        cmd = AddParameter(cmd, new User.Builder().WithId(id).build());
        MySqlDataReader reader = cmd.ExecuteReader(); 
        reader.Read();
        return ReaderToUser(reader);
    }

    public static User GetUserByPseudo(string pseudo)
    {
        MySqlConnection connect = Connection.Open();
        MySqlCommand cmd = connect.CreateCommand();
        cmd.CommandText = "SELECT * FROM user WHERE pseudo = @pseudo";
        cmd.Parameters.AddWithValue("@pseudo", pseudo);
        MySqlDataReader reader = cmd.ExecuteReader();
        reader.Read();
        return ReaderToUser(reader);
    }
    
    public static void AddUser(User user)
    {

        using MySqlConnection connect = Connection.Open();
        MySqlCommand cmd = connect.CreateCommand();
        cmd.CommandText = "INSERT INTO user(pseudo, passwd, fk_service, hab_level) VALUE (@pseudo, @passwd, @fk_service, @hab_level)";
        cmd = AddParameter(cmd, user);
        cmd.ExecuteNonQuery();
    }
    
    public static void RemoveUser(User user)
    {
        using MySqlConnection connect = Connection.Open();
        MySqlCommand cmd = connect.CreateCommand();
        cmd.CommandText = "DELETE FROM user WHERE id = @id";
        cmd = AddParameter(cmd, user);
        cmd.ExecuteNonQuery();
    }
    
    public static void UpdateUser(User user)
    {
        using MySqlConnection connect = Connection.Open();
        MySqlCommand cmd = connect.CreateCommand();
        cmd.CommandText = "UPDATE user SET pseudo = @pseudo, passwd = @passwd, fk_service = @fk_service, hab_level = @hab_level WHERE id = @id";
        cmd = AddParameter(cmd, user);
        cmd.ExecuteNonQuery();
    }

    public static bool IsSamePassword(string pseudo, string password)
    {
        return GetUserByPseudo(pseudo).Passwd == Hashing.ToSha256(password);
    }
}