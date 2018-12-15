using System;

namespace DataMacher.apb.Data
{
    public class Act
    {
        public string IdAct { get; set; }
        public Stare Stare { get; set; }
        public Situatie Situatie { get; set; }
        public string TipAct { get; set; }
        public DateTime Data { get; set; }
        
        public Act(Stare stare, Situatie situatie, string tipAct, DateTime data)
        {
            this.Stare = stare;
            this.Situatie = situatie;
            this.TipAct = tipAct;
            this.Data = data;
        }
    }
}
