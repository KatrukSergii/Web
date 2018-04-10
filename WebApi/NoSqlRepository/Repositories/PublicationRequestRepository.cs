using System.Collections.Generic;
using System.Linq;
using Models;
using Models.Rent;
using Repository.Interfaces;

namespace NoSqlRepository.Repositories
{
    internal class PublicationRequestRepository : IRepository<PublicationRequest>
    {
        public List<PublicationRequest> requestCache = new List<PublicationRequest>
        {
            new PublicationRequest{ Id = 1, ContactEmail = "test1@test.com", ContactPhone = "00000001", IsApproved = true },
            new PublicationRequest{ Id = 2, ContactEmail = "test2@test.com", ContactPhone = "00000002", IsApproved = false }
        };

        public int Count => this.requestCache.Count;

        public void Add(PublicationRequest itemToAdd)
        {
            this.requestCache.Add(itemToAdd);
        }

        public List<PublicationRequest> Get(int from, int to)
        {
            return this.requestCache;
        }

        public PublicationRequest GetById(int id)
        {
            return this.requestCache.FirstOrDefault(item => item.Id == id);
        }

        public void Insert(PublicationRequest itemToInsert)
        {
            itemToInsert.Id = this.requestCache.Max(requset => requset.Id);
            this.requestCache.Add(itemToInsert);
        }

        public void Remove(int id)
        {
            this.requestCache.Remove(this.requestCache.FirstOrDefault(item => item.Id == id));
        }

        public void Remove(PublicationRequest itemToRemove)
        {
            throw new System.NotImplementedException();
        }

        public void Save(PublicationRequest itemToSave)
        {
            throw new System.NotImplementedException();
        }
    }
}