
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

            //All information about all vehicles an engine capacity of which is more than 1.5 liters
            var vehicles = new List<Vehicle> {
                new PassengerCar(250), new Truck(25900), new Bus(false), new Scooter(true)};

            var engineVolumes = 
                from vehicle in vehicles
                where vehicle.Engine.Volume > 1.5
                select vehicle;

            Utils.saveToXML("EngineVolumeHigh", "highEngineVolume", engineVolumes.Select(v => v.PartialXML).ToArray());

            //Engine type, serial number and power rating for all buses and trucks
            //I'm doing two separate queries for buses and for trucks instead of using an || to have them in separte nodes in the XML file
            var buses =
                from vehicle in vehicles
                where vehicle.Name.Equals("Bus")
                select new { vehicle.Engine.EngineType, vehicle.Engine.SerialNumber, vehicle.Engine.Power };

            XElement busesXML = new XElement("Buses",
                new XElement("EngineType", buses.Select(b => b.EngineType)),
                new XElement("SerialNumber", buses.Select(b => b.SerialNumber)),
                new XElement("Power", buses.Select(b => b.Power)));

            var trucks =
            from vehicle in vehicles
            where vehicle.Name.Equals("Truck")
            select new { vehicle.Engine.EngineType, vehicle.Engine.SerialNumber, vehicle.Engine.Power };

            XElement trucksXML = new XElement("Trucks",
                new XElement("EngineType", trucks.Select(t => t.EngineType)),
                new XElement("SerialNumber", trucks.Select(t => t.SerialNumber)),
                new XElement("Power", trucks.Select(t => t.Power)));

            Utils.saveToXML("SelectedParamsForBusesAndTrucks", "selectedParamsForBusesAndTrucks", busesXML, trucksXML);


            //All information about all vehicles, grouped by transmission type
            var allGroupedByTransmission =
                from vehicle in vehicles
                group vehicle by vehicle.Transmission.TransmissionType;

            List<XElement> xElements = new();
            foreach (var group in allGroupedByTransmission)
            {
                string nameOfGroup = group.Key;
                xElements.Add(new XElement(nameOfGroup, group.Select(i => i.PartialXML)));                
            }

            Utils.saveToXML("GroupedByTransmission", "groupedByTransmission", xElements.ToArray());

        }
    }
}