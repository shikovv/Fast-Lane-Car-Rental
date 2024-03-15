using CarRental.Data.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace CarRental.Models.Car
{
    public class CarViewModel
    {
        public CarViewModel() 
        {
            this.EngineAspirationTypes=Enum.GetValues(typeof(EngineAspirationType)).Cast<EngineAspirationType>().ToHashSet();
            this.BodyTypes = Enum.GetValues(typeof(BodyType)).Cast<BodyType>().ToHashSet();
            this.TransmissionTypes = Enum.GetValues(typeof(TransmissionType)).Cast<TransmissionType>().ToHashSet();
            this.EngineFuelTypes = Enum.GetValues(typeof(EngineFuelType)).Cast<EngineFuelType>().ToHashSet();
            this.EngineStructureTypes = Enum.GetValues(typeof(EngineStructureType)).Cast<EngineStructureType>().ToHashSet();
        }
        [Required]
        [StringLength(25, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z\s]+$",
           ErrorMessage = "The Make field should contain only letters.")]
        public string Make { get; set; }
        public bool IsActive {  get; set; }
        [Required]
        [StringLength(25, MinimumLength = 1)]
        [RegularExpression(@"^[a-zA-Z0-9\s-]+$",
            ErrorMessage = "The Model field should contain only letters, numbers, spaces, and dashes.")]
        public string Model { get; set; }
        [Range(1950, 2024,
           ErrorMessage = "Year must be between 1950 and 2024.")]
        public int YearOfProduction { get; set; }
        [Range(2,16,
            ErrorMessage ="The cylinder number must be between 2 and 16.")]
        public int CylindersNumber { get; set; }
        [Range(500,10000,
            ErrorMessage ="The displacement must be between 500 and 10,000 cubic cantimeters.")]
        public int Displacement { get; set; }
        [Range(0,int.MaxValue,
            ErrorMessage ="The horsepower must be positive number.")]
        public int Horsepower { get; set; }
        [Range(2500, 9500,
            ErrorMessage ="The peak horsepower must be between 2500 and 9500 RPM.")]
        public int PeakHorsepowerAtRPM { get; set; }
        //In Nm
        [Range(0, int.MaxValue,
           ErrorMessage = "The torque must be positive number.")]
        public int Torque { get; set; }
        [Range(1200, 8000,
            ErrorMessage ="The peak torque must be between 1200 and 8000 RPM.")]
        public int PeakTorqueAtRPM { get; set; }
        //In Seconds
        [Range(0, int.MaxValue,
           ErrorMessage = "The acceleration must be positive number.")]
        public double AccelerationTo100 { get; set; }
        //In Km/h
        [Range(0, int.MaxValue,
           ErrorMessage = "The top speed must be positive number.")]
        public int TopSpeed { get; set; }
        //In Km
        [Range(0, int.MaxValue,
           ErrorMessage = "The mileage must be positive number.")]
        public int Mileage { get; set; }
        //In Litres
        [Range(0, int.MaxValue,
           ErrorMessage = "The consumption must be positive number.")]
        public double ConsumptionPer100Km { get; set; }
        [Range(1, 10,
            ErrorMessage ="The safety rating must be between 1 and 10.")]
        public double SafetyRating { get; set; }
        [Range(2, 9,
            ErrorMessage ="Cars must have between 2 and 9 seats.")]
        public int Seats { get; set; }
        //In Bgn
        [Range(35, 5000,
            ErrorMessage ="The price must be between 35lv. and 5000lv. per day.")]
        public double PricePerDay { get; set; }
        [Required]
        public string ImageURL { get; set; }
        public EngineAspirationType SelectedEngineAspirationType { get; set; }
        public BodyType SelectedBodyType { get; set; }
        public TransmissionType SelectedTransmissionType { get; set; }
        public EngineFuelType SelectedFuelType { get; set; }
        public EngineStructureType SelectedEngineStructureType { get; set; }


        public IEnumerable<EngineAspirationType> EngineAspirationTypes { get; set; }
        public IEnumerable<BodyType> BodyTypes { get; set; }
        public IEnumerable<TransmissionType> TransmissionTypes { get; set; }
        public IEnumerable<EngineFuelType> EngineFuelTypes { get; set; }
        public IEnumerable<EngineStructureType> EngineStructureTypes { get; set; }
    }
}
