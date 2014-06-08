using System;
class BitsUp
{
    static void Main()
    {
        int numBytes = Int32.Parse(Console.ReadLine());
        int step = Int32.Parse(Console.ReadLine());
        string entry = null;

        for (int i = 0; i < numBytes; i++)
        {
            entry += Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
        }

        char[] output = entry.ToCharArray();

        for (int i = 1; i < entry.Length; i += step)
        {
            output[i] = '1';
        }

        for (int i = 0; i < numBytes; i++)
        {
            string currOutput = null;

            for (int j = 8 * i; j < 8 * i + 8; j++)
            {
                currOutput += output[j];
            }
            Console.WriteLine(Convert.ToInt32(currOutput.ToString(), 2));
        }
    }
}