
namespace DataMacher.apb.Data
{
    public class Situatie
    {
        public int IdSituatie { get; set; }
        public string NumeSituatie { get; set; }
        public int ZileRamase { get; set; }
        public string Descriere { get; set; }

        public Situatie(string numeSituatie, int zileRamase, string descriere)
        {
            this.NumeSituatie = numeSituatie;
            this.ZileRamase = zileRamase;
            this.Descriere = descriere;
        }
    }
}
