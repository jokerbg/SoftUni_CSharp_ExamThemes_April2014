using System;
class Pairs
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();
        string[] numbers = input.Split(' ');
        int sum = int.Parse(numbers[0]) + int.Parse(numbers[1]);
        int tempoSum = 0;
        int diff = 0;
        int diffMax = 0;
        bool difference = false;

        if (numbers.Length == 2)
        {
            Console.WriteLine("Yes, value={0}", sum);
        }
        else
        {
            for (int i = 2; i < numbers.Length; i += 2)
            {
                tempoSum = int.Parse(numbers[i]) + int.Parse(numbers[i + 1]);
                if (tempoSum != sum)
                {
                    diff = Math.Abs(tempoSum - sum);
                    if (diff > diffMax)
                    {
                        diffMax = diff;
                    }
                    sum = tempoSum;
                    difference = true;
                }
            }
            if (difference)
            {
                Console.WriteLine("No, maxdiff={0}", diffMax);
            }
            else
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
        }
    }
}