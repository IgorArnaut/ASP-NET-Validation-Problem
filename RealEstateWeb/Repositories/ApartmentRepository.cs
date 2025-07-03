using RealEstateWeb.Data;
using RealEstateWeb.Interfaces;
using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Repositories
{
    public class ApartmentRepository(ApplicationDbContext context) : IApartmentRepository
    {
        private readonly ApplicationDbContext _context = context;

        public Apartment FindOrCreate(Building building, List<Item> items, ApartmentViewModel apartmentModel)
        {
            var apartment = _context.Apartments.Where(a =>
                a.Floor == apartmentModel.Floor &&
                a.Area == apartmentModel.Area &&
                a.NumOfRooms == apartmentModel.NumOfRooms &&
                a.Price == apartmentModel.Price &&
                a.State == apartmentModel.State &&
                a.Heating == apartmentModel.Heating &&
                a.Equipment == apartmentModel.Equipment &&
                a.BuildingId == building.Id
            ).FirstOrDefault() ?? new Apartment()
            {
                Floor = apartmentModel.Floor,
                Area = apartmentModel.Area,
                NumOfRooms = apartmentModel.NumOfRooms,
                Price = apartmentModel.Price,
                State = apartmentModel.State,
                Heating = apartmentModel.Heating,
                Equipment = apartmentModel.Equipment,
                BuildingId = building.Id
            };
            _context.Apartments.Add(apartment);
            var saved = _context.SaveChanges();
            return apartment;
        }
    }
}
