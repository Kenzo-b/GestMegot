namespace GestMegots.Entitees;

public class Collecte
{
    private int id;
    private int nbMegot;
    private Materiel mat;
    private DateTime dateCollecte;
    public int Id { get => id; set => id = value; }
    public int NbMegot { get => nbMegot ; set => nbMegot = value; }
    public Materiel Mat { get => mat ; set => mat = value; }
    public DateTime DateCollecte { get => dateCollecte ; set => dateCollecte = value; }
    
    public class  Builder
    {
        private int id;
        private int nbMegot;
        private Materiel mat;
        private DateTime dateCollecte;
        public int Id { get => id; set => id = value; }
        public int NbMegot { get => nbMegot ; set => nbMegot = value; }
        public Materiel Mat { get => mat ; set => mat = value; }
        public DateTime DateCollecte { get => dateCollecte ; set => dateCollecte = value; }

        public Builder WithId(int id)
        {
            Id = id;
            return this;
        }

        public Builder WithNbMegot(int nbMegot)
        {
            NbMegot = nbMegot;
            return this;
        }

        public Builder WithMateriel(Materiel materiel)
        {
            Mat = materiel;
            return this;
        }

        public Builder WithDateCollecte(DateTime dateCollecte)
        {
            DateCollecte = dateCollecte;
            return this;
        }

        public Collecte build()
        {
            return new Collecte(this);
        }
    }

    private Collecte(Builder builder)
    {
        Id = builder.Id;
        NbMegot = builder.NbMegot;
        Mat = builder.Mat;
        DateCollecte = builder.DateCollecte;
    }
}

