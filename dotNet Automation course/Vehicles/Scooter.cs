using dotNet_Automation_course.VehicleParts;

namespace dotNet_Automation_course.Vehicles
{
    class Scooter : Vehicle
    {
        public bool HasPhoneHolder
        {
            get; set; 
        } 
        public Scooter(bool hasPhoneHolder, string name = "Scooter") 
            : base(name, new Engine(4.9, 10, "Scooter", "zxcvb"), new Chassis(8, "OPASD", 100), new Transmission("zxcvb", 6, "Scooter transmission Company"))
        {
            HasPhoneHolder = hasPhoneHolder;
        }

        public override void printDescription()
        {
            base.printDescription();
            Console.WriteLine($"The scooter {(HasPhoneHolder ? "has" : "doesn't have")} a phone holder. \n" +
                "-------------------------------------------------------------------------");
        }
    }
}
