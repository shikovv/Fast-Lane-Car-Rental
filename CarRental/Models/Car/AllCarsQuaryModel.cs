using CarRental.Data.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models.Car
{
        public class AllCarsQueryModel
        {
            public AllCarsQueryModel()
            {
                this.CurrentPage = 1;
                this.CarsPerPage = 6;
                this.Makes = new HashSet<string>();
            this.Cars = new HashSet<CarAllViewModel>();
            this.Transmissions = new string[]
            {
                "Auto", "Manual", " SemiAutomatic", "CVT"
                };
            }

            public string Make { get; set; }
            public string Transmission { get; set; }
            public string BodyType {  get; set; }
            public string EngineFuelType { get; set; }
            [Display(Name = "Sort Cars By")]
            public CarSorting CarSorting { get; set; }
            public int CurrentPage { get; set; }
            public int TotalCarsCount { get; set; }
            [Display(Name = "Show Cars On Page")]
            public int CarsPerPage { get; set; }
            public string[] Transmissions { get; set; }
            public IEnumerable<string> Makes { get; set; }
            public IEnumerable<CarAllViewModel> Cars { get; set; }
        }
    }
