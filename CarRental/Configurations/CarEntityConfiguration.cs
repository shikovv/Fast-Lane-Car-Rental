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

            cars.Add(new Car()
            {
                Id = Guid.Parse("1201c5ee-8aa7-4400-9009-7bfc91fa4815"),
                Make = "Mercedes",
                Model = "190E",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                AccelerationTo100 = 8.7,
                Mileage = 460000,
                Horsepower = 122,
                TopSpeed = 230,
                YearOfProduction = 1991,
                ConsumptionPer100Km = 8.7,
                ImageURL = "https://i.pinimg.com/736x/bd/f1/67/bdf167075cbba99b9eeed9393ba24d65.jpg",
                EngineFuelType = EngineFuelType.Gasoline,
                PricePerDay = 239,
                SafetyRating = 9.1,
                Seats = 5,
                EngineStructureType = EngineStructureType.Inline,
                CylindersNumber = 4,
                EngineAspirationType = EngineAspirationType.NaturallyAspirated,
                Displacement = 2000,
                PeakHorsepowerAtRPM = 5300,
                Torque = 178,
                PeakTorqueAtRPM = 3500
            });

            cars.Add(new Car()
            {
                Id = Guid.Parse("1167ef05-3aaf-4ab8-8032-59d4d6bc2075"),
                Make = "Volkswagen",
                Model = "Passat B7",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                AccelerationTo100 = 9.8,
                Mileage = 120000,
                Horsepower = 140,
                TopSpeed = 211,
                YearOfProduction = 2014,
                ConsumptionPer100Km = 7.5,
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG/1280px-VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG",
                EngineFuelType = EngineFuelType.Diesel,
                PricePerDay = 99,
                SafetyRating = 7.2,
                Seats = 5,
                EngineStructureType = EngineStructureType.Inline,
                CylindersNumber = 4,
                EngineAspirationType = EngineAspirationType.TurboCharged,
                Displacement = 2000,
                PeakHorsepowerAtRPM = 4200,
                Torque = 320,
                PeakTorqueAtRPM = 2500
            });
            return cars;
        }
    }
}
