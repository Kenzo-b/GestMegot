namespace GestMegots.Entitees
{
    public class Secteur
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return name;
        }

        public class Builder
        {
            private int id;
            private string name;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }

            public Builder WithId(int id)
            {
                Id = id;
                return this;
            }

            public Builder WithName(string name)
            {
                Name = name;
                return this;
            }

            public Secteur Build()
            {
                return new Secteur(this);
            }
        }

        private Secteur(Builder builder)
        {
            Id = builder.Id;
            Name = builder.Name;
        }
    }
}