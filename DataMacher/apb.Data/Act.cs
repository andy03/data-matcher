using System;

namespace DataMacher.apb.Data
{
    public class Act
    {
        public virtual string Id_act { get; set; }
        public virtual Stare Stare { get; set; }
        public virtual Situatie Situatie { get; set; }
        public virtual string Tip_act { get; set; }
        public virtual DateTime Data { get; set; }
        
        public Act(Stare stare, Situatie situatie, string tipAct, DateTime data)
        {
            this.Stare = stare;
            this.Situatie = situatie;
            this.Tip_act = tipAct;
            this.Data = data;
        }

        public Act() { }
    }
}
