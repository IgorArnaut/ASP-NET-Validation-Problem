using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.Models
{
    public class Terms
    {
        [Key]
        public long Id { get; set; }
        public DateOnly DateAvailable { get; set; }
        public bool Deposit { get; set; }
        public bool ForStudents { get; set; }
        public bool ForWorkers { get; set; }
        public bool SmokingAllowed { get; set; }
        public bool PetsAllowed { get; set; }

        public List<Listing> Listings { get; } = [];
    }
}
