using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.Models
{
    public class Listing
    {
        [Key]
        public long Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public long TermsId { get; set; }
        public Terms Terms { get; set; }

        public long ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
