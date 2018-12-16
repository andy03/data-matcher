using System.Collections.Generic;
using DataMacher.apb.Data;
using DataMacher.apb.Repository;
using DataMacher.apb.Service.Interface;

namespace DataMacher.apb.Service
{
    class ActService : IActService
    {
        private static ActService _actService;

        public static ActService GetActService
        {
            get
            {
                if (_actService == null)
                {
                    _actService = new ActService();
                }

                return _actService;
            }
        }

        public void Add(Act act)
        {
            ActRepository.GetActRepository.Add(act);
        }

        public Act GetById(int id_act)
        {
            return ActRepository.GetActRepository.GetById(id_act);
        }

        public List<Act> GetBySituatie(Situatie situatie)
        {
            return ActRepository.GetActRepository.GetBySituatie(situatie);
        }

        public List<Act> GetByStare(Stare stare)
        {
            return ActRepository.GetActRepository.GetByStare(stare);
        }

        public List<Act> GetByTipAct(string tip_act)
        {
            return ActRepository.GetActRepository.GetByTipAct(tip_act);
        }

        public void Remove(Act act)
        {
            ActRepository.GetActRepository.Remove(act);
        }

        public void Update(Act act)
        {
            ActRepository.GetActRepository.Update(act);
        }
    }
}
