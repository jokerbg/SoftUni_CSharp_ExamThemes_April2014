using System;
class BitSifting
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string input = Convert.ToString((long)number, 2).PadLeft(64, '0');

        char[] array = input.ToCharArray();

        int cycles = Int32.Parse(Console.ReadLine());
        int sumOnes = 0;
        for (int i = 0; i < cycles; i++)
        {
            ulong entry = ulong.Parse(Console.ReadLine());
            string entryString = Convert.ToString((long)entry, 2).PadLeft(64, '0');

            char[] arrayEntry = entryString.ToCharArray();
            char[] arrayTempo = new char[64];
            for (int j = 0; j < 64; j++)
            {
                arrayTempo[j] = (arrayEntry[j] == '1') ? '0' : array[j];
            }

            for (int k = 0; k < 64; k++)
            {
                array[k] = arrayTempo[k];
            }
        }
        for (int k = 0; k < 64; k++)
        {
            sumOnes += array[k] - '0';
        }
        //Console.WriteLine(Convert.ToUInt64(string.Join("", array), 2));
        Console.WriteLine(sumOnes);
    }
}