namespace dotNet_Automation_course
{
    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int CostOfUnit { get; set; }

        public Car(string brand, string model, int costOfUnit)
        {
            Brand = brand;
            Model = model;
            CostOfUnit = costOfUnit;
        }
    }
}
