using System.Collections.Generic;
using Models;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
        int Count
        {
            get;
        }

        List<T> Get(int from, int to);

        T GetById(string id);

        void Insert(T itemToInsert);

        void Remove(string id);

        void Remove(T itemToRemove);

        void Save(T itemToSave);

        void Add(Contact itemToAdd);
    }
}
