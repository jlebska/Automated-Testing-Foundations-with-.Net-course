namespace dotNet_Automation_course.Commands
{
    public class AvgPricePerBrandCommand : ICommand
    {
        private CarPark _carPark;
        private string _brand;

        public AvgPricePerBrandCommand(CarPark carPark, string brand)
        {
            _carPark = carPark;
            _brand = brand;
        }

        public double Execute()
        {
            return this._carPark.AvgPricePerBrand(_brand);
        }
    }
}
