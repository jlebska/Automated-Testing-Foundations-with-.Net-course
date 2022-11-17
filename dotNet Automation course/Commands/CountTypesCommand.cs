namespace dotNet_Automation_course.Commands
{
    public class CountTypesCommand : ICommand
    {
        private CarPark _carPark;

        public CountTypesCommand(CarPark carPark)
        {
            _carPark = carPark;
        }

        public double Execute()
        {
            return this._carPark.CountTypes();
        }
    }
}
