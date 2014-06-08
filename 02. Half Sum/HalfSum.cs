using System;
class HalfSum
{
    static void Main()
    {
        int sumOne = 0, sumTwo = 0;
        int numbers = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < numbers; i++)
        {
            sumOne += Int32.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers; i++)
        {
            sumTwo += Int32.Parse(Console.ReadLine());
        }

        int diff = sumOne - sumTwo;
        if (diff == 0)
        {
            Console.WriteLine("Yes, sum={0}", sumOne); return;
        }
        
        if (diff < 0)
        {
            diff *= (-1);
        }
        Console.WriteLine("No, diff={0}", diff);
    }
}