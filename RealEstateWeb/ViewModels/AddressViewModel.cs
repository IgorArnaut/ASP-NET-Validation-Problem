using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.ViewModels
{
    public class AddressViewModel
    {
        public required string City { get; set; }
        [Required(ErrorMessage = "Naziv ulice ne sme biti prazan")]
        public required string Street { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Broj ulice mora biti pozitivan")]
        [Required(ErrorMessage = "Broj ulice ne sme biti prazan")]
        public int StreetNum { get; set; }
    }
}
