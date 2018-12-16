using DataMacher.apb.Data;
using System.Collections.Generic;

namespace DataMacher.apb.Service
{
    interface ISituatieService
    {
            void Add(Situatie situatie);

            void Update(Situatie situatie);

            void Remove(Situatie situatie);

            Situatie GetById(int id_stare);

            List<Situatie> GetByIntrebare(string nume_intrebare);

        List<Situatie> GetByNrZileRamase(int nr_zile_ramase);

    }
}