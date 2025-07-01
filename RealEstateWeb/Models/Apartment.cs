using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.Models
{
    public class Apartment
    {
        [Key]
        public long Id { get; set; }
        public int Floor { get; set; }
        public int Area { get; set; }
        public int Price { get; set; }
        public int NumOfRooms { get; set; }
        public required string State { get; set; }
        public required string Heating { get; set; }
        public required string Equipment { get; set; }

        public long BuildingId { get; set; }
        public Building Building { get; set; }

        public List<Listing> Listings { get; } = [];

        public List<Item> Items { get; set; } = [];

    }
}
