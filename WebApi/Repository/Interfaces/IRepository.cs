using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
        int Count
        {
            get;
        }

        List<T> Get(int from, int to);

        T GetById(int id);

        void Insert(T itemToInsert);

        void Remove(int id);

        void Remove(T itemToRemove);

        void Save(T itemToSave);

        void Add(T itemToAdd);
    }
}
