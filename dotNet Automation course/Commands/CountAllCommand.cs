namespace dotNet_Automation_course.Commands
{
    public class CountAllCommand : ICommand
    {
        private CarPark _carPark;

        public CountAllCommand(CarPark carPark)
        {
            _carPark = carPark;
        }

        public double Execute()
        {
            return this._carPark.CountAll();
        }
    }
}
