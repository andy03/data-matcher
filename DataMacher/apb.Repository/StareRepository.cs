
using DataMacher.apb.Data;
using DataMacher.apb.Utils;
using NHibernate;
using System.Collections.Generic;

namespace DataMacher.apb.Repository
{
    class StareRepository : IStareRepository
    {

        private static StareRepository _stareRepository;

        public static StareRepository GetStareRepository
        {
            get
            {
                if (_stareRepository == null)
                {
                    _stareRepository = new StareRepository();
                }

                return _stareRepository;
            }
        }
        public void Add(Stare stare)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(stare);
                transaction.Commit();
            }
        }

        public Stare GetById(int id_stare)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Stare stare = session.QueryOver<Stare>().Where(x => x.Id_stare == id_stare).SingleOrDefault();
                return stare;
            }
        }

        public List<Stare> GetByIntrebare(string nume_intrebare)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Stare> stareList = (List<Stare>)session.QueryOver<Stare>().Where(x => x.Nume_intrebare == nume_intrebare).List();
                return stareList;
            }
        }

        public List<Stare> GetByAdresa(string adresa)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Stare> stareList = (List<Stare>)session.QueryOver<Stare>().Where(x => x.Adresa == adresa).List();
                return stareList;
            }
        }

        public List<Stare> GetByNumeAvct(string numeAvct)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Stare> stareList = (List<Stare>)session.QueryOver<Stare>().Where(x => x.Nume_avct == numeAvct).List();
                return stareList;
            }
        }

        public List<Stare> GetByInstanta(Instanta instanta)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Stare> stareList = (List<Stare>)session.QueryOver<Stare>().Where(x => x.Instanta.Id_instanta == instanta.Id_instanta).List();
                return stareList;
            }
        }

        public List<Stare> GetByNumeJudecatorie(string numeJudecatorie)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Stare> stareList = (List<Stare>)session.QueryOver<Stare>().Where(x => x.Nume_jdctr == numeJudecatorie).List();
                return stareList;
            }
        }


        public void Remove(Stare stare)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(stare);
                transaction.Commit();
            }
        }

        public void Update(Stare stare)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(stare);
                transaction.Commit();
            }
        }
    }
}
