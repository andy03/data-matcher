using DataMacher.apb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMacher.apb.Repository
{

        public interface IFolderRepository
        {

            void Add(Folder product);

            void Update(Folder product);

            void Remove(Folder product);

            Folder GetById(Guid productId);

            Folder GetByName(string name);
    
            ICollection<Folder> GetByCategory(string category);

        }

}
