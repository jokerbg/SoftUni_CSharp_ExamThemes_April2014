using System;
class OddEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int oddJump = Int32.Parse(Console.ReadLine());
        int evenJump = Int32.Parse(Console.ReadLine());
        string newStr = input.Trim().Replace(" ", "");
        string oddStr = "";
        string evenStr = "";
        ulong oddSum = 0;
        ulong evenSum = 0;

        for (int i = 0; i < newStr.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddStr += newStr[i];
            }
            else
            {
                evenStr += newStr[i];
            }
        }
        for (int i = 0; i < oddStr.Length; i++)
        {
            if ((i + 1) % oddJump == 0)
            {
                oddSum *= (ulong)(oddStr[i]);
            }
            else
            {
                oddSum += (ulong)(oddStr[i]);
            }
        }

        for (int i = 0; i < evenStr.Length; i++)
        {
            if ((i + 1) % evenJump == 0)
            {
                evenSum *= (ulong)(evenStr[i]);
            }
            else
            {
                evenSum += (ulong)(evenStr[i]);
            }
        }
        Console.WriteLine("Odd: {0}", oddSum.ToString("X"));
        Console.WriteLine("Even: {0}", evenSum.ToString("X"));
    }
}