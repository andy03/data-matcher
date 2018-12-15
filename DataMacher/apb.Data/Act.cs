using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMacher.apb.Data
{
    public class Act
    {
        public string IdAct { get; set; }
        public Stare Stare { get; set; }
        public Situatie Situatie { get; set; }
        public string TipAct { get; set; }
        public DateTime Data { get; set; }
        
        public Act(Stare Stare, Situatie Situatie, string TipAct, DateTime Data)
        {
            this.Stare = Stare;
            this.Situatie = Situatie;
            this.TipAct = TipAct;
            this.Data = Data;
        }
    }
}
