using System;
class BiggestTriple
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split(' ');
        int[] numArr = new int[arr.Length];

        int tempoSum = 0;
        int maxSum=int.MinValue;
        string tempoString = "";
        string result = "";

        for (int i = 0; i < arr.Length; i++)
        {
            numArr[i] = int.Parse(arr[i]);
        }

        if (numArr.Length <= 3)
        {
            Console.WriteLine(input); return;
        }
        else
        {
            for (int i = 0; i < numArr.Length; i += 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i + j < numArr.Length)
                    {
                        tempoSum += numArr[i + j];
                        tempoString += numArr[i + j] + " ";
                    }
                }
                if (tempoSum>maxSum)
                {
                    maxSum = tempoSum;
                    result = tempoString;                      
                }
                tempoSum = 0;
                tempoString = "";
            }
            Console.WriteLine(result);
        }
    }
}