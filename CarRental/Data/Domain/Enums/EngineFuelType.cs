using System.ComponentModel.DataAnnotations;

namespace CarRental.Data.Domain.Enums
{
    public enum EngineFuelType
    {
        Gasoline,
        [Display(Name = "Gasoline/LPG")]
        GasolineLPG,
        [Display(Name = "Gasoline/CNG")]
        GasolineCNG,
        Diesel,
        Electric,
        Hybrid
    }
}
