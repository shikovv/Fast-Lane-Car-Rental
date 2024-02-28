using CarRental.Data.Domain.Enums;
using System.ComponentModel.DataAnnotations;

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
        public string Make { get; set; }
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
