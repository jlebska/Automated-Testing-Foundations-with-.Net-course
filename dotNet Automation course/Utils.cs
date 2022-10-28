
namespace dotNet_Automation_course
{
    class Utils
    {
        // Method to calculate a distance between two points
        public static double CalculateDistance(Point point1, Point point2)
        {
            double deltaX = point1.X - point2.X;
            double deltaY = point1.Y - point2.Y;
            double deltaZ = point1.Z - point2.Z;

            return (double)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }
}
