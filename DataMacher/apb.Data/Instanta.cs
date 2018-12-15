
namespace DataMacher.apb.Data
{
    public class Instanta
    {
        public virtual int Id_instanta { get; set; }
        public virtual string Nume_instanta { get; set; }

        public Instanta(string nume_instanta)
        {
            this.Nume_instanta = nume_instanta;
        }

        public Instanta() { }
    }
}
