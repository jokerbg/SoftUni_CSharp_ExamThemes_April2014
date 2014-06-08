using System;
class BitShooter
{
    static void Main()
    {
        int right = 0;
        int left = 0;

        ulong entry = ulong.Parse(Console.ReadLine());
        string input = Convert.ToString((long)entry, 2).PadLeft(64, '0');

        char[] array = input.ToCharArray();

        for (int i = 0; i < 3; i++)
        {
            string shoot = Console.ReadLine();
            string[] arrShoot = shoot.Split(' ');

            int center = 63 - int.Parse(arrShoot[0]);
            int size = int.Parse(arrShoot[1]);

            int radius = (size == 1) ? 0 : (size - 1) / 2;

            if (center - radius <= 0 && center + radius <= 63)
            {
                for (int j = 0; j <= center + radius; j++)
                {
                    array[j] = '0';
                }
            }
            else if (center - radius >= 0 && center + radius >= 63)
            {
                for (int j = center - radius; j <= 63; j++)
                {
                    array[j] = '0';
                }
            }
            else if (center - radius >= 0 && center + radius <= 63)
            {
                for (int j = center - radius; j <= center + radius; j++)
                {
                    array[j] = '0';
                }
            }
        }

        for (int i = 0; i < 32; i++)
        {
            right += (array[i + 32] == '1') ? 1 : 0;
            left += (array[i] == '1') ? 1 : 0;
        }
        Console.WriteLine("left: {0}\nright: {1}", left, right);
    }
}