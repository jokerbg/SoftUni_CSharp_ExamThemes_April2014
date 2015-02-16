using System;
class ByteParty
{
    static void Main()
    {
        int numbers = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[numbers, 8];

        string[] topArr = new string[8];
        for (int i = 0; i < numbers; i++)
        {
            topArr[i] = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            for (int j = 0; j < 8; j++)
            {
                matrix[i, j] = topArr[i][j] == '0' ? 0 : 1;
            }
        }

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "party over") break;

            string[] entries = input.Split(' ');
            string command = entries[0];
            int index = int.Parse(entries[1]);

            for (int i = 0; i < numbers; i++)
            {
                if (command == "-1")
                {
                    matrix[i, 7 - index] = (matrix[i, 7 - index] == 0) ? 1 : 0;
                }
                else if (command == "0")
                {
                    matrix[i, 7 - index] = 0;
                }
                else
                {
                    matrix[i, 7 - index] = 1;
                }
            }

        }

        for (int i = 0; i < numbers; i++)
        {
            string tempo = "";
            for (int j = 0; j < 8; j++)
            {
                tempo += matrix[i, j];
            }
            Console.WriteLine(Convert.ToInt32(tempo, 2));
        }
    }
}