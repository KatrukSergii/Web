using Models;
using NoSqlRepository.Repositories;
using Repository;
using Repository.Interfaces;

namespace NoSqlRepository
{
    public class RepositoryProvider : IRepositoryProvider
    {
        IRepository<Contact> contactRepository;

        public IRepository<Contact> ContactRepository => 
            this.contactRepository ?? (this.contactRepository = new ContactRepository());
    }
}
