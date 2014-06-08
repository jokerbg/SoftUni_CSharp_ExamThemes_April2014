using System;
class FriendBits
{
    static void Main()
    {
        int w1 = Int32.Parse(Console.ReadLine());
        int h1 = Int32.Parse(Console.ReadLine());
        int d1 = Int32.Parse(Console.ReadLine());
        int w2 = Int32.Parse(Console.ReadLine());
        int h2 = Int32.Parse(Console.ReadLine());
        int d2 = Int32.Parse(Console.ReadLine());

        if (w1 < w2 && h1 < h2 && d1 < d2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, h2, d2);
        }
        if (w1 < w2 && h1 < d2 && d1 < h2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, d2, h2);
        }
        if (w1 < h2 && h1 < w2 && d1 < d2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, h2, w2, d2);
        }
        if (w1 < h2 && h1 < d2 && d1 < w2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, h2, w2, d2);
        }
        if (w1 < d2 && h1 < h2 && d1 < w2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, h2, d2);
        }
        if (w1 < d2 && h1 < w2 && d1 < h2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, h2, d2);
        }


    }
}