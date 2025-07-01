using RealEstateWeb.Data;
using RealEstateWeb.Interfaces;
using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Repositories
{
    public class AddressRepository(ApplicationDbContext context) : IAddressRepository
    {
        private readonly ApplicationDbContext _context = context;

        public List<string> AllCities()
        {
            return [
                "Beograd",
                "Bor",
                "Valjevo",
                "Vranje",
                "Vršac",
                "Zaječar",
                "Zrenjanin",
                "Jagodina",
                "Kikinda",
                "Kragujevac",
                "Kraljevo",
                "Kruševac",
                "Leskovac",
                "Loznica",
                "Niš",
                "Novi Pazar",
                "Novi Sad",
                "Pančevo",
                "Pirot",
                "Požarevac",
                "Priština",
                "Prokuplje",
                "Smederevo",
                "Sombor",
                "Sremska Mitrovica",
                "Subotica",
                "Užice",
                "Čačak",
                "Šabac"];
        }

        public Address FindOrCreate(AddressViewModel addressVM)
        {
            Address address = _context.Addresses.FirstOrDefault(a =>
                a.City == addressVM.City &&
                a.Street == addressVM.Street &&
                a.StreetNum == addressVM.StreetNum
            ) ?? new Address
            {
                City = addressVM.City,
                Street = addressVM.Street,
                StreetNum = addressVM.StreetNum
            };
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return address;
        }
    }
}
