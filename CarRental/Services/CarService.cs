namespace CarRental.Services
{
    using CarRental.Contracts;
    using CarRental.Data;
    using CarRental.Data.Domain;
    using CarRental.Models.Car;
    using CarRental.Models.Rental;
    using Data.Domain.Enums;
    using Microsoft.EntityFrameworkCore;

    public class CarService:ICarService
    {
        private readonly ApplicationDbContext context;

        public CarService(ApplicationDbContext context)
        {
            this.context = context;
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


        public async Task<AllCarsFilteredAndPagedServiceModel> GetCarsWithFilterAndSortingAndPaging(AllCarsQueryModel quaryModel)
        {
            IQueryable<Car> query = context.Cars.Where(c=>c.IsActive).AsQueryable();
            List<CarAllViewModel> cars = new List<CarAllViewModel>();

			//filter
			query = quaryModel.BodyType switch
			{
				"Sedan" => query
					.Where(c => c.BodyType == BodyType.Sedan),
				"Estate" => query
					.Where(c => c.BodyType == BodyType.Estate),
				"Hatchback" => query
					.Where(c => c.BodyType == BodyType.Hatchback),
				"Coupe" => query
					.Where(c => c.BodyType == BodyType.Coupe),
				"SUV" => query
				.Where(c => c.BodyType == BodyType.SUV),
				"Pickup" => query
				.Where(c => c.BodyType == BodyType.Pickup),
				"Roadster" => query
					.Where(c => c.BodyType == BodyType.Roadster),
				"Crossover" => query
				.Where(c => c.BodyType == BodyType.Crossover),
				"Limousine" => query
					.Where(c => c.BodyType == BodyType.Limousine),
				"Van" => query
				.Where(c => c.BodyType == BodyType.Van),
				"Camper" => query
					.Where(c => c.BodyType == BodyType.Camper),
				"Offroad" => query
				.Where(c => c.BodyType == BodyType.Offroad),
				"Convertible" => query
					.Where(c => c.BodyType == BodyType.Convertible),
				"Cabriolet" => query
				.Where(c => c.BodyType == BodyType.Cabriolet),
				"Sport" => query
					.Where(c => c.BodyType == BodyType.Sport),
				"Micro" => query
				.Where(c => c.BodyType == BodyType.Micro),
				_ => query
			};

			if (!string.IsNullOrEmpty(quaryModel.Make))
                query = query.Where(c => c.Make.ToLower() == quaryModel.Make.ToLower());
            query = quaryModel.Transmission switch
            {
                "Auto" => query
                    .Where(c => c.TransmissionType == TransmissionType.Automatic),
                "Manual" => query
                    .Where(c => c.TransmissionType == TransmissionType.Manual),
                "SemiAutomatic" => query
                    .Where(c => c.TransmissionType == TransmissionType.SemiAutomatic),
                "CVT" => query
                    .Where(c => c.TransmissionType == TransmissionType.CVT),
                _ =>query
            };

            query = quaryModel.EngineFuelType switch
            {
                "Gasoline" => query
                    .Where(c => c.EngineFuelType == EngineFuelType.Gasoline),
                "Gasoline/LPG" => query
                    .Where(c => c.EngineFuelType == EngineFuelType.GasolineLPG),
                "Gasoline/CNG" => query
                    .Where(c => c.EngineFuelType == EngineFuelType.GasolineCNG),
                "Diesel" => query
                    .Where(c => c.EngineFuelType == EngineFuelType.Diesel),
                "Hybrid" => query
               .Where(c => c.EngineFuelType == EngineFuelType.Hybrid),
                _ => query
            };

            //sort
            query = quaryModel.CarSorting switch
            {
                CarSorting.Newest => query
                     .OrderByDescending(c => c.YearOfProduction),
                CarSorting.Oldest => query
                    .OrderBy(c => c.YearOfProduction),
                CarSorting.PriceAscending => query
                    .OrderBy(c => c.PricePerDay),
                CarSorting.PriceDescending => query
                    .OrderByDescending(c => c.PricePerDay),
                    _ => query
                 .OrderBy(c => c.RenterId != null)
            };
            //paging
            IEnumerable<CarAllViewModel> allCars = await query
                 .Include(c => c.Rentals)
                 .Where(c => c.IsActive)
                 .Skip((quaryModel.CurrentPage - 1) * quaryModel.CarsPerPage)
                 .Take(quaryModel.CarsPerPage)
                 .Select(c => new CarAllViewModel
                 {
                     Id = c.Id.ToString(),
                     Make = c.Make,
                     Model = c.Model,
                     Transmission = c.TransmissionType.ToString(),
                     BodyType = c.BodyType.ToString(),
                     EngineType = c.EngineFuelType.ToString(),
                     ImageUrl = c.ImageURL,
                     PricePerDay = c.PricePerDay,
                     PassengerSeats = c.Seats,
                     IsRented = c.RenterId.HasValue,
                 })
                 .ToArrayAsync();

            int totalCars = query.Count();

            return new AllCarsFilteredAndPagedServiceModel()
            {
                TotalCarsCount = totalCars,
                Cars = allCars
            };
        }

        public async Task<CarViewModel> GetDetailsById(string carId)
        {
            Car car = await this.context
                .Cars
                .Include(c => c.Rentals)
                .ThenInclude(r => r.UserRentals)
                .ThenInclude(ur => ur.ApplicationUser)
                .Where(c => c.IsActive)
                .FirstAsync(c => c.Id.ToString() == carId);

            return new CarViewModel
            {
                Id = car.Id.ToString(),
                Make = car.Make,
                Model = car.Model,
                SelectedBodyType = car.BodyType,
                SelectedTransmissionType = car.TransmissionType,
                Mileage = car.Mileage,
                AccelerationTo100 = car.AccelerationTo100,
                Horsepower = car.Horsepower,
                TopSpeed = car.TopSpeed,
                YearOfProduction = car.YearOfProduction,
                SelectedEngineAspirationType = car.EngineAspirationType,
                SelectedFuelType = car.EngineFuelType,
                SelectedEngineStructureType = car.EngineStructureType,
                CylindersNumber = car.CylindersNumber,
                Displacement = car.Displacement,
                PeakHorsepowerAtRPM = car.PeakHorsepowerAtRPM,
                Torque = car.Torque,
                PeakTorqueAtRPM = car.PeakTorqueAtRPM,
                ConsumptionPer100Km = car.ConsumptionPer100Km,
                SafetyRating = car.SafetyRating,
                Seats = car.Seats,
                PricePerDay = car.PricePerDay,
                ImageURL = car.ImageURL,
                RentalForm = new Models.Rental.RentalForm()
                {
                    CarId = car.Id.ToString()
                }
            };
        }

        public async Task<List<CarAllViewModel>> GetCarsRentedBySpecificUser(Guid userId)
        {
            List<CarAllViewModel> carsReady=new List<CarAllViewModel>();
            List<Car> cars= await context.Cars
                .Where(c => c.IsActive == true&&
                            c.RenterId.HasValue&&
                            c.RenterId==userId
                )
                .ToListAsync();
            foreach(var car in cars)
            {
                CarAllViewModel model = new CarAllViewModel()
                {
                    Id = car.Id.ToString(),
                    Make = car.Make,
                    Model = car.Model,
                    Transmission = car.TransmissionType.ToString(),
                    BodyType = car.BodyType.ToString(),
                    EngineType = car.EngineFuelType.ToString(),
                    ImageUrl = car.ImageURL,
                    PricePerDay = car.PricePerDay,
                    PassengerSeats = car.Seats,
                    IsRented = car.RenterId.HasValue,
                };
                carsReady.Add(model);
            }
            return carsReady;
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

        public async Task<double?> RentCarAsync(RentalForm rentalForm, Guid userId)
        {
            double? change = 0;
            double? shortage = 0;
            Car car = await this.context
                .Cars
                .Where(c => c.IsActive)
                .FirstAsync(c => c.Id.ToString() == rentalForm.CarId);

            car.RenterId = userId;

            var user = await this.context.Users.FirstAsync(u => u.Id == userId);

            if (user.PhoneNumber == null)
            {
                user.PhoneNumber = rentalForm.PhoneNumber;
            }

            if (rentalForm.Deposit >= car.PricePerDay * rentalForm.Days)
            {
                Rental rental = new Rental()
                {
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow.AddDays(rentalForm.Days!.Value),
                    CarId = Guid.Parse(rentalForm.CarId!),
                    Deposit = rentalForm.Deposit!.Value,
                    Price = car.PricePerDay * rentalForm.Days!.Value,
                };
                this.context.Rentals.Add(rental);
                car.IsActive = false;
                UserRental userRentals = new UserRental()
                {
                    CustomerId = user.Id,
                    RentalId = rental.Id,
                };
                this.context.UserRentals.Add(userRentals);
                change = rentalForm.Deposit - (car.PricePerDay * rentalForm.Days);
                await this.context.SaveChangesAsync();
                return change;
            }
            else
            {
                shortage = (car.PricePerDay * rentalForm.Days) - rentalForm.Deposit;
                await this.context.SaveChangesAsync();
                return shortage;
            }
            
        }

        public async Task<bool> IsRentedByUserWithId(Guid carId, Guid userId)
        {
            Car car = await this.context
                .Cars
                .FirstAsync(c => c.Id == carId);

            return car.IsActive
                && car.RenterId == userId;
        }

        public async Task LeaveCarById(Guid carId)
        {
            Car car = await this.context
                .Cars
                .FirstAsync(c => c.Id == carId);

            car.RenterId = null;
            car.IsActive = true;
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<string>> AllAvailableMakeNamesAsync()
        {
            IEnumerable<string> allNames = await this.context
                .Cars
                .Where(c => c.IsActive)
                .Select(c => c.Make)
                .Distinct()
                .ToArrayAsync();

            return allNames;
        }
    }
}
