using CarRental.Contracts;
using CarRental.Data.Domain.Enums;
using CarRental.Extensions;
using CarRental.Models.Car;
using CarRental.Models.Rental;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static CarRental.Models.Car.AllCarsQueryModel;

namespace CarRental.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService carService;

        public CarController(ICarService _carService)
        {
            this.carService = _carService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All(AllCarsQueryModel queryModel)
        {
            AllCarsFilteredAndPagedServiceModel serviceModel =
                await carService.GetCarsWithFilterAndSortingAndPaging(queryModel);

            queryModel.Cars = serviceModel.Cars;
            queryModel.TotalCarsCount = serviceModel.TotalCarsCount;
            queryModel.Makes = await carService.AllAvailableMakeNamesAsync();

            return View(queryModel);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add()
        {
            try
            {
                CarViewModel formModel = new CarViewModel();

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add(CarViewModel formModel)
        {


            if (!IsValidEnumValue(formModel.SelectedBodyType))
            {
                ModelState.AddModelError(nameof(BodyType), "Invalid Body Type.");
            }
            if (!IsValidEnumValue(formModel.SelectedFuelType))
            {
                ModelState.AddModelError(nameof(EngineFuelType), "Invalid Engine fuel Type.");
            }
            if (!IsValidEnumValue(formModel.SelectedTransmissionType))
            {
                ModelState.AddModelError(nameof(TransmissionType), "Invalid Transmission Type.");
            }
            if (!IsValidEnumValue(formModel.SelectedEngineAspirationType))
            {
                ModelState.AddModelError(nameof(EngineAspirationType), "Invalid engine aspiration type Type.");
            }
            if (!IsValidEnumValue(formModel.SelectedEngineStructureType))
            {
                ModelState.AddModelError(nameof(EngineStructureType), "Invalid engine structure Type.");
            }

            //if (!ModelState.IsValid)
            //{
            //    return View(formModel);
            //}

            try
            {
                string carId =
                    await carService.CreateAndReturnId(formModel);

                TempData["SuccessMessage"] = "Car was added successfully!";
                return RedirectToAction("Detail", "Car", new { id = carId });
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty,
                    "Unexpected error occurred while trying to add your new car!");

                return View(formModel);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Detail(string id)
        {
            bool carExists = await carService
                .ExistById(Guid.Parse(id));

            if (!carExists)
            {
                TempData["ErrorMessage"] = "Car with the provided id does not exist!";

                return RedirectToAction("All", "Car");
            }

            try
            {
                CarViewModel viewModel = await carService
                    .GetDetailsById(id);

                return View(viewModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            try
            {
                bool carExists = await carService
                    .ExistById(Guid.Parse(id));

                if (!carExists)
                {
                    TempData["ErrorMessage"] = "Car with the provided id does not exist!";

                    return RedirectToAction("All", "Car");
                }

                CarViewModel formModel = await carService
                    .GetCarForEditById(Guid.Parse(id));

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id, CarViewModel carModel)
        {
            if (!ModelState.IsValid)
            {
                return View(carModel);
            }

            try
            {
                bool carExists = await carService
                    .ExistById(Guid.Parse(id));

                if (!carExists)
                {
                    TempData["ErrorMessage"] = "Car with the provided id does not exist!";

                    return RedirectToAction("All", "Car");
                }

                await carService.EditCarByIdAndViewModel(Guid.Parse(id), carModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to edit the car!");

                return View(carModel);
            }

            return RedirectToAction("Detail", "Car", new { id });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                bool carExists = await carService
                    .ExistById(Guid.Parse(id));

                if (!carExists)
                {
                    TempData["ErrorMessage"] = "Car with the provided id does not exist!";

                    return RedirectToAction("All", "Car");
                }

                await carService.DeleteCarById(Guid.Parse(id));

                TempData["WarningMessage"] = "The car was successfully deleted!";

                return RedirectToAction("All", "Car");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Rent(string id)
        {
            try
            {
                bool carExists = await carService
                    .ExistById(Guid.Parse(id));

                if (!carExists)
                {
                    TempData["ErrorMessage"] = "Car with the provided id does not exist!";

                    return RedirectToAction("Detail", "Car");
                }

                RentalForm formModel = await carService
                    .GetRentalFormById(Guid.Parse(id));

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Rent(RentalForm viewModel)
        {
            try
            {
                bool carExist = await carService.ExistById(Guid.Parse(viewModel.CarId));

                if (!carExist)
                {
                    TempData["ErrorMessage"] = "Car with provided id does not exist! Please try again!";

                    return RedirectToAction("Detail", "Car", new { viewModel.CarId });
                }

                bool isCarRented = await carService.IsRentedById(Guid.Parse(viewModel.CarId));

                if (isCarRented)
                {
                    TempData["ErrorMessage"] = "Selected car is already rented by another user! Please select another car.";

                    return RedirectToAction("All", "Car");
                }

                double? change=await carService.RentCarAsync(viewModel, Guid.Parse(User.GetId())!);
                if(change<0)
                {
                    TempData["Shortage"] = $"{-change:f2}";
                    return RedirectToAction("Rent", "Car");
                }

                else
                {
                    TempData["Change"] = $"{change:f2}";
                    return RedirectToAction("Success", "Car");
                }

            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Success(RentalForm viewModel)
        {
            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Leave(string id)
        {
            try
            {
                bool carExist = await carService.ExistById(Guid.Parse(id));

                if (!carExist)
                {
                    TempData["ErrorMessage"] = "Car with provided id does not exist! Please try again!";

                    return RedirectToAction("All", "Car");
                }

                bool isCarRented = await carService.IsRentedById(Guid.Parse(id));
                if (!isCarRented)
                {
                    TempData["ErrorMessage"] = "Selected car is not rented! Please select one of your cars if you wish to leave them.";

                    return RedirectToAction("Mine", "Car");
                }

                bool isCurrUserRenterOfTheCar = await carService.IsRentedByUserWithId(Guid.Parse(id),Guid.Parse(User.GetId()!));

                if (!isCurrUserRenterOfTheCar)
                {
                    TempData["ErrorMessage"] =
                        "You must be the renter of the car in order to leave it! Please try again with one of your rented cars if you wish to leave it.";

                    return RedirectToAction("Mine", "Car");
                }

                await carService.LeaveCarById(Guid.Parse(id));

                TempData["InformationMessage"] = "You left your car successfully!";
            }
            catch (Exception)
            {
                return GeneralError();
            }

            return RedirectToAction("Mine", "Car");
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {

            List<CarAllViewModel> myCars = new List<CarAllViewModel>();

            string userId = User.GetId()!;

            try
            {
                myCars.AddRange(await carService.GetCarsRentedBySpecificUser(Guid.Parse(userId)));

                return View(myCars);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }






        private IActionResult GeneralError()
        {
            TempData["ErrorMessage"] = "Unexpected error occurred!";

            return RedirectToAction("Index", "Home");
        }

        private bool IsValidEnumValue<TEnum>(TEnum value)
        {
            return Enum.IsDefined(typeof(TEnum), value);
        }
    }
}
