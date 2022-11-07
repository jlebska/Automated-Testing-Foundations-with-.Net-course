using dotNet_Automation_course.VehicleParts;

namespace dotNet_Automation_course.Vehicles
{
    class Truck : Vehicle
    {
        public int MonthlyKmLimit
        {
            get; set; 
        }
        public Truck(int monthlyKmLimit, string name = "Truck")
            :base(name, new Engine(89.0, 200.0, "Truck", "Anshkl"), new Chassis(8, "67890gj", 200000), new Transmission("qwerty", 6, "Truck manufacturer"))
        {
            MonthlyKmLimit = monthlyKmLimit;
            AdditionalInfo = $"Monthly km limit for the truck is equal to {MonthlyKmLimit}.";
        }
    }
}
