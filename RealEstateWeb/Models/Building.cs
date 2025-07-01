using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.Models
{
    public class Building
    {
        [Key]
        public long Id { get; set; }
        public int YearConstrcuted { get; set; }
        public int NumOfFloors { get; set; }
        public bool Parking { get; set; }
        public bool Garage { get; set; }
        public bool Elevator { get; set; }
        public bool Cctv { get; set; }
        public bool Intercom { get; set; }

        public required Address Address { get; set; }

        public List<Apartment> Apartments { get; } = [];
    }
}
