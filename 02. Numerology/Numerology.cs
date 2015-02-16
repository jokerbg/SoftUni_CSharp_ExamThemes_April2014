using System;
class Numerology
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ', '.');
        string name = input[3];
        int day = int.Parse(input[0]);
        int month = int.Parse(input[1]);
        int year = int.Parse(input[2]);
        int resultName = 0;

        long resultDate = (long)(day * month * year) * (long)((month % 2 == 1) ? day * month * year : 1);

        string final = "";

        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] >= '0' && name[i] <= '9')
            {
                resultName += name[i] - '0';
            }
            else if (name[i] == name.ToUpper()[i])
            {
                resultName += (name[i] - 'A' + 1) * 2;
            }
            else
            {
                resultName += name[i] - 'a' + 1;
            }
            final = resultName + resultDate + "";
        }

        int magic = 0;

        while (true)
        {
            char[] magika = final.ToCharArray();
            for (int i = 0; i < magika.Length; i++)
            {
                magic += magika[i] - '0';
            }
            if (magic <= 13)
            {
                Console.WriteLine(magic);
                return;
            }
            else
            {
                final = magic.ToString();
                magic = 0;
            }
        }
    }
}