using DataMacher.apb.Data;
using DataMacher.apb.Utils;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

namespace DataMacher.apb.Repository
{
    public class FolderRepository : IFolderRepository

    {

        public void Add(Folder product)

        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(product);
                transaction.Commit();
            }

        }



        public void Update(Folder product)

        {

            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(product);
                transaction.Commit();
            }

        }



        public void Remove(Folder product)

        {

            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(product);
                transaction.Commit();
            }

        }



        public Folder GetById(Guid productId)

        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Folder>(productId);

        }



        public Folder GetByName(string name)

        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Folder product = session
                    .CreateCriteria(typeof(Folder))
                    .Add(Restrictions.Eq("Name", name))
                    .UniqueResult<Folder>();
                return product;
            }

        }



        public ICollection<Folder> GetByCategory(string category)

        {

            throw new NotImplementedException();

        }

    }
}
