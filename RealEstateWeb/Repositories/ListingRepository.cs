using Microsoft.EntityFrameworkCore;
using RealEstateWeb.Data;
using RealEstateWeb.Interfaces;
using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Repositories
{
    public class ListingRepository(ApplicationDbContext context) : IListingRepository
    {
        private readonly ApplicationDbContext _context = context;

        public IEnumerable<Listing> FindAll()
        {
            return [.. _context.Listings.Include(l => l.Apartment)];
        }

        public Listing FindById(int id)
        {
            return _context.Listings
                .Include(l => l.Apartment)
                .ThenInclude(a => a.Building)
                .Include(l => l.Apartment)
                .ThenInclude(a => a.Items)
                .Include(l => l.Terms)
                .First(l => l.Id == id);
        }

        public void Create(Apartment apartment, Terms terms, ListingViewModel listingModel)
        {
            var listing = new Listing()
            {
                Title = listingModel.Title,
                Description = listingModel.Description,
                ApartmentId = apartment.Id,
                TermsId = terms.Id
            };
            _context.Listings.Add(listing);
            _ = _context.SaveChanges();
        }

    }
}
