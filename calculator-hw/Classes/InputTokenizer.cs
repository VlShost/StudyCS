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
            bool hasDot = false;
            int minusCount = 0;

            foreach (char c in input)
            {
                Console.WriteLine($"processing: {c}");

                if (char.IsDigit(c))
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
                else if (c == '.' || c == ',')
                {
                    if (!hasDot && number.Length > 0)
                    {
                        number += '.';
                        hasDot = true;
                        isPreviousCharOperator = false;
                    }
                    else
                    {
                        Console.WriteLine("ignoring extra or invalid decimal point/comma");
                    }
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
                            hasDot = false;
                        }

                        tokens.Add(c.ToString());
                        Console.WriteLine($"adding operator: {c}");
                        isPreviousCharOperator = true;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(number) && !(hasDot && number.EndsWith(".")))
                    {
                        tokens.Add(number);
                        Console.WriteLine($"adding number: {number}");
                        number = "";
                        hasDot = false;
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