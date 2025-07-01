using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.Models
{
    public class Item
    {
        [Key]
        public long Id { get; set; }
        public required string Name { get; set; }

        public List<Apartment> Apartments { get; set; } = [];
    }
}
