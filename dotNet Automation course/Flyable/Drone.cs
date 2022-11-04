namespace dotNet_Automation_course.Flyable
{
    class Drone : IFlyable
    {
        // A drone has a limit of km that it can fly. If flying to a point would reach that limit, it doesn't fly and returns an appropriate message
        const int kmLimit = 1000;
        public double Speed 
        {
            get;set;
        }
        public Point Position
        {
            get; set;
        }
        public double KmTraveled
        {
            get; set;
        }

        double LastTraveledDistance
        {
            get; set;
        }

        /*
        The class takes a speed and the coordinates of a starting point of a drone for the constructor. 
        The default value of speed is equal to 5[km/h] and default starting point is (0,0,0)
        */
        public Drone(Point point, double speed= 5)
        {
            Speed = speed;
            Position = point;
            KmTraveled = 0;
        }

        // Method to fly to a specified point if the action would't cause reaching the km limit.
        public bool FlyTo(Point coordinates)
        {
            if (KmTraveled + Utils.CalculateDistance(coordinates, Position) < kmLimit)
            {
                KmTraveled += Utils.CalculateDistance(coordinates, Position);
                LastTraveledDistance = Utils.CalculateDistance(coordinates, Position);

                Position.X = Position.X + coordinates.X;
                Position.Y = Position.Y + coordinates.Y;
                Position.Z = Position.Z + coordinates.Z;

                return true;
            }
            else
            {
                Console.WriteLine("Impossible to fly to this point, the limit of km would be reached");
                return false;
            }

        }

        // Method that flies to a specified point and returns a time that it will take if the drone hovers in the air for 1 minute, every 10 minutes
        public double GetFlyTime(Point coordinates)
        {
            bool wasSuccesfull = FlyTo(coordinates);
            if (wasSuccesfull)
            {
                double distance = LastTraveledDistance;
                double timeInHours = distance / Speed;
                double timeInMinutes = timeInHours * 60;
                int stops = Convert.ToInt32(Math.Floor(timeInMinutes / 10));

                return (timeInMinutes + stops) / 60; //[h]
            }
            return 0;
        }
    }
}
