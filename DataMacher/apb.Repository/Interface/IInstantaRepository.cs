using DataMacher.apb.Data;

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
