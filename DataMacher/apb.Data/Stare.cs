using DataMacher.apb.Utils;
using System;

namespace DataMacher.apb.Data
{
    public class Stare
    {
        public virtual int Id_stare { get; set; }
        public virtual string Nume_intrebare { get; set; }
        public virtual DateTime Data_intrebare { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Nume_avct { get; set; }
        public virtual Instanta Instanta { get; set; }
        public virtual string Nume_jdctr { get; set; }
        public virtual DateTime Data_fotocopiat { get; set; }

        public Stare(IntrebareEnumUtils nume_intrebare, DateTime data_intrebare, string adresa, string numeAvct, Instanta instanta, string nume_jdctr, DateTime data_Fotocopiat)
        {
            this.Nume_intrebare = nume_intrebare.ToString();
            this.Data_intrebare = data_intrebare;
            this.Adresa = adresa;
            this.Nume_avct = numeAvct;
            this.Instanta = instanta;
            this.Nume_jdctr = nume_jdctr;
            this.Data_fotocopiat = data_Fotocopiat;
        }

        public Stare(IntrebareEnumUtils nume_intrebare, DateTime data_intrebare, string adresa, string numeAvct, Instanta instanta, string nume_jdctr)
        {
            this.Nume_intrebare = nume_intrebare.ToString();
            this.Data_intrebare = data_intrebare;
            this.Adresa = adresa;
            this.Nume_avct = numeAvct;
            this.Instanta = instanta;
            this.Nume_jdctr = nume_jdctr;
        }

        public Stare() { }
    }
}
