using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.ViewModels
{
    public class TermsViewModel
    {
        [Required(ErrorMessage = "Izaberite datum useljenja")]
        public DateOnly DateAvailable { get; set; }
        public bool Deposit { get; set; }
        public bool ForStudents { get; set; }
        public bool ForWorkers { get; set; }
        public bool SmokingAllowed { get; set; }
        public bool PetsAllowed { get; set; }
    }
}
