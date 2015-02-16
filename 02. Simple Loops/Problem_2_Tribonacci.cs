using System;
using System.Numerics;
class Problem_2_Tribonacci
{
    static void Main()
    {
        BigInteger trib1 = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger trib2 = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger trib3 = new BigInteger(int.Parse(Console.ReadLine()));
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
            Console.WriteLine(trib1);
        else if (n == 2)
            Console.WriteLine(trib2);
        else if (n == 3)
            Console.WriteLine(trib3);
        else
        {
            for (int i = 4; i <= n; i++)
            {
                BigInteger tribNew = trib1 + trib2 + trib3;
                trib1 = trib2;
                trib2 = trib3;
                trib3 = tribNew;
            }
            Console.WriteLine(trib3);
        }
    }
}