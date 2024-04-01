using CarRental.Data.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

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
                "Auto", "Manual", "SemiAutomatic", "CVT"
                };
			this.BodyTypes = new string[]
			{
				"Sedan",
			    "Estate",
			    "Hatchback",
			    "Coupe",
			    "SUV",
			    "Pickup",
			    "Roadster",
			    "Crossover",
			    "Limousine",
			    "Van",
			    "Camper",
				"Offroad",
			    "Convertible",
			    "Cabriolet",
			    "Sport",
			    "Micro"
		    };
			this.FuelTypes = new string[]
			{
				"Gasoline",
				"Gasoline/LPG",
				"Gasoline/CNG",
				"Diesel",
				"Hybrid"
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
		    public string[] BodyTypes { get; set; }
		    public string[] FuelTypes { get; set; }
		    public IEnumerable<string> Makes { get; set; }
            public IEnumerable<CarAllViewModel> Cars { get; set; }
        }
    }
