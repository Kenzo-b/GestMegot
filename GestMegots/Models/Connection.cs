using MySql.Data.MySqlClient;

namespace GestMegots.Models
{
    public static class Connection
    {
        //change and add your DB information
        
        private const string Server = "localhost";
        private const string Port = "3306";
        private const string Database = "gest_megot";
        private const string Uid = "root";
        private const string Password = "toto";
        
        public static MySqlConnection Open() 
        { 
            const string connectInfo = $"server={Server};" +
                                       $"port={Port};" +
                                       $"database={Database};" +
                                       $"uid={Uid};" +
                                       $"password={Password}";

            MySqlConnection connect = new MySqlConnection(connectInfo);
            connect.Open();
            return connect;
        }
    }
}
