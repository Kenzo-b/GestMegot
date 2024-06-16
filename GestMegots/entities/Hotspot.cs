namespace GestMegots.entities
{
    public class Hotspot
    {
        private int idHS;
        private string coordoGPS;
        private string nom;
        private string adresse;
        private int terrasse;
        private Sector leSector;
        private Categorie laCategorie;
        private Materiel leMateriel;

        public int IdHs { get => idHS; set => idHS = value; }
        public string CoordoGps { get => coordoGPS; set => coordoGPS = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Terrasse { get => terrasse; set => terrasse = value; }
        public Sector LeSector { get => leSector; set => leSector = value; }
        public Categorie LaCategorie { get => laCategorie; set => laCategorie = value; }
        public Materiel LeMateriel { get => leMateriel; set => leMateriel = value; }

        public class Builder
        {
            public int IdHs { get; private set; }
            public string CoordoGps { get; private set; }
            public string Nom { get; private set; }
            public string Adresse { get; private set; }
            public int Terrasse { get; private set; }
            public Sector LeSector { get; private set; }
            public Categorie LaCategorie { get; private set; }
            public Materiel LeMateriel { get; private set; }

            
            public Builder WithIdHS(int idHS)
            {
                IdHs = idHS;
                return this;
            }

            public Builder WithCoordoGPS(string coordoGPS)
            {
                CoordoGps = coordoGPS;
                return this;
            }

            public Builder WithNom(string nom)
            {
                Nom = nom;
                return this;
            }

            public Builder WithAdresse(string adresse)
            {
                Adresse = adresse;
                return this;
            }

            public Builder WithTerrasse(int terrasse)
            {
                Terrasse = terrasse;
                return this;
            }

            public Builder WithLeSecteur(Sector leSector)
            {
                LeSector = leSector;
                return this;
            }

            public Builder WithLaCategorie(Categorie laCategorie)
            {
                LaCategorie = laCategorie;
                return this;
            }

            public Builder WithLeMateriel(Materiel leMateriel)
            {
                LeMateriel = leMateriel;
                return this;
            }

            public Hotspot Build()
            {
                return new Hotspot(this);
            }
        }

        private Hotspot(Builder builder)
        {
            IdHs = builder.IdHs;
            CoordoGps = builder.CoordoGps;
            Nom = builder.Nom;
            Adresse = builder.Adresse;
            Terrasse = builder.Terrasse;
            LeSector = builder.LeSector;
            LaCategorie = builder.LaCategorie;
            LeMateriel = builder.LeMateriel;
        }
    }
}
