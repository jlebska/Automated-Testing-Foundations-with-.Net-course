
using dotNet_Automation_course;
using dotNet_Automation_course.Commands;

class SeventhTask
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the brand, model, price and quantity of cars you want to add to the list or type \"exit\" to exit application.");

        string? input = Console.ReadLine(); ;

        bool success = CarPark.GetInstance().AddCar(input);

        if (!success)
        {
            Environment.Exit(0);
        }

        Console.WriteLine("What do you want to do now? \n" +
        "Write 0 to add more cars, 1 to go to commands or type \"exit\" to exit the application.");
        input = Console.ReadLine();

        while (true)
        {
            if (input.Equals("exit"))
            {
                Environment.Exit(0);
            }
            else
            {
                success = Int32.TryParse(input, out int parsedInput);
                if (success)
                {
                    if (parsedInput == 0)
                    {
                        Console.WriteLine("Write the brand, model, price and quantity of cars you want to add to the list or type \"exit\" to exit application.");
                        input = Console.ReadLine();
                        success = CarPark.GetInstance().AddCar(input);

                        if (!success)
                        {
                            Environment.Exit(0);
                        }
                    }
                    else if (parsedInput == 1)
                    {
                        Console.WriteLine("What command do you want to execute?\n" +
                            "Write \"Count all\" to get the number of all cars in the list,\n" +
                            "Write \"Count types\" to get the number of all brands of cars in the list,\n" +
                            "Write \"Average price\" to get the average price of cars in the list\n" +
                            "Write \"Average price type\" to get the average price for a given brand of the car\n" +
                            "and in the next step provide the brand name.\n" +
                            "To exit the application write \"exit\".");
                        input = Console.ReadLine();
                        Invoker invoker = new Invoker();
                        bool isCommandSet = false;

                        switch (input)
                        {
                            case "Count all":
                                invoker.SetCommand(new CountAllCommand(CarPark.GetInstance()));
                                isCommandSet = true;
                                break;
                            case "Count types":
                                invoker.SetCommand(new CountTypesCommand(CarPark.GetInstance()));
                                isCommandSet = true;
                                break;
                            case "Average price":
                                invoker.SetCommand(new AvgPriceCommand(CarPark.GetInstance()));
                                isCommandSet = true;
                                break;
                            case "Average price type":

                                Console.WriteLine("For which brand do you want to get average price?\n" +
                                    "The brands in the list are:");
                                List<string> brands = CarPark.GetInstance().GetBrands();
                                foreach(string brand in brands)
                                {
                                    Console.WriteLine(brand);
                                }
                                string? choosenBrand = Console.ReadLine();
                                if (choosenBrand.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    Environment.Exit(0);
                                }
                                else if (brands.Contains(choosenBrand))
                                {
                                    invoker.SetCommand(new AvgPricePerBrandCommand(CarPark.GetInstance(), choosenBrand));
                                    isCommandSet = true;
                                }
                                else
                                {
                                    Console.WriteLine("Choosen brand doesn't exist in the list");
                                    input = "1";
                                }
                                break;
                            case "exit":
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Non existent command\n" +
                                    "Write a valid one");
                                input = "1";
                                break;
                        }
                        if (isCommandSet)
                        {
                            Console.WriteLine(invoker.ExecuteCommand());
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, provide a valid one");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input, provide a valid one");
                }
            }
            Console.WriteLine("What do you want to do now? \n" +
            "Write 0 to add more cars, 1 to go to commands or \"exit\" to exit the application.");
            input = Console.ReadLine();
        }
    }
}