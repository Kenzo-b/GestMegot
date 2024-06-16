namespace GestMegots.entities
{
    public class Sector
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

            public Sector Build()
            {
                return new Sector(this);
            }
        }

        private Sector(Builder builder)
        {
            Id = builder.Id;
            Name = builder.Name;
        }
    }
}