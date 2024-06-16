namespace GestMegots.entities
{
    public class TypeMateriel
    {
        private int idType;
        private string libelle;
        private double contenance;
        private int? sacIntegre;

        public int IdType { get => idType; set => idType = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public double Contenance { get => contenance; set => contenance = value; }
        public int? SacIntegre { get => sacIntegre; set => sacIntegre = value; }

        public class Builder
        {
            private int idType;
            private string libelle;
            private double contenance;
            private int? sacIntegre;

            public int IdType { get => idType; set => idType = value; }
            public string Libelle { get => libelle; set => libelle = value; }
            public double Contenance { get => contenance; set => contenance = value; }
            public int? SacIntegre { get => sacIntegre; set => sacIntegre = value; }

            public Builder WithIdType(int idType)
            {
                IdType = idType;
                return this;
            }

            public Builder WithLibelle(string libelle)
            {
                Libelle = libelle;
                return this;
            }

            public Builder WithContenance(double contenance)
            {
                Contenance = contenance;
                return this;
            }

            public Builder WithSacIntegre(int sacIntegre)
            {
                SacIntegre = sacIntegre;
                return this;
            }

            public TypeMateriel build()
            {
                return new TypeMateriel(this);
            }
        }

        private TypeMateriel(Builder builder)
        {
            IdType = builder.IdType;
            Libelle = builder.Libelle;
            Contenance = builder.Contenance;
            SacIntegre = builder.SacIntegre;
        }

        public override string ToString()
        {
            return libelle;
        }
    }
}