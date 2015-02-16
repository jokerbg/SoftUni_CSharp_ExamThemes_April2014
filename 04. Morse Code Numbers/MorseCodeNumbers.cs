using System;
class MorseCodeNumbers
{
    static void PrintMorse(string morseStr)
    {
        for (int i = 0; i < 6; i++)
        {
            char current = morseStr[i];
            switch (current)
            {
                case '1': Console.Write(".----|"); break;
                case '2': Console.Write("..---|"); break;
                case '3': Console.Write("...--|"); break;
                case '4': Console.Write("....-|"); break;
                case '5': Console.Write(".....|"); break;
                case '0': Console.Write("-----|"); break;
                default: break;
            }
        }
        return;
    }
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        bool noMorses = true;
        int nSum = n % 10 + n / 10 % 10 + n / 100 % 10 + n / 1000;
        int morseProduct = (n % 10) * (n / 10 % 10) * (n / 100 % 10) * (n / 1000);

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                for (int k = 0; k < 6; k++)
                {
                    for (int l = 0; l < 6; l++)
                    {
                        for (int m = 0; m < 6; m++)
                        {
                            for (int o = 0; o < 6; o++)
                            {
                                if (i * j * k * l * m * o == nSum)
                                {
                                    string morseStr = "" + i + j + k + l + m + o;
                                    PrintMorse(morseStr);
                                    Console.WriteLine();
                                    noMorses = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (noMorses)
        {
            Console.WriteLine("No");
        }
    }
}