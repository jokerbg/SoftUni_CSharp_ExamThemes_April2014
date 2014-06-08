using System;
class PokerStraight
{
    static void Main()
    {
        int target = Int32.Parse(Console.ReadLine());
        int tempo = 0;
        int counter = 0;

        for (int i = 1; i <= 10; i++)
        {
            for (int suit1 = 1; suit1 <= 4; suit1++)
            {
                for (int suit2 = 1; suit2 <= 4; suit2++)
                {
                    for (int suit3 = 1; suit3 <= 4; suit3++)
                    {
                        for (int suit4 = 1; suit4 <= 4; suit4++)
                        {
                            for (int suit5 = 1; suit5 <= 4; suit5++)
                            {
                                tempo = 10 * i + suit1 + 20 * (i + 1) + suit2 + 30 * (i + 2) + suit3 + 40 * (i + 3) + suit4 + 50 * (i + 4) + suit5;
                                if (tempo == target)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}