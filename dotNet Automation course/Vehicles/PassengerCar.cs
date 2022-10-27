using dotNet_Automation_course.VehicleParts;

namespace dotNet_Automation_course.Vehicles
{
    class PassengerCar : Vehicle
    {
        public PassengerCar(string name = "Passenger car")
            :base(name, new Engine(12.0, 18.0, "Passenger", "123567"), new Chassis(4, "45678", 2000), new Transmission("Car Transmission default", 6, "Company"))
        {}
    }
}
