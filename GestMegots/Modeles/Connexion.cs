using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace GestMegots.Modeles
{
    public static class Connection
    {
        private const string SERVER = "localhost";
        private const string PORT = "3306";
        private const string DATABASE = "gest_megot";
        private const string UID = "root";


        public static MySqlConnection Ouvrir() 
        { 
            string connectInfo = $"server={SERVER};" +
                                 $"port={PORT};" +
                                 $"database={DATABASE};" +
                                 $"uid={UID}";

            MySqlConnection connect = new MySqlConnection(connectInfo);
            connect.Open();
            return connect;
        }

    }
}
