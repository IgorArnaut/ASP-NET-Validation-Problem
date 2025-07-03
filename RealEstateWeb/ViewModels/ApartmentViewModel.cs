using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.ViewModels
{
    public class ApartmentViewModel
    {
        [Range(0, int.MaxValue, ErrorMessage = "Sprat mora biti bar 0")]
        [Required(ErrorMessage = "Sprat ne sme biti prazan")]
        public int Floor { get; set; }
        [Range(10, int.MaxValue, ErrorMessage = "Površina mora biti bar 10 m2")]
        [Required(ErrorMessage = "Površina ne sme biti prazna")]
        public int Area { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Broj soba mora biti bar 0")]
        [Required(ErrorMessage = "Broj soba ne sme biti prazan")]
        public int NumOfRooms { get; set; }
        [Range(100, int.MaxValue, ErrorMessage = "Cena mora biti bar 100 EUR")]
        [Required(ErrorMessage = "Cena ne sme biti prazna")]
        public int Price { get; set; }
        public required string State { get; set; }
        public required string Heating { get; set; }
        public required string Equipment { get; set; }
    }
}
