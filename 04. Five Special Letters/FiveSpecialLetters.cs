using System;
class FiveSpecialLetters
{
    static void Main()
    {
        int start = Int32.Parse(Console.ReadLine());
        int end = Int32.Parse(Console.ReadLine());
        int result = 0;
        int weigth = 0;
        int counter = 0;
        for (int a = 'a'; a <= 'e'; a++)
        {
            for (int b = 'a'; b <= 'e'; b++)
            {
                for (int c = 'a'; c <= 'e'; c++)
                {
                    for (int d = 'a'; d <= 'e'; d++)
                    {
                        for (int e = 'a'; e <= 'e'; e++)
                        {
                            string output = "" + (char)a;

                            if (b != a)
                            {
                                output += (char)b;
                            }
                            if (c != a && c != b)
                            {
                                output += (char)c;
                            }
                            if (d != a && d != b && d != c)
                            {
                                output += (char)d;
                            }
                            if (e != a && e != b && e != c && e != d)
                            {
                                output += (char)e;
                            }

                            for (int i = 1; i <= output.Length; i++)
                            {
                                int charo = output[i - 1];
                                switch (charo)
                                {
                                    case 'a': weigth = 5; break;
                                    case 'b': weigth = -12; break;
                                    case 'c': weigth = 47; break;
                                    case 'd': weigth = 7; break;
                                    case 'e': weigth = -32; break;
                                }
                                result += i * weigth;
                            }
                            if (result >= start && result <= end)
                            {
                                Console.Write(""+ (char)a + (char)b + (char)c + (char)d + (char)e + " ");
                                counter++;
                            }
                            result = 0;
                        }
                    }
                }
            }
        }
        if (counter==0)
        {
            Console.WriteLine("No");
        }
    }
}