using GestMegots.Entitees;
using MySql.Data.MySqlClient;

namespace GestMegots.Models;

public class ServiceModele
{
    private static Service ReaderToService(MySqlDataReader lecteur)
    {
        return new Service.Builder()
            .WithId(int.Parse(lecteur[0].ToString()))
            .WithNom(lecteur[1].ToString())
            .build();
    }
    
    public static List<Service> ToutLesServices()
    {
        List<Service> lesServ = new List<Service>();
        using MySqlConnection connex = Connection.Open();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "SELECT * FROM service";
        MySqlDataReader Lecteur = cmd.ExecuteReader();
        while(Lecteur.Read())
        {
            lesServ.Add(ReaderToService(Lecteur));
        }
        return lesServ;
    }
    
    public static Service GetServiceById(int id)
    {
        using MySqlConnection connex = Connection.Open();
        MySqlCommand cmd = connex.CreateCommand();
        cmd.CommandText = "SELECT * FROM service WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        MySqlDataReader lecteur = cmd.ExecuteReader();
        lecteur.Read();
        return ReaderToService(lecteur);
    }
}