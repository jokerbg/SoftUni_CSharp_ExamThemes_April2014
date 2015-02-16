using System;
class BitCopy
{
    static void Main()
    {
        int[] matrix = new int[32];

        string inputStr = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(32, '0');
        for (int j = 0; j < 32; j++)
        {
            matrix[j] = inputStr[31 - j] - '0';
        }
        int position = Int32.Parse(Console.ReadLine());
        if (position != 2)
        {
            matrix[2] = matrix[position];
        }

        string line = "";
        for (int j = 31; j >= 0; j--)
        {
            line += matrix[j];
        }
        Console.WriteLine(Convert.ToInt32(line, 2));
    }
}