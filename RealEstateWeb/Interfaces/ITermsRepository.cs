using RealEstateWeb.Models;
using RealEstateWeb.ViewModels;

namespace RealEstateWeb.Interfaces
{
    public interface ITermsRepository
    {
        Terms FindOrCreate(TermsViewModel termsModel);
    }
}
