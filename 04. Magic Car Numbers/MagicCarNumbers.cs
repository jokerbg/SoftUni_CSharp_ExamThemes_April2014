using System;
class MagicCarNumbers
{
    static void Main()
    {
        int magic = Int32.Parse(Console.ReadLine());
        int sum = 0;
        int nuovo = magic - 40;
        int counter = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            for (int y = 0; y < 10; y++)
                            {
                                sum = 0;
                                switch (x)
                                {
                                    case 1: sum += 10; break;
                                    case 2: sum += 20; break;
                                    case 3: sum += 30; break;
                                    case 4: sum += 50; break;
                                    case 5: sum += 80; break;
                                    case 6: sum += 110; break;
                                    case 7: sum += 130; break;
                                    case 8: sum += 160; break;
                                    case 9: sum += 200; break;
                                    case 0: sum += 240; break;
                                }

                                switch (y)
                                {
                                    case 1: sum += 10; break;
                                    case 2: sum += 20; break;
                                    case 3: sum += 30; break;
                                    case 4: sum += 50; break;
                                    case 5: sum += 80; break;
                                    case 6: sum += 110; break;
                                    case 7: sum += 130; break;
                                    case 8: sum += 160; break;
                                    case 9: sum += 200; break;
                                    case 0: sum += 240; break;
                                }

                                if ((i + j + k + l + sum == nuovo))
                                {
                                    if ((i == j && i == k) || (j == k && j == l) ||
                                        (i == j && k == l) || (i == k && j == l) ||
                                        (j == k && i == l))
                                    {
                                        counter++;
                                    }

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