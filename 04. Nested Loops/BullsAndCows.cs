using System;
using System.Collections.Generic;
class BullsAndCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        List<string> result = new List<string>();
        int checkedBulls = 0;
        int checkedCows = 0;

        if (secretNumber.Length == 4)
        {
            for (int guessed = 1111; guessed < 10000; guessed++)
            {
                checkedBulls = 0;
                checkedCows = 0;
                char[] currentGuessed = guessed.ToString().ToCharArray();
                char[] currentSecret = secretNumber.ToString().ToCharArray();
                if (currentGuessed[0] >= '1' && currentGuessed[1] >= '1' && currentGuessed[2] >= '1' && currentGuessed[3] >= '1')
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (currentGuessed[i] == currentSecret[i])
                        {
                            checkedBulls++;
                            currentGuessed[i] = 'b';
                            currentSecret[i] = '*';
                        }
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (currentGuessed[i] == currentSecret[j])
                            {
                                checkedCows++;
                                currentGuessed[i] = 'c';
                                currentSecret[j] = '*';
                            }
                        }
                    }

                    if (checkedBulls == bulls && checkedCows == cows)
                    {
                        result.Add(guessed.ToString());
                    }
                }
            }
        }

        if (result.Count > 0)
        {
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}