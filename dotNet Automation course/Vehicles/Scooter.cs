using dotNet_Automation_course.VehicleParts;

namespace dotNet_Automation_course.Vehicles
{
    class Scooter : Vehicle
    {
        public bool HasPhoneHolder
        {
            get; set; 
        } 
        public Scooter(bool hasPhoneHolder, string name = "Scooter", string model ="ScooterModel") 
            : base(name, model, new Engine(4.9, 0.8, "Scooter", "zxcvb"), new Chassis(8, "OPASD", 100), new Transmission("zxcvb", 6, "Scooter transmission Company"))
        {
            HasPhoneHolder = hasPhoneHolder;
            AdditionalInfo = $"The scooter {(HasPhoneHolder ? "has" : "doesn't have")} a phone holder.";
        }
    }
}
