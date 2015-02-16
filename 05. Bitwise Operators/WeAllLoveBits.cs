using System;
class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            string inputString = Convert.ToString(input, 2);
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(Convert.ToInt32(new string(arr), 2));
        }
    }
}