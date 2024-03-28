namespace CarRental.Models.Car
{
    public class AllCarsFilteredAndPagedServiceModel
    {
        public AllCarsFilteredAndPagedServiceModel()
        {
            this.Cars = new HashSet<CarAllViewModel>();
        }

        public int TotalCarsCount { get; set; }
        public IEnumerable<CarAllViewModel> Cars { get; set; }
    }
}
