using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Models;

public static class ServiceModel
{
    private static Service ReaderToService(MySqlDataReader reader)
    {
        return new Service.Builder()
            .WithId(int.Parse(reader[0].ToString()))
            .WithNom(reader[1].ToString())
            .build();
    }
    
    public static List<Service> AllServices()
    {
        List<Service> services = new List<Service>();
        using MySqlConnection connect = Connection.Open();
        MySqlCommand cmd = connect.CreateCommand();
        cmd.CommandText = "SELECT * FROM service";
        MySqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read())
        {
            services.Add(ReaderToService(reader));
        }
        return services;
    }
    
    public static Service GetServiceById(int id)
    {
        using MySqlConnection connect = Connection.Open();
        MySqlCommand cmd = connect.CreateCommand();
        cmd.CommandText = "SELECT * FROM service WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        MySqlDataReader reader = cmd.ExecuteReader();
        reader.Read();
        return ReaderToService(reader);
    }
}