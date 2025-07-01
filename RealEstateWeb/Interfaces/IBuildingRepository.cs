using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Interfaces
{
    public interface IBuildingRepository
    {
        public Building FindOrCreate(Address address, BuildingViewModel buildingVM);
    }
}
