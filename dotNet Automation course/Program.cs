using System.Text;

class FirstTask
{
    static void Main(string[] args)
    {
        string str;
        foreach (string arg in args)
        {
            str = arg.ToLower();
            Console.WriteLine($"Max number of unequal consecutive characters in \"{arg}\" is equal to {CountUnequalChar(str)}.");
        }

    }

    static string DeletePunctuationAndSpaces(string str)
    {
        var sb = new StringBuilder();
        foreach (char ch in str)
        {
            if (!char.IsPunctuation(ch) && !char.IsWhiteSpace(ch))
                sb.Append(ch);
        }
        return sb.ToString();
    }

    static int CountUnequalChar(string str)
    {
        string input = DeletePunctuationAndSpaces(str);
        int count = 1;
        int max = 1;

        for(int i = 1; i < input.Length; i++)
        {
            if (input.Length > 1)
            {
                if (input[i - 1] != input[i])
                {
                    count++;
                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                    }
                    count = 1;
                }
            }
        }
        return max >= count ? max : count;
    }
}