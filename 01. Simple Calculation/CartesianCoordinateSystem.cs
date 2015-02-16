using System;
class CartesianCoordinateSystem
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        if (x >= -2000000000001337 && x <= 2000000000001337 && y >= -2000000000001337 && y <= 2000000000001337)
        {
            if (x == 0 && y == 0)
            {
                Console.WriteLine(0);
            }
            else if (x == 0)
            {
                Console.WriteLine(5);
            }
            else if (y == 0)
            {
                Console.WriteLine(6);
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine(1);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine(4);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine(2);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine(3);
            }
        }
    }
}