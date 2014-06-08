using System;
class CatchTheBits
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

        string newOutput = "";

        for (int i = 1; i < entry.Length; i++)
        {
            if (i % step == 1 || step == 1)
            {
                newOutput += output[i];
            }
        }
        if (newOutput.Length % 8 > 0)
        {
            newOutput += new String('0', 8 - newOutput.Length % 8);
        }
        //Console.WriteLine(string.Join("", newOutput));

        for (int i = 0; i < newOutput.Length / 8; i++)
        {
            string currOutput = null;

            for (int j = 8 * i; j < 8 * i + 8; j++)
            {
                currOutput += newOutput[j];
            }
            Console.WriteLine(Convert.ToInt32(currOutput.ToString(), 2));
        }
    }
}