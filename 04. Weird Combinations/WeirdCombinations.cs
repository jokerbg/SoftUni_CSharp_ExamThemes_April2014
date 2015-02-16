using System;
class WeirdCombinations
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] elements = input.ToCharArray();
        int counter = 0;
        bool noSolution = true;
        int target = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        for (int m = 0; m < 5; m++)
                        {
                            counter++;
                            if (counter == target + 1)
                            {
                                Console.WriteLine(ReturnCase(i, elements) + ReturnCase(j, elements) + ReturnCase(k, elements) + ReturnCase(l, elements) + ReturnCase(m, elements));
                                noSolution = false;
                                break;
                            }
                        }
                    }
                }
            }
        }
        if (noSolution)
        {
            Console.WriteLine("No");
        }
    }

    static string ReturnCase(int elem, char[] elements)
    {
        string alfa = "";
        switch (elem)
        {
            case 0: alfa = elements[0].ToString(); break;
            case 1: alfa = elements[1].ToString(); break;
            case 2: alfa = elements[2].ToString(); break;
            case 3: alfa = elements[3].ToString(); break;
            case 4: alfa = elements[4].ToString(); break;
            default: break;
        }
        return alfa;
    }
}