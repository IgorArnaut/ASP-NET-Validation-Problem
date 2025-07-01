using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Interfaces
{
    public interface IListingRepository
    {
        IEnumerable<Listing> FindAll();

        Listing FindById(int id);

        void Create(Apartment apartment, Terms terms, ListingViewModel listingModel);
    }
}
