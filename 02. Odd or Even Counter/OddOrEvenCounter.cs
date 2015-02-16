using System;
class OddOrEvenCounter
{
    static void Main()
    {
        int sets = Int32.Parse(Console.ReadLine());
        int perset = Int32.Parse(Console.ReadLine());
        string evenOdd = Console.ReadLine();
        string ordinal = "";
        int tempSet = 1;
        int maxSet = 1;
        int tempcounter = 0;
        int counter = 0;
        bool isEven = (evenOdd == "even" ? true : false);

        for (int i = 0; i < sets; i++)
        {
            for (int j = 0; j < perset; j++)
            {
                int tempo = Int32.Parse(Console.ReadLine());
                if ((isEven && tempo % 2 == 0) || (!isEven && tempo % 2 == 1))
                {
                    tempcounter++;
                }
            }
            if (tempcounter > counter)
            {
                counter = tempcounter;
                maxSet = tempSet;
            }
            tempcounter = 0;
            tempSet++;
        }

        switch (maxSet)
        {
            case 1: ordinal = "First"; break;
            case 2: ordinal = "Second"; break;
            case 3: ordinal = "Third"; break;
            case 4: ordinal = "Fourth"; break;
            case 5: ordinal = "Fifth"; break;
            case 6: ordinal = "Sixth"; break;
            case 7: ordinal = "Seventh"; break;
            case 8: ordinal = "Eighth"; break;
            case 9: ordinal = "Ninth"; break;
            case 10: ordinal = "Tenth"; break;
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", ordinal, evenOdd, counter);
        }
    }
}