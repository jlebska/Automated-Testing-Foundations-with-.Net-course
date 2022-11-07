
using System.Xml.Linq;

namespace dotNet_Automation_course.VehicleParts
{
    class Transmission
    {
        public string TransmissionType
        {
            get; set;
        }

        public int NumberOfGears
        {
            get; set;
        }

        public string Manufacturer
        {
            get; set;
        }

        public XElement PartialXML
        {
            get
            {
                return new XElement("Transmission",
                    new XElement("TransmissionType", TransmissionType),
                    new XElement("NumberOfGears", NumberOfGears),
                    new XElement("Manufacturer", Manufacturer));
            }
        }

        public Transmission(string transmissionType, int numberOfGears, string manufacturer)
        {
            TransmissionType = transmissionType;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }
    }
}
