using System.ComponentModel.DataAnnotations;

namespace CarRental.Data.Domain.Enums
{
    public enum EngineAspirationType
    {
        [Display(Name = "Naturally Aspirated")]
        NaturallyAspirated,
        TurboCharged,
        SuperCharged
    }
}
