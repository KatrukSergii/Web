using System.Collections.Generic;
using System.Linq;
using Models;
using Models.Rent;
using Repository.Interfaces;

namespace NoSqlRepository.Repositories
{
    internal class RentalObjectRepositroy : IRepository<RentalObject>
    {
		private List<RentalObject> objectCache = new List<RentalObject>
			{
				new RentalObject{Id = 0, Code = "000", Area = 000},
				new RentalObject{Id = 1, Code = "001", Area = 111},
				new RentalObject{Id = 2, Code = "002", Area = 222},
				new RentalObject{Id = 3, Code = "003", Area = 333}
			};

		public int Count => this.objectCache.Count;

        public void Add(RentalObject itemToAdd)
        {
            this.objectCache.Add(itemToAdd);
        }

        public List<RentalObject> Get(int from, int to)
        {
            return this.objectCache;
        }

        public RentalObject GetById(int id)
        {
            return this.objectCache.FirstOrDefault(obj => obj.Id == id);
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