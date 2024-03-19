using CarRental.Data.Domain;
using CarRental.Models.Car;

namespace CarRental.Contracts
{
    public interface ICarService
    {
        Task<string> CreateAndReturnIdAsync(CarViewModel formModel);
        Task<List<Car>> GetCarsWithFilterAndSortingAndPaging(
        string bodyType,
        string make,
        string transmissionType,
        string engineFuelType,
        string sortBy,
        int pageNumber,
        int pageSize);
        Task<List<Car>> GetCarsRentedBySpecificUser(Guid userId);
    }
}
