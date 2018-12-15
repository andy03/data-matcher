using DataMacher.apb.Utils;
using System;

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

        public Stare(IntrebareEnumUtils intrebare, DateTime data, string adresa, string tip, string numeAvct, Instanta instanta, string numeJudecatorie, DateTime dataFotocopiat)
        {
            this.Intrebare = intrebare.ToString();
            this.Data = data;
            this.Adresa = adresa;
            this.Tip = tip;
            this.NumeAvct = numeAvct;
            this.Instanta = instanta;
            this.NumeJudecatorie = numeJudecatorie;
            this.DataFotocopiat = dataFotocopiat;
        }

        public Stare(IntrebareEnumUtils intrebare, DateTime data, string adresa, string tip, string numeAvct, Instanta instanta, string numeJudecatorie)
        {
            this.Intrebare = intrebare.ToString();
            this.Data = data;
            this.Adresa = adresa;
            this.Tip = tip;
            this.NumeAvct = numeAvct;
            this.Instanta = instanta;
            this.NumeJudecatorie = numeJudecatorie;
        }
    }
}
