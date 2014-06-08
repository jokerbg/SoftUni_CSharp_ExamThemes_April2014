using System;
class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();
        string[] numbers = input.Split(' ');
        ulong current = 0;
        ulong totalSum = 0;
        decimal diff = 0;
        decimal diffMin = Int64.MaxValue;
        bool difference = true;

        if (numbers.Length == 2)
        {
            if (numbers[0] == numbers[1])
            {
                Console.WriteLine("Yes, sum={0}", numbers[0]);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(int.Parse(numbers[0]) - int.Parse(numbers[1])));
            }
        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                totalSum += ulong.Parse(numbers[i]);
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                current = ulong.Parse(numbers[j]);
                if (ulong.Parse(numbers[j]) * 2 == totalSum)
                {
                    difference = false; break;
                }
                else
                {
                    diff = Math.Abs((2 * current - (decimal)totalSum < 0) ? (decimal)totalSum - 2 * current : (2 * current - (decimal)totalSum));
                    if (diff < diffMin)
                    {
                        diffMin = diff;
                    }
                }
            }

            if (difference)
            {
                Console.WriteLine("No, diff={0}", diffMin);
            }
            else
            {
                Console.WriteLine("Yes, sum={0}", current);
            }
        }
    }
}