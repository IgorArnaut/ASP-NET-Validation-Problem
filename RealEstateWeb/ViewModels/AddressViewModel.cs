using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.ViewModels
{
    public class AddressViewModel
    {
        public required string City { get; set; }
        [Required(ErrorMessage = "Naziv ulice ne sme biti prazan")]
        public required string Street { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Broj ulice mora biti bar 1")]
        public required int StreetNum { get; set; }
    }
}
