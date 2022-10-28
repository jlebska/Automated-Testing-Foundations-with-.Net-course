
using dotNet_Automation_course.VehicleParts;
using dotNet_Automation_course.Vehicles;

namespace dotNet_Automation_course
{
    class ThirdTask
    {
        static void Main(string[] args)
        {
            /*
             * Every vehicle type has its own default engine, chassis and transmission with which they are created but all the fields can be changed later.
             * The default value of the name in each of the vehicles is the name of the class, but a different name can also be passed through the constructor.
             * 
             * I don't know anything about cars so all the values are completely random.
            */

            Vehicle[] vehicles = new Vehicle[4];

            vehicles[0] = new PassengerCar(250);
            vehicles[1] = new Truck(25900);
            vehicles[2] = new Bus(false);
            vehicles[3] = new Scooter(true);

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.printDescription();
            }

        }
    }
}