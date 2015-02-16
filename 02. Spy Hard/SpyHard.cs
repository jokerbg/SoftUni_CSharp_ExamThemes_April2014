using System;
using System.Collections.Generic;
class SpyHard
{
    static void Main()
    {
        int key = Int32.Parse(Console.ReadLine());
        char[] msg = Console.ReadLine().ToLower().ToCharArray();

        string result = "";
        int msgValue = 0;

        for (int i = 0; i < msg.Length; i++)
        {
            msgValue += (msg[i] >= 97 && msg[i] <= 122) ? msg[i] - 96 : msg[i];
        }

        string alphaNum = "";
        List<string> convert = new List<string>();
        while (msgValue > 0)
        {
            alphaNum = Convert.ToString(msgValue % key);
            convert.Add(alphaNum);
            msgValue /= key;
        }
        convert.Reverse();
        result = string.Join("", convert);
        Console.WriteLine(key.ToString() + msg.Length + result);
    }
}