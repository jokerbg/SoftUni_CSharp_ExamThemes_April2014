using System;
class InsideTheBuilding
{
    static void Main()
    {
        int h = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < 5; i++)
        {
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());

            if ((x >= 0 && x <= 3 * h && y >= 0 && y <= h) || (x >= h && x <= 2 * h && y >= 0 && y <= 4 * h))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}