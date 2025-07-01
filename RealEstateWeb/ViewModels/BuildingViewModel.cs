using System.ComponentModel.DataAnnotations;

namespace RealEstateWeb.ViewModels
{
    public class BuildingViewModel
    {
        [Range(1900, int.MaxValue, ErrorMessage = "Godina izgradnje mora biti bar 1900")]
        public int YearConstructed { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Broj stanova mora biti bar 1")]
        public int NumOfFloors { get; set; }
        public bool Parking { get; set; }
        public bool Garage { get; set; }
        public bool Elevator { get; set; }
        public bool Cctv { get; set; }
        public bool Intercom { get; set; }
    }
}
