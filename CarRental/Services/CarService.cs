namespace CarRental.Services
{
    using CarRental.Data;
    using CarRental.Data.Domain;
    using CarRental.Models.Car;
    using Data.Domain.Enums;
    public class CarService
    {
        private readonly ApplicationDbContext context;
        public async Task<string> CreateAndReturnIdAsync(CarFormModel model)
        {
            Car car = new Car
            {
                Make = model.Make,
                Model = model.Model,
                BodyType = model.SelectedBodyType,
                TransmissionType = model.SelectedTransmissionType,
                Mileage = model.Mileage,
                AccelerationTo100 = model.AccelerationTo100,
                Horsepower = model.Horsepower,
                TopSpeed = model.TopSpeed,
                YearOfProduction = model.YearOfProduction,
                EngineAspirationType = model.SelectedEngineAspirationType,
                EngineFuelType = model.SelectedFuelType,
                EngineStructureType = model.SelectedEngineStructureType,
                CylindersNumber = model.CylindersNumber,
                Displacement = model.Displacement,
                PeakHorsepowerAtRPM = model.PeakHorsepowerAtRPM,
                Torque=model.Torque,
                PeakTorqueAtRPM = model.PeakTorqueAtRPM,
                ConsumptionPer100Km = model.ConsumptionPer100Km,
                SafetyRating = model.SafetyRating,
                Seats = model.Seats,
                PricePerDay = model.PricePerDay,
                ImageURL = model.ImageURL,
            };

            await this.context.Cars.AddAsync(car);
            await this.context.SaveChangesAsync();

            return car.Id.ToString();
        }
    }
}
