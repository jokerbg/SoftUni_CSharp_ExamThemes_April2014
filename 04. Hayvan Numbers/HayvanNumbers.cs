using System;
class HayvanNumbers
{
    static void Main()
    {
        int sum = Int32.Parse(Console.ReadLine());
        int diff = Int32.Parse(Console.ReadLine());
        bool foundSolution = false;
        for (int abc = 555; abc <= 999; abc++)
        {
            int tempoSum = 0;
            int def = abc + diff;
            int ghi = def + diff;

            if (ghi <= 999)
            {
                string number = "" + abc + def + ghi;
                number.ToCharArray();

                for (int i = 0; i < 9; i++)
                {
                    if (number[i] - '0' < 5)
                    {
                        tempoSum = -1;
                        break;
                    }
                    tempoSum += number[i] - '0';
                }
                if (tempoSum == sum)
                {
                    Console.WriteLine(number);
                    foundSolution = true;
                }
            }
        }

        if (!foundSolution)
        {
            Console.WriteLine("No");
        }
    }
}