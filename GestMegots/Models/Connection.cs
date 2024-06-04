using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    public static class Connection
    {
        private const string Server = "localhost";
        private const string Port = "3306";
        private const string Database = "gest_megot";
        private const string Uid = "root";
        
        public static MySqlConnection Open() 
        { 
            const string connectInfo = $"server={Server};" +
                                       $"port={Port};" +
                                       $"database={Database};" +
                                       $"uid={Uid}";

            MySqlConnection connect = new MySqlConnection(connectInfo);
            connect.Open();
            return connect;
        }
    }
}
