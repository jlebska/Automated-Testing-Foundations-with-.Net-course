namespace dotNet_Automation_course.Commands
{
    public class AvgPriceCommand : ICommand
    {
        private CarPark _carPark;

        public AvgPriceCommand(CarPark carPark)
        {
            _carPark = carPark;
        }

        public double Execute()
        {
            return this._carPark.AvgPrice();
        }
    }
}
