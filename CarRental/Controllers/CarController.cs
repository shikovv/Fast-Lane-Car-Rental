using CarRental.Contracts;
using CarRental.Models.Car;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static CarRental.Models.Car.AllCarsQueryModel;

namespace CarRental.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllCarsQueryModel queryModel)
        {
            AllCarsFilteredAndPagedServiceModel serviceModel =
                await carService.GetCarsWithFilterAndSortingAndPaging(queryModel);

            queryModel.Cars = serviceModel.Cars;
            queryModel.TotalCarsCount = serviceModel.TotalCarsCount;
            queryModel.Makes = await carService.AllAvailableMakeNamesAsync();

            return View(queryModel);
        }
    }
}
