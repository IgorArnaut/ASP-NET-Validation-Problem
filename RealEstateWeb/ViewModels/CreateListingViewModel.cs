using Microsoft.AspNetCore.Mvc.Rendering;

namespace RealEstateWeb.ViewModels
{
    public class CreateListingViewModel
    {
        public IEnumerable<SelectListItem> AllCities { get; set; }
        public AddressViewModel Address { get; set; }
        public BuildingViewModel Building { get; set; }
        public ApartmentViewModel Apartment { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; }
        public IEnumerable<long> SelectedItemIds { get; set; }
        public TermsViewModel Terms { get; set; }
        public ListingViewModel Listing { get; set; }
    }
}
