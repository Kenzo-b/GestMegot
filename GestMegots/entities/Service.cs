namespace GestMegots.entities;

public class Service
{
    private int id;
    private string nom;
    
    public int Id { get => id ; set => id = value;}
    public string Nom{get => nom ; set => nom = value;}

    public class Builder
    {
        private int id;
        private string nom;
    
        public int Id { get => id ; set => id = value;}
        public string Nom{get => nom ; set => nom = value;}

        public Builder WithId(int id)
        {
            Id = id;
            return this;
        }

        public Builder WithNom(string nom)
        {
            Nom = nom;
            return this;
        }

        public Service build()
        {
            return new Service(this);
        }
    }

    private Service(Builder builder)
    {
        Id = builder.Id;
        Nom = builder.Nom;
    }

    public override string ToString()
    {
        return Nom;
    }
}