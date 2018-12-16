using DataMacher.apb.Data;
using System.Collections.Generic;

namespace DataMacher.apb.Repository.Interface
{
    interface IActRepository
    {
        void Add(Act act);

        void Update(Act act);

        void Remove(Act act);

        Act GetById(int id_act);

        List<Act> GetByStare(Stare stare);

        List<Act> GetBySituatie(Situatie situatie);

        List<Act> GetByTipAct(string tip_act);
    }
}
