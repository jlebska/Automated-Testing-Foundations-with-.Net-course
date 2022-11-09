
using dotNet_Automation_course.CustomExceptions;
using dotNet_Automation_course.Vehicles;
using System.Xml.Linq;

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

            var vehicles = new List<Vehicle> {
                new PassengerCar(250), new Truck(25900), new Bus(false), new Scooter(true)};

            try
            {
                Vehicle car = new PassengerCar(123, "Seat", null);
            }
            catch (InitializationException e)
            {
                Console.WriteLine(e.Message);
            }


            CarPark carPark = new CarPark();
            carPark.AddVehicle(new Scooter(true),"abc");
            carPark.AddVehicle(new Bus(false));
            carPark.AddVehicle(new Scooter(false));

            /*
            foreach (KeyValuePair<string,Vehicle> entry in carPark.ListOfAvaibleVehicles)
            {
                Console.WriteLine($"Uder the Id= {entry.Key} is:");
                entry.Value.printDescription();
            }
            */

            try
            {
                carPark.AddVehicle(new Truck(300), "abc");
            }
            catch (AddException e)
            {
                Console.WriteLine(e.Message);
            }

            var results = carPark.GetAutoByParameter("Scooter", "Scooter");
            Console.WriteLine(results);
        }
    }
}