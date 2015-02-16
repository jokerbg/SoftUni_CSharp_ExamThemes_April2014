using System;
class BitLock
{
    public static int[,] matrix = new int[8, 12];
    static void PrintMatrix()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Main()
    {
        string[] entries = Console.ReadLine().Split(' ');
        string[] arr = new string[8];
        for (int i = 0; i < 8; i++)
        {
            arr[i] = Convert.ToString(int.Parse(entries[i]), 2).PadLeft(12, '0');
            for (int j = 0; j < 12; j++)
            {
                matrix[i, j] = arr[i][j] - '0';
            }
        }

        while (true)
        {
            string tempo = Console.ReadLine();
            if (tempo == "end")
            {
                break;
            }
            string[] comms = tempo.Split(' ');

            if (comms.Length == 2)
            {
                int col = Int32.Parse(comms[1]);
                int sum = 0;
                for (int i = 0; i < 8; i++)
                {
                    sum += matrix[i, 11 - col];
                }
                Console.WriteLine(sum);
                //PrintMatrix();
            }
            else
            {
                int row = Int32.Parse(comms[0]);
                bool right = (comms[1] == "right");
                int moves = Int32.Parse(comms[2]) % 12;
                if (right)
                {
                    int hop = moves;
                    moves = 12 - hop;
                }
                int[] extended = new int[24];
                for (int i = 0; i < 24; i++)
                {
                    extended[i] = matrix[row, i % 12];
                }
                for (int j = 0; j < 12; j++)
                {
                    matrix[row, j] = extended[j + moves];
                }
            }
        }

        string result = "";
        string tempoNew = "";
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                tempoNew += matrix[i, j];
            }
            result += Convert.ToInt32(tempoNew, 2) + (i == 7 ? "" : " ");
            tempoNew = "";
        }
        Console.WriteLine(result);
        //PrintMatrix();
    }
}