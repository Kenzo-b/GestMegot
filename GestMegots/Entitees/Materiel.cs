using Google.Protobuf.WellKnownTypes;


namespace GestMegots.Entitees
{
    public class Materiel
    {
        private int reference;
        private string couleurs;
        private DateTime dateInstal;
        private string adresse;
        private string coordoGps;
        private TypeMateriel leType;
        private int op;

        public int Reference { get => reference; set => reference = value; }
        public string Couleurs { get => couleurs; set => couleurs = value; }
        public DateTime DateInstal { get => dateInstal; set => dateInstal = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string CoordoGps { get => coordoGps; set => coordoGps = value; }
        public TypeMateriel LeType { get => leType; set => leType = value; }
        public int Op { get => op; set => op = value; }

        public class Builder
        {
            private int reference;
            private string couleurs;
            private DateTime dateInstal;
            private string adresse;
            private string coordoGps;
            private TypeMateriel leType;
            private int op;

            public int Reference { get => reference; set => reference = value; }
            public string Couleurs { get => couleurs; set => couleurs = value; }
            public DateTime DateInstal { get => dateInstal; set => dateInstal = value; }
            public string Adresse { get => adresse; set => adresse = value; }
            public string CoordoGps { get => coordoGps; set => coordoGps = value; }
            public TypeMateriel? LeType { get => leType; set => leType = value; }
            public int Op { get => op; set => op = value; }


            public Builder WithReference(int reference)
            {
                Reference = reference;
                return this;
            }

            public Builder WithCouleur(string couleur)
            {
                Couleurs = couleur;
                return this;
            }

            public Builder WithDateInstal(DateTime dateInstal)
            {
                DateInstal = dateInstal;
                return this;
            }

            public Builder WithAdresse(string adresse)
            {
                Adresse = adresse;
                return this;
            }

            public Builder WithCoordoGPS(string coordoGps)
            {
                CoordoGps = coordoGps;
                return this;
            }

            public Builder WithLeType(TypeMateriel leType)
            {
                LeType = leType; 
                return this;
            }

            public Builder WithOp(int op)
            {
                Op = op;
                return this;
            }


            public Materiel build()
            {
                return new Materiel(this);
            }
        }

        private Materiel(Builder builder)
        {
            Reference = builder.Reference;
            Couleurs = builder.Couleurs;
            DateInstal = builder.DateInstal;
            Adresse = builder.Adresse;
            CoordoGps = builder.CoordoGps;
            LeType = builder.LeType;
            Op = builder.Op;
        }

        public override string ToString()
        {
            return Reference.ToString();
        }
    }
}