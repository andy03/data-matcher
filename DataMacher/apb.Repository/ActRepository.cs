using DataMacher.apb.Data;
using DataMacher.apb.Repository.Interface;
using DataMacher.apb.Utils;
using NHibernate;
using System;
using System.Collections.Generic;

namespace DataMacher.apb.Repository
{
    class ActRepository : IActRepository
    {
        private static ActRepository _actRepository;

        public static ActRepository GetActRepository
        {
            get
            {
                if (_actRepository == null)
                {
                    _actRepository = new ActRepository();
                }

                return _actRepository;
            }
        }

        public void Add(Act act)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(act);
                transaction.Commit();
            }
        }

        public Act GetById(int id_act)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Act act = session.QueryOver<Act>().Where(x => x.Id_act == id_act).SingleOrDefault();
                return act;
            }
        }

        public List<Act> GetBySituatie(Situatie situatie)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Act> actList = (List<Act>)session.QueryOver<Act>().Where(x => x.Situatie.Id_situatie == situatie.Id_situatie).List();
                return actList;
            }
        }

        public List<Act> GetByStare(Stare stare)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Act> actList = (List<Act>)session.QueryOver<Act>().Where(x => x.Stare.Id_stare == stare.Id_stare).List();
                return actList;
            }
        }

        public List<Act> GetByTipAct(string tip_act)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Act> actList = (List<Act>)session.QueryOver<Act>().Where(x => x.Tip_act == tip_act).List();
                return actList;
            }
        }

        public void Remove(Act act)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(act);
                transaction.Commit();
            }
        }

        public void Update(Act act)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(act);
                transaction.Commit();
            }
        }
    }
}
