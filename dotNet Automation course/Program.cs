using System.Text;

class FirstTask
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Not enough numbers provided. Start the program again while prowiding a decimal number and a new base in the range 2-20");
        }
        else
        {
            int decimalValue;
            bool isDecimalValue = Int32.TryParse(args[0], out decimalValue);
            int newBase;
            bool isNewBase = Int32.TryParse(args[1], out newBase);

            if (isNewBase && isDecimalValue)
            {

                if (newBase < 2 || newBase > 20)
                {
                    Console.WriteLine("The base provided is out of range. Provide a number between 2 and 20.");
                }
                else
                {
                    Console.WriteLine($"Changing {decimalValue} to a {newBase} based number system");
                    Console.WriteLine("----------------------------------------------------------");

                    Console.WriteLine($"The {decimalValue} number in a {newBase} based number system is {ChangeBase(decimalValue, newBase)}.");
                }

            }
            else
            {
                Console.WriteLine("Numbers provided are invalid. Try again");
            }
        }

    }

    static string ChangeBase(int decimalValue, int newBase)
    {
        string digits = "0123456789ABCDEFGIJKL";
        int currentNumber = Math.Abs(decimalValue);
        StringBuilder sb = new StringBuilder();

        while(currentNumber != 0)
        {
            int remainder = currentNumber % newBase;
            sb.Insert(0, digits[remainder]);
            currentNumber = currentNumber / newBase;

        }

        return decimalValue >0 ? sb.ToString() : $"-{sb.ToString()}";
        
    }
}