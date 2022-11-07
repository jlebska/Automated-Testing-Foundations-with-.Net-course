
using System.Xml.Linq;

namespace dotNet_Automation_course.VehicleParts
{
    class Engine
    {
        public double Power
        {
            get;set;
        }

        public double Volume
        {
            get;set;
        }

        public string EngineType
        {
            get; set;
        }

        public string SerialNumber
        {
            get; set;
        }

        public XElement PartialXML
        {
            get 
            { 
                return new XElement("Engine",
                new XElement("Power", Power),
                new XElement("Volume", Volume),
                new XElement("EngineType", EngineType),
                new XElement("SerialNumber", SerialNumber)); 
            }
        }

        public Engine(double power, double volume, string engineType, string seialNumber)
        {
            Power = power;
            Volume = volume;
            EngineType = engineType;
            SerialNumber = seialNumber;
        }
    }
}
