
using dotNet_Automation_course;
using dotNet_Automation_course.Commands;

class SeventhTask
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the brand, model, price and quantity of cars you want to add to the list");
        string? input = Console.ReadLine();

        String[] result = input.Split(" ");
        CarPark.GetInstance().AddCar(new Car(result[0], result[1], Int32.Parse(result[2])), Int32.Parse(result[3]));



        while (true)
        {
            Console.WriteLine("What do you want to do now? \n" +
            "Write 0 to add more cars, 1 to go to commands or exit to exit the application.");
            input = Console.ReadLine();
            if (input.Equals("exit"))
            {
                break;
            }
            else
            { 
                if (Int32.Parse(input) == 0)
                {
                    Console.WriteLine("Write the brand, model, price and quantity of cars you want to add to the list");
                    input = Console.ReadLine();
                    String[] carParams = input.Split(" ");
                    CarPark.GetInstance().AddCar(new Car(carParams[0], carParams[1], Int32.Parse(carParams[2])), Int32.Parse(carParams[3]));
                } 
                else if (Int32.Parse(input) == 1)
                {
                    Console.WriteLine("What command do you want to execute?");
                    input = Console.ReadLine();
                    ICommand command;

                    switch (input)
                    {
                        case "Count all":
                            command = new CountAllCommand(CarPark.GetInstance());
                            break;
                        case "Count types":
                            command = new CountTypesCommand(CarPark.GetInstance());
                            break;
                        case "Average price":
                            command = new AvgPriceCommand(CarPark.GetInstance());
                            break;
                        case "Average price type":
                            Console.WriteLine("For which brand do you want to get average price?");
                            string? brand = Console.ReadLine();
                            command = new AvgPricePerBrandCommand(CarPark.GetInstance(),brand);
                            break;
                        default:
                            command = null;
                            break;
                    }
                    if (command != null)
                    {
                        Console.WriteLine(command.Execute());
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        
        /*
        CarPark carPark = CarPark.GetInstance();

        carPark.AddCar(new Car("Citroen", "C4 Picasso", 23456),2);
        carPark.AddCar(new Car("Fiat", "125p", 123), 1);
        carPark.AddCar(new Car("Volvo", "ABC", 567), 3);

        Console.WriteLine(carPark.CountAll());

        CarPark carPark2 = CarPark.GetInstance();

        carPark2.AddCar(new Car("Opel", "Astra", 888), 1);

        Console.WriteLine(carPark2.CountAll());
        */

    }
}