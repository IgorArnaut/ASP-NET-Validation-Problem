using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.ViewModels
{
    public class ListingViewModel
    {
        [Required(ErrorMessage = "Naslov oglasa ne sme biti prazan")]
        public required string Title { get; set; }
        [Required(ErrorMessage = "Opis oglasa ne sme biti prazan")]
        public required string Description { get; set; }
    }
}
