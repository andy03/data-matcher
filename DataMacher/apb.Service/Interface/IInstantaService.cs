using DataMacher.apb.Data;

namespace DataMacher.apb.Service
{
    interface IInstantaService
    {
        void Add(Instanta product);

        void Update(Instanta product);

        void Remove(Instanta product);

        Instanta GetById(int productId);

        Instanta GetByName(string name);
    }
}
