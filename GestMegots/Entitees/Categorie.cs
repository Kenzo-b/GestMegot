namespace GestMegots.Entitees
{
    public class Categorie
    {
        private int id;
        private string name;
        private string? remarque;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string? Remarque { get => remarque; set => remarque = value; }

        public override string ToString()
        {
            return name;
        }

        public class Builder
        {
            private int id;
            private string name;
            private string? remarque;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
            public string? Remarque { get => remarque; set => remarque = value; }

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

            public Builder WithRemarque(string remarque)
            {
                Remarque = remarque;
                return this;
            }

            public Categorie Build()
            {
                return new Categorie(this);
            }
        }

        private Categorie(Builder builder)
        {
            Id = builder.Id;
            Name = builder.Name;
            Remarque = builder.Remarque;
        }

    }
}