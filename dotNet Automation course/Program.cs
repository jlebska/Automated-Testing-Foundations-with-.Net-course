using dotNet_Automation_course;
public class EighthTask
{
    static void Main(string[] args)
    {
        string str;
        foreach (string arg in args)
        {
            str = arg.ToLower();
            CharCounter counter = new CharCounter();
            Console.WriteLine($"Max number of counted consecutive characters in \"{arg}\" is equal to {counter.CountUnequalChar(str)}.");
        }

    } 
}