using System;
class ChangeEvenBits
{
    static int LenOfNum(int number)
    {
        string tempo = Convert.ToString(number, 2).PadLeft(32, '0');
        for (int j = 0; j < 32; j++)
        {
            if (tempo[j] == '1')
            {
                return 32 - j;
            }
        }
        return 0;
    }
    static void Main()
    {
        int countChanged = 0;
        int n = Int32.Parse(Console.ReadLine());
        int[,] array = new int[n, 2];
        for (int i = 0; i < n; i++)
        {
            array[i, 0] = Int32.Parse(Console.ReadLine());
            array[i, 1] = (array[i, 0] == 0) ? 1 : LenOfNum(array[i, 0]);
        }

        ulong numL = ulong.Parse(Console.ReadLine());
        string numLstring = Convert.ToString((long)numL, 2).PadLeft(64, '0');
        char[] result = numLstring.ToCharArray();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < array[i, 1]; j++)
            {
                if (result[64 - j * 2 - 1] == '0')
                {
                    result[64 - j * 2 - 1] = '1';
                    countChanged++;
                }
            }
        }
        Console.WriteLine(Convert.ToUInt64(string.Join("", result), 2));
        Console.WriteLine(countChanged);
    }
}