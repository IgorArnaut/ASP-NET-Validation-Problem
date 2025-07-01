using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.ViewModels
{
    public class ApartmentViewModel
    {
        [Range(0, int.MaxValue, ErrorMessage = "Sprat mora biti bar 0")]
        public int Floor { get; set; }
        [Range(10, int.MaxValue, ErrorMessage = "Površina mora biti bar 10 m2")]
        public int Area { get; set; }
        [Range(100, int.MaxValue, ErrorMessage = "Cena mora biti bar 100 EUR")]
        public int Price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Broj soba mora biti bar 0")]
        public int NumOfRooms { get; set; }
        public required string State { get; set; }
        public required string Heating { get; set; }
        public required string Equipment { get; set; }
    }
}
