using System.Text;

namespace dotNet_Automation_course
{
    public class CharCounter
    {
        private string DeletePunctuationAndSpaces(string str)
        {
            var sb = new StringBuilder();
            foreach (char ch in str)
            {
                if (!char.IsPunctuation(ch) && !char.IsWhiteSpace(ch))
                    sb.Append(ch);
            }
            return sb.ToString();
        }

        public int CountUnequalChar(string str)
        {
            string input = DeletePunctuationAndSpaces(str);
            if(input.Length == 0) { return 0; }
            int count = 1;
            int max = 1;

            for (int i = 1; i < input.Length; i++)
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

        public int CountEqualLetters(string str)
        {
            string input = DeletePunctuationAndSpaces(str);
            string cleanInput = new string(input.Where(Char.IsLetter).ToArray());
            if(cleanInput.Length == 0) { return 0; }
            int count = 1;
            int max = 1;

            for (int i = 1; i < cleanInput.Length; i++)
            {
                if (cleanInput.Length > 1)
                {
                    if (cleanInput[i - 1] == cleanInput[i])
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

        public int CountEqualDigits(string str)
        {
            string input = DeletePunctuationAndSpaces(str);
            string cleanInput = new string(input.Where(Char.IsDigit).ToArray());
            if (cleanInput.Length == 0) { return 0; }
            int count = 1;
            int max = 1;

            for (int i = 1; i < cleanInput.Length; i++)
            {
                if (cleanInput.Length > 1)
                {
                    if (cleanInput[i - 1] == cleanInput[i])
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
}
