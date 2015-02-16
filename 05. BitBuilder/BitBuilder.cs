using System;
using System.Collections.Generic;
class BitBuilder
{
    static void PrintMatrix()
    {
        for (int j = 63; j >= 0; j--)
        {
            string print = (j % 4 == 0) ? (list[j] + " ") : (list[j] + "");
            Console.Write(print);
        }
        Console.WriteLine();
    }
    public static void ConvertResult()
    {
        string line = "";
        for (int j = 63; j >= 0; j--)
        {
            line += list[j];
        }
        Console.WriteLine(Convert.ToUInt64(line, 2));
    }

    public static List<int> list = new List<int>();
    static void Main()
    {
        int position = 0;
        string command = "";
        string check = "";

        string inputStr = Convert.ToString(uint.Parse(Console.ReadLine()), 2).PadLeft(64, '0');
        for (int j = 0; j < 64; j++)
        {
            list.Add(inputStr[63 - j] - '0');
        }
        PrintMatrix();

        while (true)
        {
            check = (Console.ReadLine());
            if (check == "quit")
            {
                ConvertResult();
                PrintMatrix();
                return;
            }
            else
            {
                position = int.Parse(check);
            }
            command = Console.ReadLine();

            if (command == "flip")
            {
                list[position] = (list[position] == 1) ? 0 : 1;
            }
            else if (command == "remove")
            {
                list.RemoveAt(position);
                list.Add(0);
            }
            else if (command == "insert")
            {
                list.Insert(position, 1);
            }
            PrintMatrix();
        }
    }
}