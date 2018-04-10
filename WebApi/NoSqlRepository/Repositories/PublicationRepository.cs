using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using Models.Rent;
using Repository.Interfaces;

namespace NoSqlRepository.Repositories
{
    internal class PublicationRepository : IRepository<Publication>
    {
        private List<Publication> publicationsCache = new List<Publication>
            {
                new Publication{ Id = 1, FromDate = new DateTime(2018, 1, 1), RentalObjectId = 1, ToDate = new DateTime(2018, 12, 31) },
                new Publication{ Id = 2, FromDate = new DateTime(2019, 1, 1), RentalObjectId = 2},
                new Publication{ Id = 3, FromDate = new DateTime(2020, 1, 1), RentalObjectId = 3},
            };

        public int Count => this.publicationsCache.Count;

        public void Add(Publication itemToAdd)
        {
            this.publicationsCache.Add(itemToAdd);
        }

        public List<Publication> Get(int from, int to)
        {
            return this.publicationsCache;
        }

        public Publication GetById(int id)
        {
            return this.publicationsCache.FirstOrDefault(item => item.Id == id);
        }

        public void Insert(Publication itemToInsert)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            this.publicationsCache.Remove(this.publicationsCache.FirstOrDefault(item => item.Id == id));
        }

        public void Remove(Publication itemToRemove)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Publication itemToSave)
        {
            throw new System.NotImplementedException();
        }
    }
}