using dotNet_Automation_course.VehicleParts;

namespace dotNet_Automation_course.Vehicles
{
    class Scooter : Vehicle
    {
        public Scooter(string name = "Scooter") 
            : base(name, new Engine(4.9, 10, "Scooter", "zxcvb"), new Chassis(8, "OPASD", 100), new Transmission("zxcvb", 6, "Scooter transmission Company"))
        { }
    }
}
