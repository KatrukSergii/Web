using System.Collections.Generic;
using Models;
using Models.Rent;
using Repository.Interfaces;

namespace NoSqlRepository.Repositories
{
    internal class RentalObjectRepositroy : IRepository<RentalObject>
    {
        public int Count => throw new System.NotImplementedException();

        public void Add(RentalObject itemToAdd)
        {
            throw new System.NotImplementedException();
        }

        public List<RentalObject> Get(int from, int to)
        {
            return new List<RentalObject>
            {
                new RentalObject{Id = 1, Code = "001", Area = 111},
                new RentalObject{Id = 2, Code = "002", Area = 222},
                new RentalObject{Id = 3, Code = "003", Area = 333}
            };
        }

        public RentalObject GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(RentalObject itemToInsert)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(RentalObject itemToRemove)
        {
            throw new System.NotImplementedException();
        }

        public void Save(RentalObject itemToSave)
        {
            throw new System.NotImplementedException();
        }
    }
}