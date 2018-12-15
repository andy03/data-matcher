using DataMacher.apb.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMacher.apb.Data
{
    public class Stare
    {
        public int IdStare { get; set; }
        public string Intrebare { get; set; }
        public DateTime Data { get; set; }
        public string Adresa { get; set; }
        public string Tip { get; set; }
        public string NumeAvct { get; set; }
        public Instanta Instanta { get; set; }
        public string NumeJudecatorie { get; set; }
        public DateTime DataFotocopiat { get; set; }

        public Stare(IntrebareEnumUtils Intrebare, DateTime Data, string Adresa, string Tip, string NumeAvct, Instanta Instanta, string NumeJudecatorie, DateTime DataFotocopiat)
        {
            this.Intrebare = Intrebare.ToString();
            this.Data = Data;
            this.Adresa = Adresa;
            this.Tip = Tip;
            this.NumeAvct = NumeAvct;
            this.Instanta = Instanta;
            this.NumeJudecatorie = NumeJudecatorie;
            this.DataFotocopiat = DataFotocopiat;
        }

        public Stare(IntrebareEnumUtils Intrebare, DateTime Data, string Adresa, string Tip, string NumeAvct, Instanta Instanta, string NumeJudecatorie)
        {
            this.Intrebare = Intrebare.ToString();
            this.Data = Data;
            this.Adresa = Adresa;
            this.Tip = Tip;
            this.NumeAvct = NumeAvct;
            this.Instanta = Instanta;
            this.NumeJudecatorie = NumeJudecatorie;
        }
    }
}
