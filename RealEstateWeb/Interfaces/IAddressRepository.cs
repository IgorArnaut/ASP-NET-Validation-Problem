using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Interfaces
{
    public interface IAddressRepository
    {
        List<string> AllCities();

        Address FindOrCreate(AddressViewModel address);
    }
}
