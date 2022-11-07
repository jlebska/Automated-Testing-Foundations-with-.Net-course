
using System.Xml.Linq;

namespace dotNet_Automation_course.VehicleParts
{
    class Chassis
    {
        public int WheelsNumber
        {
            get;set;
        }

        public string Number
        {
            get; set;
        }

        public double PermissiveLoad
        {
            get; set; 
        }

        public XElement PartialXML
        {
            get {
                return new XElement("Chassis",
                new XElement("WheelsNumber", WheelsNumber),
                new XElement("Number", Number),
                new XElement("PermissiveLoad", PermissiveLoad));
            }
        }

        public Chassis(int wheelsNumber, string number, double permisiveLoad)
        {
            WheelsNumber = wheelsNumber;
            Number = number;
            PermissiveLoad = permisiveLoad;
        }
    }
}
