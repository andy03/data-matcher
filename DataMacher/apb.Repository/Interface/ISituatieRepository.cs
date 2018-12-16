
using DataMacher.apb.Data;
using System.Collections.Generic;

namespace DataMacher.apb.Repository
{
    interface ISituatieRepository
    {
        void Add(Situatie situatie);

        void Update(Situatie situatie);

        void Remove(Situatie situatie);

        Situatie GetById(int id_situatie);

        List<Situatie> GetByName(string nume_situatie);

        List<Situatie> GetByNrZileRamase(int nr_zile_ramase);
    }
}
