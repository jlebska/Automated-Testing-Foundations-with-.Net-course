using System.Diagnostics.Metrics;

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

        public bool AddCar(string input)
        {
            bool success = false;
            int counter = 0;
            while (!success && counter < 3)
            {
                if (input.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                try
                {
                    String[] result = input.Split(" ");
                    Car car = new Car(result[0], result[1], Int32.Parse(result[2]));
                    for (int i = 0; i < Int32.Parse(result[3]); i++)
                    {
                        cars.Add(car);
                    }
                    success = true;
                }
                catch (Exception ex) when (ex is FormatException || ex is IndexOutOfRangeException)
                {
                    counter++;
                    Console.WriteLine("Wrong input \n" +
                        "Write the brand, model, price and quantity of cars you want to add to the list, separating the values by spaces");
                    input = Console.ReadLine();
                }
            }
            return success;
        }

        public List<string> GetBrands()
        {
            return cars.Select(c => c.Brand).Distinct().ToList();
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
