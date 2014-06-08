using System;
using System.Collections.Generic;
class FriendBits
{
    static void Main()
    {
        uint entry = uint.Parse(Console.ReadLine());
        string input = Convert.ToString((uint)entry, 2).PadLeft(32, '0');

        char[] array = input.ToCharArray();

        string friends = (array[1] == array[0]) ? "" + array[0] : "";
        string alone = (array[1] == array[0]) ? "" : "" + array[0];
        string temp = "" + array[0];
        for (int i = 1; i < 32; i++)
        {
            if (array[i] == array[i - 1])
            {
                friends += array[i];
            }
            else if (i < 31 && array[i] == array[i + 1])
            {
                friends += array[i];
            }
            else
            {
                alone += array[i];
            }
        }

        Console.WriteLine((friends == "") ? 0 : Convert.ToUInt32(string.Join("", friends), 2));
        Console.WriteLine((alone == "") ? 0 : Convert.ToUInt32(string.Join("", alone), 2));
    }
}