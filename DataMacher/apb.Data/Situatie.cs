
namespace DataMacher.apb.Data
{
    public class Situatie
    {
        public virtual int Id_situatie { get; set; }
        public virtual string Nume_situatie { get; set; }
        public virtual int Nr_zile_ramase { get; set; }
        public virtual string Descriere { get; set; }

        public Situatie(string numeSituatie, int zileRamase, string descriere)
        {
            this.Nume_situatie = numeSituatie;
            this.Nr_zile_ramase = zileRamase;
            this.Descriere = descriere;
        }

        public Situatie() { }
    }
}
