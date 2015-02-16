using System;
class HalfByteSwapper
{
    static void PrintMatrix()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                string print = (j == 3) || (j == 7) || (j == 11) || (j == 15) || (j == 19) || (j == 23) || (j == 27) ? (matrix[i, j] + " | ") : (matrix[i, j] + " ");
                Console.Write(print);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void ConvertToAnswer()
    {

        for (int i = 0; i < 4; i++)
        {
            string line = "";
            for (int j = 0; j < 32; j++)
            {
                line += matrix[i, j];
            }
            Console.WriteLine(Convert.ToUInt32(line, 2));
        }
    }

    public static void Swapper(int x1, int y1, int x2, int y2)
    {
        int[] tempo = new int[4];
        for (int i = 0; i < 4; i++)
        {
            tempo[i] = matrix[x1, 31 - 4 * y1-i];
            matrix[x1, 31 - 4 * y1 - i] = matrix[x2, 31 - 4 * y2-i];
            matrix[x2, 31 - 4 * y2 - i] = tempo[i];
        }      
    }

    public static int[,] matrix = new int[4, 32];
    static void Main()
    {
        string[] arr = new string[4];
        for (int i = 0; i < 4; i++)
        {
            arr[i] = Convert.ToString(uint.Parse(Console.ReadLine()), 2).PadLeft(32, '0');
            for (int j = 0; j < 32; j++)
            {
                matrix[i, j] = arr[i][j] - '0';
            }
        }
        //PrintMatrix();

        while (true)
        {
            string lineone = Console.ReadLine();
            if (lineone == "End")
            {
                ConvertToAnswer();
                //PrintMatrix();
                return;
            }
            string linetwo = Console.ReadLine();
            string[] lineOneArr = lineone.Split(' ');
            string[] lineTwoArr = linetwo.Split(' ');
            Swapper(int.Parse(lineOneArr[0]), int.Parse(lineOneArr[1]), int.Parse(lineTwoArr[0]), int.Parse(lineTwoArr[1]));
        }
    }
}