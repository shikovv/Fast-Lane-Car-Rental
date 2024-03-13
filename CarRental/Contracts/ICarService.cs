using CarRental.Models.Car;

namespace CarRental.Contracts
{
    public interface ICarService
    {
        Task<string> CreateAndReturnIdAsync(CarViewModel formModel);
    }
}
