using dotNet_Automation_course.VehicleParts;
using System.Xml;
using System.Xml.Linq;

namespace dotNet_Automation_course.Vehicles
{
    class PassengerCar : Vehicle
    {
        public int TrunkVolume
        {
            get; set;
        }

        public PassengerCar(int trunkVolume, string name = "PassengerCar")
            :base(name, new Engine(12.0, 18.0, "Passenger", "123567"), new Chassis(4, "45678", 2000), new Transmission("zxcvb", 6, "Company"))
        {
            TrunkVolume = trunkVolume;
            AdditionalInfo = $"Trunk volume for the car is equal to {TrunkVolume}.";
        }
    }
}
