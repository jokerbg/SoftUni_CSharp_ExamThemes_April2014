using System;
class BitFlipper
{
    static void Main()
    {
        int index = 0;
        ulong entry = ulong.Parse(Console.ReadLine());
        string input = Convert.ToString((long)entry, 2).PadLeft(64, '0');
        char[] array = input.ToCharArray();

        for (int i = 0; i < 62; i++)
        {
            if (array[i + index] == array[i + 1 + index] && array[i + index] == array[i + 2 + index])
            {
                if (array[i + index] == '0')
                {
                    array[i + index] = '1';
                    array[i + 1 + index] = '1';
                    array[i + 2 + index] = '1';
                }
                else
                {
                    array[i + index] = '0';
                    array[i + 1 + index] = '0';
                    array[i + 2 + index] = '0';
                }
                index += 2;
            }
            if (i + index > 60)
            {
                break;
            }
        }
        Console.WriteLine(Convert.ToUInt64(string.Join("", array), 2));
    }
}