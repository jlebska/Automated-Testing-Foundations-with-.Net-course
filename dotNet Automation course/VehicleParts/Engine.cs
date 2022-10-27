
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

        public Engine(double power, double volume, string engineType, string seialNumber)
        {
            Power = power;
            Volume = volume;
            EngineType = engineType;
            SerialNumber = seialNumber;
        }
    }
}
