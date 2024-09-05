using calculator_hw.Enums;

namespace calculator_hw.Classes
{
    public class InputTokenizer
    {
        public static List<string> Tokenize(string input)
        {
            var tokens = new List<string>();
            string number = "";
            bool isPreviousCharOperator = true;
            int minusCount = 0;

            foreach (char c in input)
            {
                Console.WriteLine($"processing: {c}");

                if (char.IsDigit(c) || (c == '.' || c == ','))
                {
                    if (minusCount > 0)
                    {
                        if (isPreviousCharOperator)
                        {
                            number += '-';
                            Console.WriteLine("adding minus sign to number");
                        }
                        minusCount = 0;
                    }

                    number += c;
                    isPreviousCharOperator = false;
                }
                else if (c == '-')
                {
                    if (isPreviousCharOperator)
                    {
                        minusCount++;
                        Console.WriteLine($"minus count is : {minusCount}");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(number))
                        {
                            tokens.Add(number);
                            Console.WriteLine($"adding number: {number}");
                            number = "";
                        }

                        tokens.Add(c.ToString());
                        Console.WriteLine($"adding operator: {c}");
                        isPreviousCharOperator = true;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        tokens.Add(number);
                        Console.WriteLine($"adding number: {number}");
                        number = "";
                    }

                    if (Enum.IsDefined(typeof(Operators), (int)c))
                    {
                        if (!isPreviousCharOperator)
                        {
                            tokens.Add(c.ToString());
                            Console.WriteLine($"adding operator/parens: {c}");
                        }
                        minusCount = 0;
                        isPreviousCharOperator = true;
                    }
                }
            }
            if (!string.IsNullOrEmpty(number))
            {
                tokens.Add(number);
                Console.WriteLine($"adding last number: {number}");
            }

            return tokens;
        }
    }
}