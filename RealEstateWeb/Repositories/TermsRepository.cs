using RealEstateWeb.Data;
using RealEstateWeb.Interfaces;
using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Repositories
{
    public class TermsRepository(ApplicationDbContext context) : ITermsRepository
    {
        private readonly ApplicationDbContext _context = context;

        public Terms FindOrCreate(TermsViewModel termsModel)
        {
            var terms = _context.Terms.Where(t =>
                t.DateAvailable == termsModel.DateAvailable &&
                t.Deposit == termsModel.Deposit &&
                t.ForStudents == termsModel.ForStudents &&
                t.ForWorkers == termsModel.ForWorkers &&
                t.SmokingAllowed == termsModel.SmokingAllowed &&
                t.PetsAllowed == termsModel.PetsAllowed
            ).FirstOrDefault() ?? new Terms()
            {
                DateAvailable = termsModel.DateAvailable,
                Deposit = termsModel.Deposit,
                ForStudents = termsModel.ForStudents,
                ForWorkers = termsModel.ForWorkers,
                SmokingAllowed = termsModel.SmokingAllowed,
                PetsAllowed = termsModel.PetsAllowed
            };

            _context.Terms.Add(terms);
            var saved = _context.SaveChanges();
            return terms;
        }
    }
}
