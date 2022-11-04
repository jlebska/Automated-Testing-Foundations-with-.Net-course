
using dotNet_Automation_course.Flyable;

namespace dotNet_Automation_course
{
    class FourthTask
    {
        static void Main(string[] args)
        {
            Bird bird = new(new Point(0,0,0));
            double time1 = bird.GetFlyTime(new Point(2, 0, 0));
            Console.WriteLine(time1);            
            
            Airplane airplane = new(new Point(0, 0, 0));
            double time2 = airplane.GetFlyTime(new Point(0,18,0));
            Console.WriteLine(time2);
            
            Drone drone = new(new Point(0, 0, 0));
            double time3 = drone.GetFlyTime(new Point(0, 0, 1));
            Console.WriteLine(time3);
        }
    }
}