using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Services;
using CarRental.Models.Comment;
using CarRental.Data;
using Microsoft.EntityFrameworkCore;
using CarRental.Data.Domain;
using CarRental.Models.Car;
using CarRental.Data.Domain.Enums;
using CarRental.Models.Rental;

namespace NUnitTests
{
    [TestFixture]
    public class CarServiceTests
    {
        private ApplicationDbContext dbContext;
        private CarService carService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            dbContext = new ApplicationDbContext(options);
            carService = new CarService(dbContext);
        }

        [Test]
        public async Task CreateAndReturnId_ShouldReturnCarId_WhenCarIsCreated()
        {
            var model = new CarViewModel
            {
                Make = "Toyota",
                Model = "Corolla",
                SelectedBodyType = BodyType.Sedan,
                SelectedTransmissionType = TransmissionType.Automatic,
                Mileage = 50000,
                AccelerationTo100 = 9.5,
                Horsepower = 150,
                TopSpeed = 180,
                YearOfProduction = 2020,
                SelectedEngineAspirationType = EngineAspirationType.Turbocharger,
                SelectedFuelType = EngineFuelType.Gasoline,
                SelectedEngineStructureType = EngineStructureType.Inline,
                CylindersNumber = 4,
                Displacement = 2000,
                PeakHorsepowerAtRPM = 5500,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 4,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "https://example.com/car.jpg",
                IsActive = true
            };
            var result = await carService.CreateAndReturnId(model);
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [Test]
        public async Task GetCarsWithFilterAndSortingAndPaging_ShouldReturnFilteredSortedAndPagedCars()
        {
            var cars = new List<Car>
    {
        new Car { Make = "Toyota", ImageURL="example.com", Model = "Corolla", BodyType = BodyType.Sedan, TransmissionType = TransmissionType.Automatic, EngineFuelType = EngineFuelType.Gasoline, PricePerDay = 50, Seats = 5, IsActive = true },
        new Car { Make = "Toyota", ImageURL="example.com",Model = "Camry", BodyType = BodyType.Sedan, TransmissionType = TransmissionType.Manual, EngineFuelType = EngineFuelType.Gasoline, PricePerDay = 60, Seats = 5, IsActive = true },
        new Car { Make = "Honda", ImageURL="example.com",Model = "Civic", BodyType = BodyType.Sedan, TransmissionType = TransmissionType.Automatic, EngineFuelType = EngineFuelType.Hybrid, PricePerDay = 55, Seats = 5, IsActive = true },
        new Car { Make = "Toyota", ImageURL="example.com",Model = "Rav4", BodyType = BodyType.SUV, TransmissionType = TransmissionType.Automatic, EngineFuelType = EngineFuelType.Gasoline, PricePerDay = 70, Seats = 5, IsActive = true },
        new Car { Make = "Honda", ImageURL="example.com",Model = "CR-V", BodyType = BodyType.SUV, TransmissionType = TransmissionType.Automatic, EngineFuelType = EngineFuelType.Diesel, PricePerDay = 80, Seats = 5, IsActive = true },
        new Car { Make = "Ford", ImageURL="example.com",Model = "Mustang", BodyType = BodyType.Coupe, TransmissionType = TransmissionType.Manual, EngineFuelType = EngineFuelType.Gasoline, PricePerDay = 90, Seats = 4, IsActive = true }
    };

            dbContext.Cars.AddRange(cars);
            dbContext.SaveChanges();

            var queryModel = new AllCarsQueryModel
            {
                BodyType = "Sedan",
                Make = "Toyota",
                Transmission = "Auto",
                EngineFuelType = "Gasoline",
                CarSorting = CarSorting.Newest,
                CurrentPage = 1,
                CarsPerPage = 6
            };
            var result = await carService.GetCarsWithFilterAndSortingAndPaging(queryModel);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Cars);
            Assert.IsTrue(result.Cars.Any());
            Assert.IsTrue(result.TotalCarsCount > 0);
        }

        [Test]
        public async Task GetDetailsById_ShouldReturnCarDetails()
        {
            var car = new Car
            {
                Id = Guid.NewGuid(),
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                Mileage = 50000,
                AccelerationTo100 = 9.5,
                Horsepower = 150,
                TopSpeed = 200,
                YearOfProduction = 2018,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                CylindersNumber = 4,
                Displacement = 2000,
                PeakHorsepowerAtRPM = 6000,
                Torque = 250,
                PeakTorqueAtRPM = 4000,
                ConsumptionPer100Km = 8.5,
                SafetyRating = 4.5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/image.jpg",
                IsActive = true
            };

            dbContext.Cars.Add(car);
            dbContext.SaveChanges();

            var carId = car.Id.ToString();
            var result = await carService.GetDetailsById(carId);
            Assert.IsNotNull(result);
            Assert.AreEqual(carId, result.Id);
            Assert.AreEqual("Toyota", result.Make);
            Assert.AreEqual("Corolla", result.Model);
            Assert.AreEqual(BodyType.Sedan, result.SelectedBodyType);
            Assert.AreEqual(TransmissionType.Automatic, result.SelectedTransmissionType);
            Assert.AreEqual(50000, result.Mileage);
            Assert.AreEqual(9.5, result.AccelerationTo100);
            Assert.AreEqual(150, result.Horsepower);
            Assert.AreEqual(200, result.TopSpeed);
            Assert.AreEqual(2018, result.YearOfProduction);
            Assert.AreEqual(EngineAspirationType.Turbocharger, result.SelectedEngineAspirationType);
            Assert.AreEqual(EngineFuelType.Gasoline, result.SelectedFuelType);
            Assert.AreEqual(EngineStructureType.Inline, result.SelectedEngineStructureType);
            Assert.AreEqual(4, result.CylindersNumber);
            Assert.AreEqual(2000, result.Displacement);
            Assert.AreEqual(6000, result.PeakHorsepowerAtRPM);
            Assert.AreEqual(250, result.Torque);
            Assert.AreEqual(4000, result.PeakTorqueAtRPM);
            Assert.AreEqual(8.5, result.ConsumptionPer100Km);
            Assert.AreEqual(4.5, result.SafetyRating);
            Assert.AreEqual(5, result.Seats);
            Assert.AreEqual(50, result.PricePerDay);
            Assert.AreEqual("example.com/image.jpg", result.ImageURL);
            Assert.IsTrue(result.IsActive);
        }

        [Test]
        public async Task GetCarsRentedBySpecificUser_ShouldReturnCarsRentedByUser()
        {
            var userId = Guid.NewGuid();
            var rentedCar1 = new Car
            {
                Id = Guid.NewGuid(),
                Make = "Toyota",
                Model = "Corolla",
                TransmissionType = TransmissionType.Automatic,
                BodyType = BodyType.Sedan,
                EngineFuelType = EngineFuelType.Gasoline,
                ImageURL = "example.com/car1.jpg",
                PricePerDay = 50,
                Seats = 5,
                IsActive = false,
                RenterId = userId
            };

            var rentedCar2 = new Car
            {
                Id = Guid.NewGuid(),
                Make = "Honda",
                Model = "Civic",
                TransmissionType = TransmissionType.Manual,
                BodyType = BodyType.Hatchback,
                EngineFuelType = EngineFuelType.Diesel,
                ImageURL = "example.com/car2.jpg",
                PricePerDay = 60,
                Seats = 4,
                IsActive = false,
                RenterId = userId
            };

            dbContext.Cars.AddRange(rentedCar1, rentedCar2);
            dbContext.SaveChanges();
            var result = await carService.GetCarsRentedBySpecificUser(userId);
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            var car1 = result.FirstOrDefault(c => c.Make == "Toyota" && c.Model == "Corolla");
            Assert.IsNotNull(car1);
            Assert.AreEqual(rentedCar1.Id.ToString(), car1.Id);
            Assert.AreEqual(TransmissionType.Automatic.ToString(), car1.Transmission);
            Assert.AreEqual(BodyType.Sedan.ToString(), car1.BodyType);
            Assert.AreEqual(EngineFuelType.Gasoline.ToString(), car1.EngineType);
            Assert.AreEqual("example.com/car1.jpg", car1.ImageUrl);
            Assert.AreEqual(50, car1.PricePerDay);
            Assert.AreEqual(5, car1.PassengerSeats);
            Assert.IsTrue(car1.IsRented);
            var car2 = result.FirstOrDefault(c => c.Make == "Honda" && c.Model == "Civic");
            Assert.IsNotNull(car2);
            Assert.AreEqual(rentedCar2.Id.ToString(), car2.Id);
            Assert.AreEqual(TransmissionType.Manual.ToString(), car2.Transmission);
            Assert.AreEqual(BodyType.Hatchback.ToString(), car2.BodyType);
            Assert.AreEqual(EngineFuelType.Diesel.ToString(), car2.EngineType);
            Assert.AreEqual("example.com/car2.jpg", car2.ImageUrl);
            Assert.AreEqual(60, car2.PricePerDay);
            Assert.AreEqual(4, car2.PassengerSeats);
            Assert.IsTrue(car2.IsRented);
        }

        [Test]
        public async Task GetCarForEditById_ShouldReturnCarForEdit()
        {
            var carId = Guid.NewGuid();
            var car = new Car
            {
                Id = carId,
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg",
                IsActive = true
            };

            dbContext.Cars.Add(car);
            dbContext.SaveChanges();
            var result = await carService.GetCarForEditById(carId);
            Assert.IsNotNull(result);
            Assert.AreEqual("Toyota", result.Make);
            Assert.AreEqual("Corolla", result.Model);
            Assert.AreEqual(BodyType.Sedan, result.SelectedBodyType);
            Assert.AreEqual(TransmissionType.Automatic, result.SelectedTransmissionType);
            Assert.AreEqual(2020, result.YearOfProduction);
            Assert.AreEqual(EngineFuelType.Gasoline, result.SelectedFuelType);
            Assert.AreEqual(EngineStructureType.Inline, result.SelectedEngineStructureType);
            Assert.AreEqual(EngineAspirationType.Turbocharger, result.SelectedEngineAspirationType);
            Assert.AreEqual(4, result.CylindersNumber);
            Assert.AreEqual(2000, result.Displacement);
            Assert.AreEqual(150, result.Horsepower);
            Assert.AreEqual(6000, result.PeakHorsepowerAtRPM);
            Assert.AreEqual(200, result.Torque);
            Assert.AreEqual(4000, result.PeakTorqueAtRPM);
            Assert.AreEqual(8.5, result.AccelerationTo100);
            Assert.AreEqual(200, result.TopSpeed);
            Assert.AreEqual(50000, result.Mileage);
            Assert.AreEqual(7.5, result.ConsumptionPer100Km);
            Assert.AreEqual(5, result.SafetyRating);
            Assert.AreEqual(5, result.Seats);
            Assert.AreEqual(50, result.PricePerDay);
            Assert.AreEqual("example.com/car.jpg", result.ImageURL);
        }

        [Test]
        public async Task EditCarByIdAndViewModel_ShouldEditCar()
        {
            var carId = Guid.NewGuid();
            var car = new Car
            {
                Id = carId,
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg",
                IsActive = true
            };

            dbContext.Cars.Add(car);
            dbContext.SaveChanges();

            var updatedModel = new CarViewModel
            {
                Make = "Honda",
                Model = "Civic",
                SelectedBodyType = BodyType.Hatchback,
                SelectedTransmissionType = TransmissionType.Manual,
                YearOfProduction = 2018,
                SelectedFuelType = EngineFuelType.Diesel,
                SelectedEngineStructureType = EngineStructureType.Boxer,
                SelectedEngineAspirationType = EngineAspirationType.Atmospheric,
                CylindersNumber = 4,
                Displacement = 1800,
                Horsepower = 120,
                PeakHorsepowerAtRPM = 5500,
                Torque = 180,
                PeakTorqueAtRPM = 3500,
                AccelerationTo100 = 9.0,
                TopSpeed = 190,
                Mileage = 60000,
                ConsumptionPer100Km = 6.5,
                SafetyRating = 4,
                Seats = 5,
                PricePerDay = 40,
                ImageURL = "example.com/honda.jpg"
            };
            await carService.EditCarByIdAndViewModel(carId, updatedModel);
            var editedCar = dbContext.Cars.First(c => c.Id == carId);
            Assert.IsNotNull(editedCar);
            Assert.AreEqual("Honda", editedCar.Make);
            Assert.AreEqual("Civic", editedCar.Model);
            Assert.AreEqual(BodyType.Hatchback, editedCar.BodyType);
            Assert.AreEqual(TransmissionType.Manual, editedCar.TransmissionType);
            Assert.AreEqual(2018, editedCar.YearOfProduction);
            Assert.AreEqual(EngineFuelType.Diesel, editedCar.EngineFuelType);
            Assert.AreEqual(EngineStructureType.Boxer, editedCar.EngineStructureType);
            Assert.AreEqual(EngineAspirationType.Atmospheric, editedCar.EngineAspirationType);
            Assert.AreEqual(4, editedCar.CylindersNumber);
            Assert.AreEqual(1800, editedCar.Displacement);
            Assert.AreEqual(120, editedCar.Horsepower);
            Assert.AreEqual(5500, editedCar.PeakHorsepowerAtRPM);
            Assert.AreEqual(180, editedCar.Torque);
            Assert.AreEqual(3500, editedCar.PeakTorqueAtRPM);
            Assert.AreEqual(9.0, editedCar.AccelerationTo100);
            Assert.AreEqual(190, editedCar.TopSpeed);
            Assert.AreEqual(60000, editedCar.Mileage);
            Assert.AreEqual(6.5, editedCar.ConsumptionPer100Km);
            Assert.AreEqual(4, editedCar.SafetyRating);
            Assert.AreEqual(5, editedCar.Seats);
            Assert.AreEqual(40, editedCar.PricePerDay);
            Assert.AreEqual("example.com/honda.jpg", editedCar.ImageURL);
        }

        [Test]
        public async Task DeleteCarById_ShouldDeleteCar()
        {
            var carId = Guid.NewGuid();
            var car = new Car
            {
                Id = carId,
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg",
                IsActive = true
            };

            dbContext.Cars.Add(car);
            dbContext.SaveChanges();
            await carService.DeleteCarById(carId);
            var deletedCar = await dbContext.Cars.FirstOrDefaultAsync(c => c.Id == carId);
            Assert.IsNull(deletedCar);
        }

        [Test]
        public async Task ExistById_ShouldReturnTrueForExistingCarId()
        {
            var carId = Guid.NewGuid();
            var car = new Car
            {
                Id = carId,
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg",
                IsActive = true
            };

            dbContext.Cars.Add(car);
            dbContext.SaveChanges();
            var result = await carService.ExistById(carId);
            Assert.IsTrue(result);
        }

        [Test]
        public async Task ExistById_ShouldReturnFalseForNonExistingCarId()
        {
            var carId = Guid.NewGuid();
            var result = await carService.ExistById(carId);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsRentedById_ShouldReturnTrueForRentedCarId()
        {
            // Arrange
            var carId = Guid.NewGuid();
            var car = new Car
            {
                Id = carId,
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg",
                IsActive = false,
                RenterId = Guid.NewGuid()
            };

            dbContext.Cars.Add(car);
            dbContext.SaveChanges();
            var result = await carService.IsRentedById(carId);
            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsRentedById_ShouldReturnFalseForNonRentedCarId()
        {
            var carId = Guid.NewGuid();
            var car = new Car
            {
                Id = carId,
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg",
                IsActive = true
            };

            dbContext.Cars.Add(car);
            dbContext.SaveChanges();
            var result = await carService.IsRentedById(carId);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetRentalFormById_ShouldReturnRentalFormWithCorrectCarId()
        {
            var carId = Guid.NewGuid();
            var result = await carService.GetRentalFormById(carId);
            Assert.IsNotNull(result);
            Assert.AreEqual(carId.ToString(), result.CarId);
        }

        [Test]
        public async Task RentCarAsync_ShouldRentCarAndReturnChangeIfDepositIsSufficient()
        {
            var rentalForm = new RentalForm
            {
                CarId = Guid.NewGuid().ToString(),
                Days = 5,
                Deposit = 300,
                PhoneNumber = "1234567890"
            };
            var userId = Guid.NewGuid();

            var car = new Car
            {
                Id = Guid.Parse(rentalForm.CarId),
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg",
                IsActive = true
            };

            var user = new ApplicationUser
            {
                Id = userId,
                PhoneNumber = null,
                FirstName = "Ivan",
                LastName = "Ivanov"
            };
            dbContext.Cars.Add(car);
            dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync();
            var result = await carService.RentCarAsync(rentalForm, userId);
            Assert.IsNotNull(result);
            Assert.AreEqual(50, result);
            var rental = await dbContext.Rentals.FirstOrDefaultAsync(r => r.CarId == car.Id);
            Assert.IsNotNull(rental);
            Assert.AreEqual(rentalForm.Days, (rental.EndDate - rental.StartDate).Days);
            Assert.IsFalse(car.IsActive);
            Assert.AreEqual(userId, car.RenterId);
            Assert.AreEqual(rentalForm.PhoneNumber, user.PhoneNumber);
        }

        [Test]
        public async Task IsRentedByUserWithId_ShouldReturnTrueIfCarIsRentedBySpecifiedUser()
        {
            // Arrange
            var carId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            var car = new Car
            {
                Id = carId,
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg",
                IsActive = false,
                RenterId = userId
            };

            dbContext.Cars.Add(car);
            await dbContext.SaveChangesAsync();
            var result = await carService.IsRentedByUserWithId(carId, userId);
            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsRentedByUserWithId_ShouldReturnFalseIfCarIsNotRentedBySpecifiedUser()
        {
            var carId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var differentUserId = Guid.NewGuid();

            var car = new Car
            {
                Id = carId,
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg",
                IsActive = false,
                RenterId = differentUserId
            };

            dbContext.Cars.Add(car);
            await dbContext.SaveChangesAsync();
            var result = await carService.IsRentedByUserWithId(carId, userId);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task LeaveCarById_ShouldSetRenterIdToNullAndSetActiveToTrue()
        {
            var carId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            var car = new Car
            {
                Id = carId,
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg",
                RenterId = userId, // Car is rented by a user
                IsActive = false // Car is not active (rented)
            };

            dbContext.Cars.Add(car);
            await dbContext.SaveChangesAsync();
            await carService.LeaveCarById(carId);
            var updatedCar = await dbContext.Cars.FirstAsync(c => c.Id == carId);
            Assert.IsNull(updatedCar.RenterId);
            Assert.IsTrue(updatedCar.IsActive);
        }

        [Test]
        public async Task AllAvailableMakeNamesAsync_ShouldReturnDistinctMakeNamesForActiveCars()
        {
            var cars = new List<Car>
    {
        new Car { 
                Id = Guid.NewGuid(),
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg", IsActive = true },
        new Car { 
                Id = Guid.NewGuid(),
                Make = "Honda",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg", IsActive = true },
        new Car { 
                Id = Guid.NewGuid(),
                Make = "Toyota",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg", IsActive = true },
        new Car { 
                Id = Guid.NewGuid(),
                Make = "Ford",
                Model = "Corolla",
                BodyType = BodyType.Sedan,
                TransmissionType = TransmissionType.Automatic,
                YearOfProduction = 2020,
                EngineFuelType = EngineFuelType.Gasoline,
                EngineStructureType = EngineStructureType.Inline,
                EngineAspirationType = EngineAspirationType.Turbocharger,
                CylindersNumber = 4,
                Displacement = 2000,
                Horsepower = 150,
                PeakHorsepowerAtRPM = 6000,
                Torque = 200,
                PeakTorqueAtRPM = 4000,
                AccelerationTo100 = 8.5,
                TopSpeed = 200,
                Mileage = 50000,
                ConsumptionPer100Km = 7.5,
                SafetyRating = 5,
                Seats = 5,
                PricePerDay = 50,
                ImageURL = "example.com/car.jpg", IsActive = false }
    };

            dbContext.Cars.AddRange(cars);
            await dbContext.SaveChangesAsync();
            var result = await carService.AllAvailableMakeNamesAsync();
            var expected = new List<string> { "Toyota", "Honda" };
            Assert.AreEqual(expected.Count, result.Count());
            foreach (var make in expected)
            {
                Assert.Contains(make, result.ToList());
            }
        }

    }
}
