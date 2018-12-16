using DataMacher.apb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMacher.apb.Service.Interface
{
    interface IActService
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
