namespace CarRental.Services
{
    using CarRental.Data;
    using CarRental.Data.Domain;
    using CarRental.Models.Car;
    using Data.Domain.Enums;
    using Microsoft.EntityFrameworkCore;

    public class CarService
    {
        private readonly ApplicationDbContext context;
        public async Task<string> CreateAndReturnIdAsync(CarViewModel model)
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


        public async Task<List<Car>> GetCarsWithFilterAndSorting(
        string bodyType,
        string make,
        string transmissionType,
        string engineFuelType,
        string sortBy,
        bool isAscending)
        {
            IQueryable<Car> query = context.Cars.AsQueryable();

            //filter
            if (!string.IsNullOrEmpty(bodyType))
                query = query.Where(c => c.BodyType.ToString() == bodyType);

            if (!string.IsNullOrEmpty(make))
                query = query.Where(c => c.Make.ToLower() == make.ToLower());

            if (!string.IsNullOrEmpty(transmissionType))
                query = query.Where(c => c.TransmissionType.ToString().ToLower() == transmissionType.ToLower());

            if (!string.IsNullOrEmpty(engineFuelType))
                query = query.Where(c => c.EngineFuelType.ToString().ToLower() == engineFuelType.ToLower());

            //sort
            switch (sortBy.ToLower())
            {
                case "price":
                    query = isAscending ? query.OrderBy(c => c.PricePerDay) : query.OrderByDescending(c => c.PricePerDay);
                    break;
                case "year":
                    query = isAscending ? query.OrderBy(c => c.YearOfProduction) : query.OrderByDescending(c => c.YearOfProduction);
                    break;
                default:
                    throw new ArgumentException("Invalid sorting parameter.", nameof(sortBy));
            }

            return await query.ToListAsync();
        }
    }
}
