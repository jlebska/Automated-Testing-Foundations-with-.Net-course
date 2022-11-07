﻿using dotNet_Automation_course.VehicleParts;
using System.Xml.Linq;

namespace dotNet_Automation_course.Vehicles
{
    abstract class Vehicle
    {
        public string Name
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
                    Engine.PartialXML,
                    Chassis.PartialXML,
                    Transmission.PartialXML,
                    new XElement("AdditionalInfo", AdditionalInfo)
                    );
            }
        }

        virtual public void printDescription()
        {
            Console.WriteLine($"The vehicle type is {Name}.\n" +
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

        public Vehicle(string name, Engine engine, Chassis chassis, Transmission transmission)
        {
            Name = name;
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }
   
    }
}
