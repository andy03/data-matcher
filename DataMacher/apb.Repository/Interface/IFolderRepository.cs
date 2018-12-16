using DataMacher.apb.Data;
using System.Collections.Generic;


namespace DataMacher.apb.Repository
{

    public interface IFolderRepository
    {

        void Add(Folder folder);

        void Update(Folder folder);

        void Remove(Folder folder);

        Folder GetById(int id_folder);

        List<Folder> GetByCodeValueA(string cod_value_a);

        List<Folder> GetByCodeValueB(string cod_value_b);

        List<Folder> GetByCodeValueC(string cod_value_c);

        List<Folder> GetByCodeValueD(string cod_value_d);

        List<Folder> GetByCodeValue(string cod_value);

        List<Folder> GetByNumeTitular(string nume_titular);

        List<Folder> GetByNumeClient(string nume_cliet);

        List<Folder> GetByInstanta(Instanta intanta);

        List<Folder> GetByAct(Act act);

        
    }
    //ICollection<Folder> GetByCategory(string category);
}
