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
                Id = Guid.Parse("bdf5c65f-4470-4139-8ec3-8c3baf0e34d6"),
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
                EngineAspirationType=EngineAspirationType.Atmospheric,
                Displacement=1300,
                PeakHorsepowerAtRPM=5000,
                Torque=106,
                PeakTorqueAtRPM=2800
            });

            cars.Add(new Car()
            {
                Id = Guid.Parse("1201c5ee-8aa7-4400-9009-7bfc91fa4817"),
                Make = "Mercedes",
                Model = "190E EVO 2",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Manual,
                AccelerationTo100 = 4.7,
                Mileage = 41000,
                Horsepower = 235,
                TopSpeed = 298,
                YearOfProduction = 1991,
                ConsumptionPer100Km = 12.7,
                ImageURL = "https://autobild.bg/wp-content/uploads/2021/08/Mercedes-190-E-2.5-16-Evo-II-7.jpg",
                EngineFuelType = EngineFuelType.Gasoline,
                PricePerDay = 2239.99,
                SafetyRating = 9.3,
                Seats = 4,
                EngineStructureType = EngineStructureType.Inline,
                CylindersNumber = 4,
                EngineAspirationType = EngineAspirationType.Atmospheric,
                Displacement = 2500,
                PeakHorsepowerAtRPM = 7200,
                Torque = 245,
                PeakTorqueAtRPM = 5000
            });

            cars.Add(new Car()
            {
                Id = Guid.Parse("1167ef05-3aaf-4ab8-8032-59d4d6bc2076"),
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
                EngineAspirationType = EngineAspirationType.Turbocharger,
                Displacement = 2000,
                PeakHorsepowerAtRPM = 4200,
                Torque = 320,
                PeakTorqueAtRPM = 2500
            });

            cars.Add(new Car()
            {
                Id = Guid.Parse("972f5bfe-0147-48ba-9fa3-a869604e8eb7"),
                Make = "Renault",
                Model = "Megane Coach",
                BodyType = BodyType.Coupe,
                TransmissionType = TransmissionType.Manual,
                AccelerationTo100 = 6.8,
                Mileage = 340000,
                Horsepower = 150,
                TopSpeed = 243,
                YearOfProduction = 1999,
                ConsumptionPer100Km = 7.6,
                ImageURL = "https://i0.shbdn.com/photos/52/19/80/x5_1163521980bds.jpg",
                EngineFuelType = EngineFuelType.Gasoline,
                PricePerDay = 199.99,
                SafetyRating = 7.7,
                Seats = 4,
                EngineStructureType = EngineStructureType.Inline,
                CylindersNumber = 4,
                EngineAspirationType = EngineAspirationType.Atmospheric,
                Displacement = 2000,
                PeakHorsepowerAtRPM = 6200,
                Torque = 190,
                PeakTorqueAtRPM = 4200
            });

            cars.Add(new Car()
            {
                Id = Guid.Parse("106b584f-2fc0-45ef-985f-ce520e719b3b"),
                Make = "Mercedes",
                Model = "G55 AMG",
                BodyType = BodyType.Offroad,
                TransmissionType = TransmissionType.Automatic,
                AccelerationTo100 = 5.5,
                Mileage = 210000,
                Horsepower = 507,
                TopSpeed = 290,
                YearOfProduction = 2009,
                ConsumptionPer100Km = 21.6,
                ImageURL = "https://www.historics.co.uk/media/1649547/g-wagon-1.jpg?anchor=center&mode=crop&width=1000",
                EngineFuelType = EngineFuelType.Gasoline,
                PricePerDay = 499.99,
                SafetyRating = 9.7,
                Seats = 5,
                EngineStructureType = EngineStructureType.V,
                CylindersNumber = 8,
                EngineAspirationType = EngineAspirationType.Supercharger,
                Displacement = 5500,
                PeakHorsepowerAtRPM = 6100,
                Torque = 700,
                PeakTorqueAtRPM = 3100
            });

            cars.Add(new Car()
            {
                Id = Guid.Parse("2ef90e6c-4356-465d-9389-9f6017b808c3"),
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Hatchback,
                TransmissionType = TransmissionType.Automatic,
                AccelerationTo100 = 10.9,
                Mileage = 76000,
                Horsepower = 122,
                TopSpeed = 180,
                YearOfProduction = 2019,
                ConsumptionPer100Km = 3.6,
                ImageURL = "https://www.auto-data.net/images/f15/Toyota-Corolla-XII_1.jpg",
                EngineFuelType = EngineFuelType.Hybrid,
                PricePerDay = 79.99,
                SafetyRating = 6.7,
                Seats = 5,
                EngineStructureType = EngineStructureType.Inline,
                CylindersNumber = 4,
                EngineAspirationType = EngineAspirationType.Atmospheric,
                Displacement = 1800,
                PeakHorsepowerAtRPM = 5200,
                Torque = 142,
                PeakTorqueAtRPM = 3600
            });

            cars.Add(new Car()
            {
                Id = Guid.Parse("2c4f96ad-c259-4494-aec1-d16085794319"),
                Make = "Mercedes",
                Model = "E60 AMG",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                AccelerationTo100 = 4.9,
                Mileage = 33000,
                Horsepower = 381,
                TopSpeed = 324,
                YearOfProduction = 1994,
                ConsumptionPer100Km = 13.4,
                ImageURL = "https://i0.wp.com/www.klasikotom.com/wp-content/uploads/2019/10/W124-E60-AMG-Mercedes-Benz-Tarihcesi-motor-teknik-ozellikleri-nedir-nasil-nasildir-kps.jpg?fit=639%2C369&ssl=1",
                EngineFuelType = EngineFuelType.Gasoline,
                PricePerDay = 1089.99,
                SafetyRating = 9.3,
                Seats = 4,
                EngineStructureType = EngineStructureType.V,
                CylindersNumber = 8,
                EngineAspirationType = EngineAspirationType.Atmospheric,
                Displacement = 6000,
                PeakHorsepowerAtRPM = 5500,
                Torque = 580,
                PeakTorqueAtRPM = 3750
            });

            cars.Add(new Car()
            {
                Id = Guid.Parse("4fd8c3e0-5b21-44e1-8d0c-b6cae13ad9e2"),
                Make = "Mercedes",
                Model = "S600 SEL",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                AccelerationTo100 = 5.9,
                Mileage = 59000,
                Horsepower = 408,
                TopSpeed = 308,
                YearOfProduction = 1998,
                ConsumptionPer100Km = 15.4,
                ImageURL = "https://business-car-rent.net/wp-content/uploads/2021/03/mercedes-benz-w140-s600-kaban-brabus-mersedes-dlya-kino-na-semki-bez-voditelya-na-prokat-brabus-mers-kiev-10-1.jpg",
                EngineFuelType = EngineFuelType.Gasoline,
                PricePerDay = 889.99,
                SafetyRating = 9.7,
                Seats = 5,
                EngineStructureType = EngineStructureType.V,
                CylindersNumber = 12,
                EngineAspirationType = EngineAspirationType.Atmospheric,
                Displacement = 6000,
                PeakHorsepowerAtRPM = 5200,
                Torque = 580,
                PeakTorqueAtRPM = 3800
            });
            return cars;
        }
    }
}
