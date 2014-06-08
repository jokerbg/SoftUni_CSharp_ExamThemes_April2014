using System;
class Triangle
{
    static void Main()
    {
        double aX = double.Parse(Console.ReadLine());
        double aY = double.Parse(Console.ReadLine());
        double bX = double.Parse(Console.ReadLine());
        double bY = double.Parse(Console.ReadLine());
        double cX = double.Parse(Console.ReadLine());
        double cY = double.Parse(Console.ReadLine());

        double distAB = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY));
        double distAC = Math.Sqrt((aX - cX) * (aX - cX) + (aY - cY) * (aY - cY));
        double distBC = Math.Sqrt((bX - cX) * (bX - cX) + (bY - cY) * (bY - cY));

        if ((distAB + distAC > distBC) && (distAB + distBC > distAC) && (distBC + distAC > distAB))
        {
            double p = (distAB + distAC + distBC) / 2;
            double area = Math.Sqrt(p * (p - distAB) * (p - distAC) * (p - distBC));
            Console.WriteLine("Yes\n{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No\n{0:F2}", distAB);
        }
    }
}