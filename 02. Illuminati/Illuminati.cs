using System;
class Illuminati
{
    static void Main()
    {
        int counter = 0;
        int sum = 0;
        string input = (Console.ReadLine()).ToUpper();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
            {
                sum += input[i];
                counter++;
            }
        }
        Console.WriteLine("{0}\n{1}", counter, sum);
    }
}