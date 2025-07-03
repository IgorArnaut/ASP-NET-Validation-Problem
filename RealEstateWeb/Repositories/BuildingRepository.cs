using RealEstateWeb.Data;
using RealEstateWeb.Interfaces;
using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Repositories
{
    public class BuildingRepository(ApplicationDbContext context) : IBuildingRepository
    {
        private readonly ApplicationDbContext _context = context;

        public Building FindOrCreate(Address address, BuildingViewModel buildingVM)
        {
            var building = _context.Buildings.FirstOrDefault(b => b.Address == address)
            ?? new Building()
            {
                Address = address,
                YearConstrcuted = buildingVM.YearConstructed,
                NumOfFloors = buildingVM.NumOfFloors,
                Elevator = buildingVM.Elevator,
                Parking = buildingVM.Parking,
                Garage = buildingVM.Garage,
                Cctv = buildingVM.Cctv,
                Intercom = buildingVM.Intercom
            };
            _context.Buildings.Add(building);
            var saved = _context.SaveChanges();
            return building;
        }
    }
}
