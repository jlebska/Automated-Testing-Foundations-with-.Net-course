

namespace dotNet_Automation_course.Flyable
{
    class Airplane : IFlyable
    {
        public double Speed
        {
            get; set;
        }
        public Point Position
        {
            get; set;
        }

        public bool IsWeatherNice
        {
            get;
        }
        double LastTraveledDistance
        {
            get; set;
        }

        /*
         The class takes the coordinates of a starting point of a drone for the constructors. 
         The default starting point is (0,0,0) and the speed is equal to 200 km/h.
         It also gets a random boolean to stimulate weather conditions.
         */
        public Airplane(int x = 0, int y = 0, int z = 0)
        {
            Speed = 200; //[km/h]
            Position = new Point(x, y, z);
            IsWeatherNice = new Random().Next(2)==1; 
        }

        // Method to fly to a specified point if the weather conditions are good.
        public bool FlyTo(Point coordinates)
        {
            if (!IsWeatherNice)
            {
                LastTraveledDistance = Utils.CalculateDistance(coordinates, Position);

                Position.X = Position.X + coordinates.X;
                Position.Y = Position.Y + coordinates.Y;
                Position.Z = Position.Z + coordinates.Z;

                return true;
            }
            else
            {
                Console.WriteLine("Impossible to fly, the weather conditions are bad.");
                return false;
            }
        }

        // Method that flies to a specified point and returns a time that it will take if the airplane accelerates by 10 km/h every 10 km.
        public double GetFlyTime(Point coordinates)
        {
            bool wasSuccesfull = FlyTo(coordinates);
            if (wasSuccesfull)
            {
                double distance =LastTraveledDistance;
                double time = 0;

                if (distance > 10)
                {
                    while (distance > 10)
                    {
                        time += 10 / Speed;
                        Speed += 10;
                        distance -= 10;
                    }
                }
                time += distance / Speed;
                Speed = 0;

                return time; //[h]
            }
            return 0;
        }
    }
}
