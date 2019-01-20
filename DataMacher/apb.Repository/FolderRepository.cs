using DataMacher.apb.Data;
using DataMacher.apb.Utils;
using NHibernate;
using System.Collections.Generic;

namespace DataMacher.apb.Repository
{
    public class FolderRepository : IFolderRepository
    {
        private static FolderRepository _folderRepository;

        public static FolderRepository GetFolderRepository
        {
            get
            {
                if (_folderRepository == null)
                {
                    _folderRepository = new FolderRepository();
                }

                return _folderRepository;
            }
        }

        public void Add(Folder folder)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(folder);
                transaction.Commit();
            }
        }

        public void Update(Folder folder)
        {     
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(folder);
                transaction.Commit();
            }
        }

        public void Remove(Folder folder)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(folder);
                transaction.Commit();
            }
        }

        public Folder GetById(int id_dosar)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Folder folder  = session.QueryOver<Folder>().Where(x => x.Id_dosar == id_dosar).SingleOrDefault();
                return folder;
            }
        }
        //return session.Get<Folder>(id_folder);
        //public Folder GetByName(string name)
        //{
        //    using (ISession session = NHibernateHelper.OpenSession())
        //    {
        //        Folder product = session
        //            .CreateCriteria(typeof(Folder))
        //            .Add(Restrictions.Eq("Name", name))
        //            .UniqueResult<Folder>();
        //        return product;
        //    }
        //}

        public List<Folder> GetByCodeValueA(string cod_value_a)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Folder>  folder = (List<Folder>)session.QueryOver<Folder>().Where(x => x.Cod_value_a == cod_value_a).List();
                return folder;
            }
        }

        public List<Folder> GetByCodeValueB(string cod_value_b)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Folder> folder = (List<Folder>)session.QueryOver<Folder>().Where(x => x.Cod_value_b == cod_value_b).List();
                return folder;
            }
        }

        public List<Folder> GetByCodeValueC(string cod_value_c)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Folder> folder = (List<Folder>)session.QueryOver<Folder>().Where(x => x.Cod_value_c == cod_value_c).List();
                return folder;
            }
        }

        public List<Folder> GetByCodeValueD(string cod_value_d)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Folder> folder = (List<Folder>)session.QueryOver<Folder>().Where(x => x.Cod_value_d == cod_value_d).List();
                return folder;
            }
        }

        public List<Folder> GetByCodeValue(string cod_value)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Folder> folder = (List<Folder>)session.QueryOver<Folder>().Where(x => x.Cod_value == cod_value).List();
                return folder;
            }
        }

        public List<Folder> GetByNumeTitular(string nume_titular)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Folder> folder = (List<Folder>)session.QueryOver<Folder>().Where(x => x.Nume_tit_dosar == nume_titular).List();
                return folder;
            }
        }

        public List<Folder> GetByNumeClient(string nume_client)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Folder> folder = (List<Folder>)session.QueryOver<Folder>().Where(x => x.Nume_cl == nume_client).List();
                return folder;
            }
        }

        public List<Folder> GetByInstanta(Instanta intanta)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Folder> folder = (List<Folder>)session.QueryOver<Folder>().Where(x => x.Instanta.Id_instanta == intanta.Id_instanta).List();
                return folder;
            }
        }

        public List<Folder> GetByAct(Act act)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Folder> folder = (List<Folder>)session.QueryOver<Folder>().Where(x => x.Act.Id_act == act.Id_act).List();
                return folder;
            }
        }
    }
}
