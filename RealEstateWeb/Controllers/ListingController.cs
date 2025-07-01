using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstateWeb.Interfaces;
using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Controllers
{
    public class ListingController(
        IAddressRepository addressRepo,
        IBuildingRepository buildingRepo,
        IItemRepository itemRepo,
        IApartmentRepository apartmentRepo,
        ITermsRepository termsRepo,
        IListingRepository listingRepo) : Controller
    {
        private readonly IAddressRepository _addressRepo = addressRepo;
        private readonly IBuildingRepository _buildingRepo = buildingRepo;
        private readonly IItemRepository _itemRepo = itemRepo;
        private readonly IApartmentRepository _apartmentRepo = apartmentRepo;
        private readonly ITermsRepository _termsRepo = termsRepo;
        private readonly IListingRepository _listingRepo = listingRepo;

        // GET: ListingController
        public IActionResult Index()
        {
            IEnumerable<Listing> listings = _listingRepo.FindAll();
            return View(listings);
        }

        public IActionResult Create()
        {
            CreateListingViewModel model = new()
            {
                AllCities = new SelectList(_addressRepo.AllCities()),
                Items = new SelectList(_itemRepo.FindAll(), "Id", "Name")
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            Listing listing = _listingRepo.FindById(id);
            return View(listing);
        }

        [HttpPost]
        public IActionResult Create(CreateListingViewModel model)
        {
            if (ModelState.IsValid)
            {
                Address address = _addressRepo.FindOrCreate(model.Address);
                Building building = _buildingRepo.FindOrCreate(address, model.Building);
                List<Item> items = _itemRepo.FindByIdIn(model.SelectedItemIds);
                Apartment apartment = _apartmentRepo.FindOrCreate(building, items, model.Apartment);
                Terms terms = _termsRepo.FindOrCreate(model.Terms);
                _listingRepo.Create(apartment, terms, model.Listing);
                return RedirectToAction("Index");
            }

            model.AllCities = new SelectList(_addressRepo.AllCities());
            model.Items = new SelectList(_itemRepo.FindAll(), "Id", "Name");
            return View(model);
        }
    }
}
