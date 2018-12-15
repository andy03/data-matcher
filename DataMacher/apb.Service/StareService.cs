using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMacher.apb.Data;
using DataMacher.apb.Repository;

namespace DataMacher.apb.Service
{
    class StareService : IStareService
    {

        private static StareService _stareService;

        public static StareService GetStareService
        {
            get
            {
                if (_stareService == null)
                {
                    _stareService = new StareService();
                }

                return _stareService;
            }
        }

        public void Add(Stare stare)
        {
            StareRepository.GetStareRepository.Add(stare);
        }

        public List<Stare> GetByAdresa(string adresa)
        {
            return StareRepository.GetStareRepository.GetByAdresa(adresa);
        }

        public Stare GetById(int id_stare)
        {
            return StareRepository.GetStareRepository.GetById(id_stare);
        }

        public List<Stare> GetByInstanta(Instanta instanta)
        {
            return StareRepository.GetStareRepository.GetByInstanta(instanta);
        }

        public List<Stare> GetByIntrebare(string nume_intrebare)
        {
            return StareRepository.GetStareRepository.GetByIntrebare(nume_intrebare);
        }

        public List<Stare> GetByNumeAvct(string numeAvct)
        {
            return StareRepository.GetStareRepository.GetByNumeAvct(numeAvct);
        }

        public List<Stare> GetByNumeJudecatorie(string numeJudecatorie)
        {
            return StareRepository.GetStareRepository.GetByNumeJudecatorie(numeJudecatorie);
        }

        public void Remove(Stare stare)
        {
            StareRepository.GetStareRepository.Remove(stare);
        }

        public void Update(Stare stare)
        {
            StareRepository.GetStareRepository.Update(stare);
        }
    }
}
