using System;
class StudentCables
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        int totalLen = 0;
        int cableUsed = 0;
        for (int i = 0; i < number; i++)
        {
            int cableLength = Int32.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if ((measure == "meters") || (measure == "meter"))
            {
                cableLength *= 100;
            }
            if (cableLength >= 20)
            {
                totalLen += cableLength;
                cableUsed++;
            }
        }
        int lossJoints = 3 * (cableUsed - 1);
        int ready = (totalLen - lossJoints) / 504;
        int residual = (totalLen - lossJoints) % 504;
        Console.WriteLine(ready);
        Console.WriteLine(residual);
    }
}