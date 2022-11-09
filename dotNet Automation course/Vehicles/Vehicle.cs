using dotNet_Automation_course.CustomExceptions;
using dotNet_Automation_course.VehicleParts;
using System.Xml.Linq;

namespace dotNet_Automation_course.Vehicles
{
    public abstract class Vehicle
    {
        public string Name
        {
            get; set;
        }

        public string Model
        {
            get; set;
        }

        public Engine Engine
        {
            get; set;
        }

        public Chassis Chassis
        {
            get; set;
        }

        public Transmission Transmission
        {
            get; set;
        }

        public string AdditionalInfo
        {
            get; set;
        }

        public XElement PartialXML
        {
            get
            {
                return new XElement(
                    Name,
                    Model,
                    Engine.PartialXML,
                    Chassis.PartialXML,
                    Transmission.PartialXML,
                    new XElement("AdditionalInfo", AdditionalInfo)
                    );
            }
        }

        virtual public void printDescription()
        {
            Console.WriteLine($"The vehicle type is {Name} {Model}.\n" +
                $"The parameter of its engine are: \n" +
                $"- engine type: {Engine.EngineType},\n" +
                $"- power: {Engine.Power},\n" +
                $"- volume: {Engine.SerialNumber}. \n" +
                $"The parameters of its chassis are: \n" +
                $"- number of wheels: {Chassis.WheelsNumber}, \n" +
                $"- number: {Chassis.Number}, \n" +
                $"- permissive load: {Chassis.PermissiveLoad}. \n" +
                $"The parameters of its transmission are: \n" +
                $"- type: {Transmission.TransmissionType}, \n" +
                $"- number of gears: {Transmission.NumberOfGears}, \n" +
                $"- manufacturer: {Transmission.Manufacturer}, \n" +
                $"{AdditionalInfo}.");
        }

        public Vehicle(string name, string model, Engine engine, Chassis chassis, Transmission transmission)
        {
            if (name == null || model == null)
            {
                throw new InitializationException($"Intialization impossible, because parameter {(name == null ? "name" : "model")} is null"); //TODO
            }
            Name = name;
            Model = model;
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }
   
    }
}
