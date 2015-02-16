using System;
class LettersSymbolsNumbers
{
    static void Main()
    {
        string inputStr = "";
        int sumLet = 0;
        int sumSym = 0;
        int sumNum = 0;
        int n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            inputStr += Console.ReadLine();
        }
        char[] charArr = inputStr.ToCharArray();
        for (int i = 0; i < inputStr.Length; i++)
        {
            if (charArr[i] >= 33)
            {
                if (charArr[i] >= 48 && charArr[i] <= 57)
                {
                    sumNum += 20 * (charArr[i] - 48);
                }
                else if (charArr[i] >= 65 && charArr[i] <= 90)
                {
                    sumLet += 10 * (charArr[i] - 64);
                }
                else if (charArr[i] >= 97 && charArr[i] <= 122)
                {
                    sumLet += 10 * (charArr[i] - 96);
                }
                else
                {
                    sumSym += 200;
                }
            }
        }
        Console.WriteLine(sumLet);
        Console.WriteLine(sumNum);
        Console.WriteLine(sumSym);
    }
}