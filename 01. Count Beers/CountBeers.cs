using System;
class CountBeers
{
    static void Main()
    {
        long units = 0;
        long stacks = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            string[] entries = input.Split(' ');

            int count = int.Parse(entries[0]);
            string type = entries[1];
            units += (type == "beers") ? count : 20 * count;
        }

        stacks = units / 20;
        long beers = (stacks == 0) ? units : units % 20;

        Console.WriteLine("{0} stacks + {1} beers", stacks, beers);
    }
}