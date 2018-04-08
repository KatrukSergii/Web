using Models;
using Repository.Interfaces;

namespace Repository
{
    public interface IRepositoryProvider
    {
        IRepository<Contact> ContactRepository
        {
            get;
        }
    }
}
