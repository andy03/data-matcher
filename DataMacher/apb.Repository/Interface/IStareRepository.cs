using DataMacher.apb.Data;
using System.Collections.Generic;

namespace DataMacher.apb.Repository
{
    interface IStareRepository
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
