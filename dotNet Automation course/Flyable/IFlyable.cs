
namespace dotNet_Automation_course
{
    interface IFlyable
    {
        public bool FlyTo(Point coordinates);
        public double GetFlyTime(Point coordinates);
    }
}
