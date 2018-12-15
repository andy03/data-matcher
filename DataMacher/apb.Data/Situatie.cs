using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMacher.apb.Data
{
    public class Situatie
    {
        public int IdSituatie { get; set; }
        public string NumeSituatie { get; set; }
        public int ZileRamase { get; set; }
        public string Descriere { get; set; }

        public Situatie(string NumeSituatie, int ZileRamase, string Descriere)
        {
            this.NumeSituatie = NumeSituatie;
            this.ZileRamase = ZileRamase;
            this.Descriere = Descriere;
        }
    }
}
