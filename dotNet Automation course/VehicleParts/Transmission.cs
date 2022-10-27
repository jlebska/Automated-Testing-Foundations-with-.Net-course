
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

        public Transmission(string transmissionType, int numberOfGears, string manufacturer)
        {
            TransmissionType = transmissionType;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }
    }
}
