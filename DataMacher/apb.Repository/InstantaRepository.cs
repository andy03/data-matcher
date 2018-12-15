using DataMacher.apb.Data;
using DataMacher.apb.Utils;
using NHibernate;

namespace DataMacher.apb.Repository
{
    class InstantaRepository : IInstantaRepository
    {
        private static InstantaRepository _instantaRepository;

        public static InstantaRepository GetInstantaRepository
        {
            get 
            {
                if(_instantaRepository == null)
                {
                    _instantaRepository = new InstantaRepository();
                }

                return _instantaRepository;
            }
        }

        public void Add(Instanta instanta)
        {
            using(ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(instanta);
                transaction.Commit();
            }
        }

        public Instanta GetById(int id_instanta)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Instanta instanta = session.QueryOver<Instanta>().Where(x => x.Id_instanta == id_instanta).SingleOrDefault();
                return instanta;
            }
        }

        public Instanta GetByName(string nume_instanta)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Instanta instanta = session.QueryOver<Instanta>().Where(x => x.Nume_instanta == nume_instanta).SingleOrDefault();
                return instanta;
            }
        }

        public void Remove(Instanta instanta)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(instanta);
                transaction.Commit();
            }
        }

        public void Update(Instanta instanta)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(instanta);
                transaction.Commit();
            }
        }
    }
}
