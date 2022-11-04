using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_Automation_course.Flyable
{
    abstract class BaseFlyable : IFlyable
    {
        public double Speed
        {
            get; set; 
        }
        public Point Position
        {
            get; set;
        }
        protected double LastTraveledDistance
        {
            get; set;
        }

        abstract public bool FlyTo(Point coordinates);

        abstract public double GetFlyTime(Point coordinates);

        public static double CalculateDistance(Point point1, Point point2)
        {
            double deltaX = point1.X - point2.X;
            double deltaY = point1.Y - point2.Y;
            double deltaZ = point1.Z - point2.Z;

            return (double)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }
}
