using System;
class PaintBall
{
    static void Main()
    {
        int[,] matrix = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = 1;
            }
        }
        string[] tempo = new string[3];
        int row, col, radius;
        int current = 0;
        int startX, startY, endX, endY;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            tempo = input.Split(' ');
            row = int.Parse(tempo[0]);
            col = int.Parse(tempo[1]);
            radius = int.Parse(tempo[2]);

            startX = (row - radius < 0) ? 0 : row - radius;
            startY = (col - radius < 0) ? 0 : col - radius;
            endX = (row + radius > 9) ? 9 : row + radius;
            endY = (col + radius > 9) ? 9 : col + radius;

            for (int i = startX; i <= endX; i++)
            {
                for (int j = startY; j <= endY; j++)
                {
                    matrix[i, j] = current;
                }
            }
            current = (current == 0) ? 1 : 0;
        }
        int result = 0;
        string tempoNew = "";
        for (int i = 0; i < 10; i++)
        {
            for (int j = 9; j >=0; j--)
            {
                tempoNew += matrix[i, j];
            }
            result+= Convert.ToInt32(tempoNew, 2);
            tempoNew = "";
        }
        Console.WriteLine(result);
    }
}