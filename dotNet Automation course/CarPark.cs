namespace dotNet_Automation_course
{
    public class CarPark
    {
        private List<Car> cars;
        private static CarPark? _instance;

        private CarPark()
        {
            cars = new List<Car>();
        }
        
        public static CarPark GetInstance()
        {
            if(_instance == null)
            {
                _instance = new CarPark();
            }
            return _instance;

        }

        public void AddCar(Car car, int quantity=1)
        {
            for (int i = 0; i < quantity; i++)
            {
                cars.Add(car);
            }
        }

        public double CountTypes()
        {
            return cars.GroupBy(p=>p.Brand).Count();
        }

        public double CountAll()
        {
            return cars.Count();
        }

        public double AvgPrice()
        {
            return cars.Select(x => x.CostOfUnit).Average();
        }

        public double AvgPricePerBrand(string brand)
        {
            return cars.Where(x=>x.Brand.Equals(brand)).Select(x => x.CostOfUnit).Average();
        }
    }
}
