
using System.Collections.Generic;
using DataMacher.apb.Data;
using DataMacher.apb.Repository;

namespace DataMacher.apb.Service
{
    class SituatieService : ISituatieService
    {
        private static SituatieService _situatieService;

        public static SituatieService GetSituatieService
        {
            get
            {
                if (_situatieService == null)
                {
                    _situatieService = new SituatieService();
                }

                return _situatieService;
            }
        }

        public void Add(Situatie situatie)
        {
            SituatieRepository.GetSituatieRepository.Add(situatie);
        }

        public Situatie GetById(int id_stare)
        {
           return SituatieRepository.GetSituatieRepository.GetById(id_stare);
        }

        public List<Situatie> GetByIntrebare(string nume_intrebare)
        {
            return SituatieRepository.GetSituatieRepository.GetByName(nume_intrebare);
        }

        public List<Situatie> GetByNrZileRamase(int nr_zile_ramase)
        {
            return SituatieRepository.GetSituatieRepository.GetByNrZileRamase(nr_zile_ramase);
        }

        public void Remove(Situatie situatie)
        {
            SituatieRepository.GetSituatieRepository.Remove(situatie);
        }

        public void Update(Situatie situatie)
        {
            SituatieRepository.GetSituatieRepository.Update(situatie);

        }
    }
}
