using System.Collections.Generic;
using DataMacher.apb.Data;
using DataMacher.apb.Repository;
using DataMacher.apb.Service.Interface;

namespace DataMacher.apb.Service
{
    class FolderService : IFolderService
    {

        private static FolderService _folderService;

        public static FolderService GetFolderService
        {
            get
            {
                if (_folderService == null)
                {
                    _folderService = new FolderService();
                }

                return _folderService;
            }
        }
        public void Add(Folder folder)
        {
            FolderRepository.GetFolderRepository.Add(folder);
        }

        public List<Folder> GetByAct(Act act)
        {
           return FolderRepository.GetFolderRepository.GetByAct(act);
        }

        public List<Folder> GetByCodeValue(string cod_value)
        {
            return FolderRepository.GetFolderRepository.GetByCodeValue(cod_value);
        }

        public List<Folder> GetByCodeValueA(string cod_value_a)
        {
            return FolderRepository.GetFolderRepository.GetByCodeValueA(cod_value_a);
        }

        public List<Folder> GetByCodeValueB(string cod_value_b)
        {
            return FolderRepository.GetFolderRepository.GetByCodeValueB(cod_value_b);
        }

        public List<Folder> GetByCodeValueC(string cod_value_c)
        {
            return FolderRepository.GetFolderRepository.GetByCodeValueC(cod_value_c);
        }

        public List<Folder> GetByCodeValueD(string cod_value_d)
        {
            return FolderRepository.GetFolderRepository.GetByCodeValueD(cod_value_d);
        }

        public Folder GetById(int id_folder)
        {
            return FolderRepository.GetFolderRepository.GetById(id_folder);
        }

        public List<Folder> GetByInstanta(Instanta intanta)
        {
            return FolderRepository.GetFolderRepository.GetByInstanta(intanta);
        }

        public List<Folder> GetByNumeClient(string nume_cliet)
        {
            return FolderRepository.GetFolderRepository.GetByNumeClient(nume_cliet);
        }

        public List<Folder> GetByNumeTitular(string nume_titular)
        {
            return FolderRepository.GetFolderRepository.GetByNumeTitular(nume_titular);
        }

        public void Remove(Folder folder)
        {
            FolderRepository.GetFolderRepository.Remove(folder);
        }

        public void Update(Folder folder)
        {
            FolderRepository.GetFolderRepository.Update(folder);
        }
    }
}
