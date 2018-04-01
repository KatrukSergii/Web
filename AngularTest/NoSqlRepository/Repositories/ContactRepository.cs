using System.Collections.Generic;
using Models;
using Repository.Interfaces;

namespace NoSqlRepository.Repositories
{
    public class ContactRepository : IRepository<Contact>
    {
        public int Count => throw new System.NotImplementedException();

        public void Add(Contact itemToAdd)
        {
            throw new System.NotImplementedException();
        }

        public List<Contact> Get(int from, int to)
        {
            return new List<Contact>
            {
                new Contact { FirstName = "First1", LastName = "Last1" },
                new Contact { FirstName = "First2", LastName = "Last3" },
                new Contact { FirstName = "First3", LastName = "Last3" }
            };
        }

        public Contact GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Contact itemToInsert)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Contact itemToRemove)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Contact itemToSave)
        {
            throw new System.NotImplementedException();
        }
    }
}
