using DataMacher.apb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMacher.apb.Service
{
    interface IStareService
    {
        void Add(Stare stare);

        void Update(Stare stare);

        void Remove(Stare stare);

        Stare GetById(int id_stare);

        List<Stare> GetByIntrebare(string nume_intrebare);

        List<Stare> GetByAdresa(string adresa);

        List<Stare> GetByNumeAvct(string numeAvct);

        List<Stare> GetByInstanta(Instanta instanta);

        List<Stare> GetByNumeJudecatorie(string numeJudecatorie);
    }
}
