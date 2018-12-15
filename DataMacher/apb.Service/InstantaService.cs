using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMacher.apb.Data;
using DataMacher.apb.Repository;

namespace DataMacher.apb.Service
{
    class InstantaService : IInstantaService
    {

        private static InstantaService _instantaService;

        public static InstantaService GetInstantaService
        {
            get
            {
                if (_instantaService == null)
                {
                    _instantaService = new InstantaService();
                }

                return _instantaService;
            }
        }
        public void Add(Instanta product)
        {
            InstantaRepository.GetInstantaRepository.Add(product);
        }

        public Instanta GetById(int id_instanta)
        {
           return InstantaRepository.GetInstantaRepository.GetById(id_instanta);
        }

        public Instanta GetByName(string nume_instanta)
        {
            return InstantaRepository.GetInstantaRepository.GetByName(nume_instanta);
        }

        public void Remove(Instanta instanta)
        {
            InstantaRepository.GetInstantaRepository.Remove(instanta);
        }

        public void Update(Instanta instanta)
        {
            InstantaRepository.GetInstantaRepository.Update(instanta);
        }
    }
}
