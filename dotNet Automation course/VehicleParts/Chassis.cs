
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

        public Chassis(int wheelsNumber, string number, double permisiveLoad)
        {
            WheelsNumber = wheelsNumber;
            Number = number;
            PermissiveLoad = permisiveLoad;
        }
    }
}
