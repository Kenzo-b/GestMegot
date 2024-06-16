namespace GestMegots.entities;

public class User
{
    private int id;
    private string pseudo;
    private string password;
    private Service service;
    private int ability;
    
    public int Id { get => id; set => id = value; }
    public string Pseudo { get => pseudo; set => pseudo = value; }
    public string Passwd { get => password; set => password = value; }
    public Service Service { get => service; set => service = value; }
    public int Ability { get => ability; set => ability = value; }
    
    public class Builder
    {
        private int id;
        private string pseudo;
        private string password;
        private Service service;
        private int ability;
    
        public int Id { get => id; set => id = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Password { get => password; set => password = value; }
        public Service Service { get => service; set => service = value; }
        public int Ability { get => ability; set => ability = value; }
        
        public Builder WithId(int id)
        {
            this.id = id;
            return this;
        }

        public Builder WithPseudo(string pseudo)
        {
            this.pseudo = pseudo;
            return this;
        }

        public Builder WithPasswd(string passwd)
        {
            this.password = passwd;
            return this;
        }

        public Builder WithService(Service service)
        {
            this.service = service;
            return this;
        }

        public Builder WithHabLevel(int habLevel)
        {
            this.ability = habLevel;
            return this;
        }

        public User build()
        {
            return new User(this);
        }
    }

    private User(Builder builder)
    {
        Id = builder.Id;
        Pseudo = builder.Pseudo;
        Passwd = builder.Password;
        service = builder.Service;
        Ability = builder.Ability;
    }
}