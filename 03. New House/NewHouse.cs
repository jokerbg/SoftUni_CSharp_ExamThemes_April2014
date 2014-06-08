using System;
class NewHouse
{
    static void Main()
    {
        int input = Int32.Parse(Console.ReadLine());
        for (int i = (input - 1)/2 ; i >= 0; i--)
        {
           Console.WriteLine("{0}{1}{0}", new string('-', i), new string('*', input-i*2)); 
        }
        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine("|{0}|", new string('*', input-2));
        }   
    }
}