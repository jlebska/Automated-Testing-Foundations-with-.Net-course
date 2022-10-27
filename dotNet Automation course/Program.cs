
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
            PassengerCar passengerCar1 = new PassengerCar(); 
            Truck truck1 = new Truck();

            passengerCar1.getDescription();
            passengerCar1.Transmission.Manufacturer = "Changed Manufacturer";
            passengerCar1.getDescription();

            truck1.getDescription();
            truck1.Engine = new Engine(258.8, 123, "New Engine Type", "ABC124");
            truck1.getDescription();

            Bus bus1 = new Bus("Different name");
            bus1.getDescription();

            Scooter scooter1 = new Scooter();
            scooter1.getDescription();
            scooter1.Transmission = passengerCar1.Transmission;
            scooter1.getDescription();
        }
    }
}