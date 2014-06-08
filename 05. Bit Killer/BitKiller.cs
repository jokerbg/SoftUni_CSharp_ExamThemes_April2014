using System;
class BitKiller
{
    static void Main()
    {
        int numBytes = Int32.Parse(Console.ReadLine());
        int step = Int32.Parse(Console.ReadLine());
        string entry = null;
        int countKills = 0;

        for (int i = 0; i < numBytes; i++)
        {
            entry += Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
        }

        char[] output = entry.ToCharArray();

        if (step==1)
        {
            Console.WriteLine(Convert.ToInt32((output[0]+"0000000").ToString(), 2));
            return;
        }
        string newOutput = "";

        for (int i = 0; i < entry.Length; i++)
        {
            if (i % step != 1)
            {
                newOutput += output[i];
            }
            else
            {
                countKills++;
            }
        }

        newOutput += new String('0', countKills % 8);
        //Console.WriteLine(string.Join("", newOutput));

        for (int i = 0; i < numBytes - countKills / 8; i++)
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