using CarRental.Data.Domain;
using CarRental.Models.Car;
using CarRental.Models.Rental;

namespace CarRental.Contracts
{
    public interface ICarService
    {
        Task<string> CreateAndReturnId(CarViewModel formModel);
        Task<AllCarsFilteredAndPagedServiceModel> GetCarsWithFilterAndSortingAndPaging(AllCarsQueryModel quaryModel);
        Task<List<CarAllViewModel>> GetCarsRentedBySpecificUser(Guid userId);
        Task<CarViewModel> GetCarForEditById(Guid carId);
        Task EditCarByIdAndViewModel(Guid carId, CarViewModel model);
        Task DeleteCarById(Guid carId);
        Task<bool> ExistById(Guid carId);
        Task<bool> IsRentedById(Guid carId);
        Task<double?> RentCarAsync(RentalForm rentalForm, Guid userId);
        Task<bool> IsRentedByUserWithId(Guid carId, Guid userId);
        Task LeaveCarById(Guid carId);
        Task<IEnumerable<string>> AllAvailableMakeNamesAsync();
        Task<CarViewModel> GetDetailsById(string id);
    }
}
