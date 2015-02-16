using System;
class Tables
{
    static void Main()
    {
        long bund1 = long.Parse(Console.ReadLine());
        long bund2 = long.Parse(Console.ReadLine());
        long bund3 = long.Parse(Console.ReadLine());
        long bund4 = long.Parse(Console.ReadLine());
        long tops = long.Parse(Console.ReadLine());
        long needed = long.Parse(Console.ReadLine());

        long legs = bund1 + bund2 * 2 + bund3 * 3 + bund4 * 4;
        long tablesMade = 0;
        if (legs/4>=tops)
        {
            tablesMade = tops;
        }
        else
        {
            tablesMade = legs / 4;
        }

        if (tablesMade == needed)
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }
        else if (tablesMade > needed)
        {
            Console.WriteLine("more: {0}", tablesMade - needed);
            Console.WriteLine("tops left: {0}, legs left: {1}", tablesMade - needed, legs - 4 * needed);
        }
        else
        {
            Console.WriteLine("less: {0}", tablesMade - needed);
            if (4 * needed - legs < 0)
            {
                Console.WriteLine("tops needed: {0}, legs needed: 0", needed - tablesMade);
            }
            else
            {
                Console.WriteLine("tops needed: {0}, legs needed: {1}", needed - tops, 4 * needed - legs);
            }
        }
    }
}