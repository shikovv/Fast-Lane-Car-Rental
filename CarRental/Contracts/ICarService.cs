using CarRental.Data.Domain;
using CarRental.Models.Car;
using CarRental.Models.Rental;

namespace CarRental.Contracts
{
    public interface ICarService
    {
        Task<string> CreateAndReturnId(CarViewModel formModel);
        Task<List<Car>> GetCarsWithFilterAndSortingAndPaging(
        string bodyType,
        string make,
        string transmissionType,
        string engineFuelType,
        string sortBy,
        int pageNumber,
        int pageSize);
        Task<List<Car>> GetCarsRentedBySpecificUser(Guid userId);
        Task<CarViewModel> GetCarForEditById(Guid carId);
        Task EditCarByIdAndViewModel(Guid carId, CarViewModel model);
        Task DeleteCarById(Guid carId);
        Task<bool> ExistById(Guid carId);
        Task<bool> IsRentedById(Guid carId);
        Task<double?> RentCarAsync(RentalForm rentalForm, Guid userId);
        Task<bool> IsRenterByUserWithId(Guid carId, Guid userId);
        Task LeaveCarById(Guid carId);
    }
}
