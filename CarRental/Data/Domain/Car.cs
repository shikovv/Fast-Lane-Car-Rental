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
        public int Year { get; set; }
        public EngineType EngineFuelType { get; set; }
        public int Displacement { get; set; }
        public int Horsepower { get; set; }
        public int PeakHorsepowerAtRPM { get; set; }
        public int Torque { get; set; }
        public int PeakTorqueAtRPM { get; set; }
        public double AccelerationTo100 { get; set; }
        public int TopSpeed { get; set; }
        public int Mileage { get; set; }
        public double ConsumptionPer100Km { get; set; }
        public double SafetyRating { get; set; }
        public int Seats { get; set; }
        public double PricePerDay { get; set; }
        public string ImageURL { get; set; }
    }
}
