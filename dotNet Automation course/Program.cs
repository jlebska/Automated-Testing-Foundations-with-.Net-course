
using dotNet_Automation_course.CustomExceptions;
using dotNet_Automation_course.Vehicles;
using System.Xml.Linq;

namespace dotNet_Automation_course
{
    class SixthTask
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

            /*
            InitializationException
            Arguments name and model of each vehicle cannot be null
            */

            try
            {
                Vehicle car = new PassengerCar(123, "Seat", null);
            }
            catch (InitializationException e)
            {
                Console.WriteLine(e.Message);
            }

            //Car park contains a log of all avaible vehicles. When adding new vehicle to the park user can specify an id in form of string or the id will be assigned by default.
            CarPark carPark = new CarPark();
            carPark.AddVehicle(new Scooter(true),"abc");
            carPark.AddVehicle(new Bus(false));
            carPark.AddVehicle(new Scooter(false));

            //AddException
            //It's not possible to add a new vehicle to the park with the same id as already existing vehicle
            try
            {
                carPark.AddVehicle(new Truck(300), "abc");
            }
            catch (AddException e)
            {
                Console.WriteLine(e.Message);
            }


            //GetAutoByParameterException
            //Throws an exception when it's not possible to find a vehicle/
            //In the message it specifies if there's no vehicle with searched parameter at all or if the parameter exists but the value is not equal to the searched.
            Console.WriteLine($"The number of vehicles with the name \"Scooter\" in the carPark is equal to {carPark.GetAutoByParameter("Name", "Scooter").Count()}.");

            try
            {
                var invalid = carPark.GetAutoByParameter("Name", "a");
            }
            catch (GetAutoByParameterException e)
            {
                Console.WriteLine(e.Message);
            }


            //UpdateAutoException
            //Throws an exception when there's no vehicle with an id as provided.
            carPark.UpdateAuto("abc", new PassengerCar(123));
            try
            {
                carPark.UpdateAuto("5678", new PassengerCar(123));
            }
            catch (UpdateAutoException e)
            {
                Console.WriteLine(e.Message);
            }

            //RemoveAutoException
            //Throws an exception when there's no vehicle with an id as provided.
            carPark.RemoveAuto("abc");
            try
            {
                carPark.RemoveAuto("qwerty");
            }
            catch(RemoveAutoException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}