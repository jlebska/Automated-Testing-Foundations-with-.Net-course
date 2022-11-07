using dotNet_Automation_course.VehicleParts;

namespace dotNet_Automation_course.Vehicles
{
    class Bus : Vehicle
    {
        public bool HasTicketMachine { 
            get; set; 
        }
        public Bus(bool hasTicketMachine, string name = "Bus")
            : base(name, new Engine(50, 100, "Bus", "qwerty"), new Chassis(8, "QWERFG", 20000),  new Transmission("zxcvb", 6, "Company Bus"))
        {
            HasTicketMachine = hasTicketMachine;
            AdditionalInfo = $"The bus {(HasTicketMachine ? "has" : "doesn't have")} a ticket machine.";
        }
    }
}
