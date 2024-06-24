# GestMegot

---

GestMegot is a CRUD app based on the management of hotspots (where a lot of cigarette end is throw on the floor) and the material that use to collect and limit pollution caused by smoker that trow their cigarette to the floor.

to use this application you have to install a MySQL like database.  

moreover you have to put your database connection into Connection.cs :

```C#
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
```


the default credential is :

- user : root
- password : root

if you want to try different level of privilege you can make new user into the User form.

the dataset used into the database is about the city Laon in France.
