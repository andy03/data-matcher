
using System.Collections.Generic;
using DataMacher.apb.Data;
using DataMacher.apb.Utils;
using NHibernate;

namespace DataMacher.apb.Repository
{
    class SituatieRepository : ISituatieRepository
    {
        private static SituatieRepository _situatieRepository;

        public static SituatieRepository GetSituatieRepository
        {
            get
            {
                if (_situatieRepository == null)
                {
                    _situatieRepository = new SituatieRepository();
                }

                return _situatieRepository;
            }
        }

        public void Add(Situatie situatie)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(situatie);
                transaction.Commit();
            }
        }

        public Situatie GetById(int id_situatie)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Situatie situatie = session.QueryOver<Situatie>().Where(x => x.Id_situatie == id_situatie).SingleOrDefault();
                return situatie;
            }
        }

        public List<Situatie> GetByName(string nume_situatie)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Situatie> situatieList = (List<Situatie>)session.QueryOver<Situatie>().Where(x => x.Nume_situatie == nume_situatie).List();
                return situatieList;
            }
        }

        public List<Situatie> GetByNrZileRamase(int nr_zile_ramase)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Situatie> situatieList = (List<Situatie>)session.QueryOver<Situatie>().Where(x => x.Nr_zile_ramase == nr_zile_ramase).List();
                return situatieList;
            }
        }

        public void Remove(Situatie situatie)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(situatie);
                transaction.Commit();
            }
        }

        public void Update(Situatie situatie)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(situatie);
                transaction.Commit();
            }
        }
    }
}
