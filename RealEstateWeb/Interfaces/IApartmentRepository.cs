using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Interfaces
{
    public interface IApartmentRepository
    {
        Apartment FindOrCreate(Building building, List<Item> items, ApartmentViewModel apartmentModel);
    }
}
