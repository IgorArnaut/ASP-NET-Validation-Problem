using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.Models
{
    public class Address
    {
        [Key]
        public long Id { get; set; }
        public required string City { get; set; }
        public required string Street { get; set; }
        public int StreetNum { get; set; }

        public long BuildingId { get; set; }
        public Building Building { get; set; }
    }
}
