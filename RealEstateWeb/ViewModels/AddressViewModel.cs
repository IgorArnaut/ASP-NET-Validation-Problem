using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.ViewModels
{
    public class AddressViewModel
    {
        public required string City { get; set; }
        [Required(ErrorMessage = "Naziv ulice ne sme biti prazan")]
        public required string Street { get; set; }
        [Required(ErrorMessage = "Broj ulice ne sme biti prazan")]
        public int? StreetNum { get; set; }
    }
}
