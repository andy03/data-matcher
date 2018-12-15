using DataMacher.apb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMacher.apb.Repository
{
    interface IInstantaRepository
    {
        void Add(Instanta instanta);

        void Update(Instanta instanta);

        void Remove(Instanta instanta);

        Instanta GetById(int id_instanta);

        Instanta GetByName(string nume_instanta);
    }
}
