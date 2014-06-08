using System;
using System.Collections.Generic;
using System.Text;
class BitRoller
{
    static void Main()
    {
        string entry = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(19, '0');

        int fixedPos = int.Parse(Console.ReadLine());
        int roll = int.Parse(Console.ReadLine());

        List<int> matrix = new List<int>();

        for (int j = 0; j < 19; j++)
        {
            matrix.Add(entry[j] - '0');
        }

        int fixedBit = matrix[19 - fixedPos - 1];
        int newFirstBit = 0;

        matrix.RemoveAt(19 - fixedPos - 1);

        for (int i = 0; i < roll; i++)
        {
            newFirstBit = matrix[17];

            for (int j = 17; j > 0; j--)
            {
                matrix[j] = matrix[j - 1];
            }
            matrix[0] = newFirstBit;

        }
        matrix.Insert(18 - fixedPos, fixedBit);
        matrix.ToArray();

        StringBuilder builder = new StringBuilder();
        foreach (int value in matrix)
        {
            builder.Append(value.ToString());
        }
        Console.WriteLine(Convert.ToInt32(builder.ToString(), 2));
    }
}