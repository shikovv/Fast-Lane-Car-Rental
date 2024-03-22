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

        public CarService(ApplicationDbContext dbContext)
        {
            dbContext = context;
        }

        public async Task<string> CreateAndReturnId(CarViewModel model)
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


        public async Task<List<Car>> GetCarsWithFilterAndSortingAndPaging(
        string bodyType,
        string make,
        string transmissionType,
        string engineFuelType,
        string sortBy,
        int pageNumber,
        int pageSize)
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
                case "price ascending":
                    query = query.OrderBy(c => c.PricePerDay); break;
                case "price descending":        
                    query.OrderByDescending(c => c.PricePerDay); break;
                case "oldest to newer":
                    query = query.OrderBy(c => c.YearOfProduction); break;
                case "newest to older":     
                    query = query.OrderByDescending(c => c.YearOfProduction); break;
                default:
                    throw new ArgumentException("Invalid sorting parameter.", nameof(sortBy));
            }
            //paging
            int skip = (pageNumber - 1) * pageSize;
            query = query.Skip(skip).Take(pageSize);

            return await query.ToListAsync();
        }

        public async Task<List<Car>> GetCarsRentedBySpecificUser(Guid userId)
        {
            return await context.Cars
                .Where(c => c.IsActive == true&&
                            c.RenterId.HasValue&&
                            c.RenterId==userId
                )
                .ToListAsync();
        }

        public async Task<CarViewModel> GetCarForEditById(Guid carId)
        {
            Car car = await this.context
                .Cars
                .Where(c => c.IsActive == true)
                .FirstAsync(c => c.Id == carId);

            return new CarViewModel
            {
                Make = car.Make,
                SelectedBodyType = car.BodyType,
                Model = car.Model,
                SelectedTransmissionType = car.TransmissionType,
                YearOfProduction = car.YearOfProduction,
                SelectedFuelType = car.EngineFuelType,
                SelectedEngineStructureType = car.EngineStructureType,
                SelectedEngineAspirationType = car.EngineAspirationType,
                CylindersNumber = car.CylindersNumber,
                Displacement = car.Displacement,
                Horsepower = car.Horsepower,
                PeakHorsepowerAtRPM = car.PeakHorsepowerAtRPM,
                Torque = car.Torque,
                PeakTorqueAtRPM = car.PeakTorqueAtRPM,
                AccelerationTo100 = car.AccelerationTo100,
                TopSpeed = car.TopSpeed,
                Mileage = car.Mileage,
                ConsumptionPer100Km = car.ConsumptionPer100Km,
                SafetyRating = car.SafetyRating,
                Seats = car.Seats,
                PricePerDay = car.PricePerDay,
                ImageURL = car.ImageURL
            };

        }

        public async Task EditCarByIdAndViewModel(Guid carId, CarViewModel model)
        {
            Car car = await context.Cars
                .Where(c => c.IsActive == true)
                .FirstAsync(c => c.Id == carId);

            car.Make = model.Make;
            car.BodyType = model.SelectedBodyType;
            car.Model = model.Model;
            car.TransmissionType = model.SelectedTransmissionType;
            car.YearOfProduction = model.YearOfProduction;
            car.EngineFuelType = model.SelectedFuelType;
            car.EngineStructureType = model.SelectedEngineStructureType;
            car.EngineAspirationType = model.SelectedEngineAspirationType;
            car.CylindersNumber = model.CylindersNumber;
            car.Displacement = model.Displacement;
            car.Horsepower = model.Horsepower;
            car.PeakHorsepowerAtRPM = model.PeakHorsepowerAtRPM;
            car.Torque = model.Torque;
            car.PeakTorqueAtRPM = model.PeakTorqueAtRPM;
            car.AccelerationTo100 = model.AccelerationTo100;
            car.TopSpeed = model.TopSpeed;
            car.Mileage = model.Mileage;
            car.ConsumptionPer100Km = model.ConsumptionPer100Km;
            car.SafetyRating = model.SafetyRating;
            car.Seats = model.Seats;
            car.PricePerDay = model.PricePerDay;
            car.ImageURL = model.ImageURL;

            await this.context.SaveChangesAsync();
        }

        public async Task DeleteCarById(Guid carId)
        {
            Car carToDelete = await this.context
                .Cars
                .FirstAsync(c => c.Id == carId);

            this.context.Cars.Remove(carToDelete);
            await this.context.SaveChangesAsync();
        }

        public async Task<bool> ExistById(Guid carId)
        {
            bool result = await this.context
                .Cars
                .Where(c => c.IsActive)
                .AnyAsync(c => c.Id == carId);

            return result;
        }

        public async Task<bool> IsRentedById(Guid carId)
        {
            Car car = await this.context
                .Cars
                .FirstAsync(c => c.Id == carId);

            return car.RenterId.HasValue;
        }


    }
}
