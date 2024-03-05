using CarRental.Data.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace CarRental.Models.Car
{
    public class CarFormModel
    {
        public CarFormModel() 
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
        [Required]
        [StringLength(25, MinimumLength = 1)]
        [RegularExpression(@"^[a-zA-Z0-9\s-]+$",
            ErrorMessage = "The Model field should contain only letters, numbers, spaces, and dashes.")]
        public string Model { get; set; }
        [Range(1950, 2024,
           ErrorMessage = "Year must be between 1950 and 2024.")]
        public int YearOfProduction { get; set; }

        public int CylindersNumber { get; set; }
        public int Displacement { get; set; }
        public int Horsepower { get; set; }
        [Range(2500, 9500)]
        public int PeakHorsepowerAtRPM { get; set; }
        //In Nm
        public int Torque { get; set; }
        [Range(1200, 8000)]
        public int PeakTorqueAtRPM { get; set; }
        //In Seconds
        public double AccelerationTo100 { get; set; }
        //In Km/h
        public int TopSpeed { get; set; }
        //In Km
        public int Mileage { get; set; }
        //In Litres
        public double ConsumptionPer100Km { get; set; }
        [Range(1, 10)]
        public double SafetyRating { get; set; }
        [Range(2, 9)]
        public int Seats { get; set; }
        //In Bgn
        [Range(35, 5000)]
        public double PricePerDay { get; set; }
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
