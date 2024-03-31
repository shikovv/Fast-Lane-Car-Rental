using CarRental.Data.Domain.Enums;
using CarRental.Data.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Configurations
{
    public class CarEntityConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {

            builder
                .Property(c => c.IsActive)
                .HasDefaultValue(true);

            builder.HasData(this.GenerateCars());
        }

        private ICollection<Car> GenerateCars()
        {
            var cars = new HashSet<Car>();

            cars.Add(new Car()
            {
                Id = Guid.Parse("a6e93473-1479-442f-a73a-96a5f4f94b2f"),
                Make = "Ford",
                Model = "Fiesta MK5",
                BodyType = BodyType.Hatchback,
                TransmissionType = TransmissionType.Manual,
                AccelerationTo100 = 14.1,
                Mileage = 260000,
                Horsepower = 70,
                TopSpeed = 180,
                YearOfProduction = 2004,
                ConsumptionPer100Km = 6.3,
                ImageURL = "https://parkers-images.bauersecure.com/wp-images/2148/cut-out/930x620/st05.jpg",
                EngineFuelType = EngineFuelType.Gasoline,
                PricePerDay = 59,
                SafetyRating = 5.9,
                Seats = 5,
                EngineStructureType=EngineStructureType.Inline,
                CylindersNumber=4,
                EngineAspirationType=EngineAspirationType.NaturallyAspirated,
                Displacement=1300,
                PeakHorsepowerAtRPM=5000,
                Torque=106,
                PeakTorqueAtRPM=2800
            });
            return cars;
        }
    }
}
