using System;
class OddEvenSum
{
    static void Main()
    {
        int sumOdd = 0;
        int sumEven = 0;
        int number = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < number * 2; i++)
        {
            int tempo = Int32.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                sumOdd += tempo;
            }
            else
            {
                sumEven += tempo;
            }
        }
        if (sumEven==sumOdd)
        {
            Console.WriteLine("Yes, sum={0}", sumOdd);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumOdd-sumEven));
        }
    }
}