
namespace dotNet_Automation_course.Flyable
{
    class Bird : IFlyable
    {
        public double Speed 
        {
            get;
        }
        public Point Position
        {
            get; set;
        }
        double LastTraveledDistance
        {
            get; set;
        }

        /*
        The class takes a starting point, which default value is (0,0,0) for the constructor.
        The value of the speed is equal to a random number between 1 and 20 km/h.
         */
        public Bird(Point point)
        {
            Speed = new Random().Next(1, 20);
            Position = point;
        }

        // Method to fly to a specified point, with a [-1,1] margin of error. (Birds aren't always very precise while landing)
        public bool FlyTo(Point coordinates)
        {
            LastTraveledDistance = Utils.CalculateDistance(coordinates, Position);

            Position.X = Position.X + coordinates.X + new Random().Next(-1,1);
            Position.Y = Position.Y + coordinates.Y + new Random().Next(-1,1);
            Position.Z = Position.Z + coordinates.Z + new Random().Next(-1,1);

            return true;
        }

        // Method that flies to a specified point and returns a time that it will take
        public double GetFlyTime(Point coordinates)
        {
            FlyTo(coordinates);
            double distance = LastTraveledDistance;

            return distance/Speed; //[h]
        }
    }
}
