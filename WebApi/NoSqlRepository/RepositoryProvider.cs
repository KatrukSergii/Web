using Models;
using Models.Rent;
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

        public IRepository<Publication> PublicationRepository => new PublicationRepository();

        public IRepository<PublicationRequest> PublicationRequestRepository => new PublicationRequestRepository();

        public IRepository<RentalObject> RentalObjectRepositroy => new RentalObjectRepositroy();
    }
}
