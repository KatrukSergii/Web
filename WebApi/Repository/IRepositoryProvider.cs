using Models;
using Models.Rent;
using Repository.Interfaces;

namespace Repository
{
    public interface IRepositoryProvider
    {
        IRepository<Contact> ContactRepository
        {
            get;
        }

        IRepository<Publication> PublicationRepository
        {
            get;
        }

        IRepository<PublicationRequest> PublicationRequestRepository
        {
            get;
        }

        IRepository<RentalObject> RentalObjectRepositroy
        {
            get;
        }
    }
}
