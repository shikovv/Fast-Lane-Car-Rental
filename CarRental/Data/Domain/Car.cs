using CarRental.Data.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Data.Domain
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }
        public BodyType BodyType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public TransmissionType TransmissionType { get; set; }
        [Range(1920,2024)]
        public int YearOfProduction { get; set; }
        public EngineFuelType EngineFuelType { get; set; }
        public EngineStructureType EngineStructureType { get; set; }
        public EngineAspirationType EngineAspirationType { get; set; }
        [Range(3,16)]
        public int CylindersNumber { get; set; }
        //In Cubic Centimetres
        [Range(600,9000)]
        public int Displacement { get; set; }
        public int Horsepower { get; set; }
        [Range(2500,9500)]
        public int PeakHorsepowerAtRPM { get; set; }
        //In Nm
        public int Torque { get; set; }
        [Range(1200,8000)]
        public int PeakTorqueAtRPM { get; set; }
        //In Seconds
        public double AccelerationTo100 { get; set; }
        //In Km/h
        public int TopSpeed { get; set; }
        //In Km
        public int Mileage { get; set; }
        //In Litres
        public double ConsumptionPer100Km { get; set; }
        [Range(1,10)]
        public double SafetyRating { get; set; }
        [Range(2,9)]
        public int Seats { get; set; }
        //In Bgn
        [Range(35,5000)]
        public double PricePerDay { get; set; }
        public string ImageURL { get; set; }
    }
}
