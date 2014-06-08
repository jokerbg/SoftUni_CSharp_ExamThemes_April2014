using System;
class LongestAlphabeticalWord
{
    static void PrintMatrix(string[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string word = Console.ReadLine();
        int n = Int32.Parse(Console.ReadLine());
        int index = 0;
        string[,] matrix = new string[n, n];
        string max = "";
        string temp = "";

        if (n == 1)
        {
            max = word[0].ToString();
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = word[index].ToString();
                index++;
                if (index == word.Length)
                {
                    index = 0;
                }
            }
        }
        //PrintMatrix(matrix, n);

        //horizontal checks
        for (int i = 0; i < n; i++)
        {
            //left to right
            temp = matrix[i, 0];
            for (int j = 1; j < n; j++)
            {
                if (Convert.ToChar(matrix[i, j]) <= Convert.ToChar(matrix[i, j - 1]))
                {
                    temp = matrix[i, j];
                }
                else
                {
                    temp += matrix[i, j];
                }

                if (temp.Length > max.Length)
                {
                    max = temp;
                }
                else if (temp.Length == max.Length)
                {
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (temp[k] < max[k])
                        {
                            max = temp; break;
                        }
                        if (temp[k] > max[k])
                        {
                            break;
                        }
                    }
                }
            }
            //right to left
            temp = matrix[i, n - 1];
            for (int j = n - 2; j >= 0; j--)
            {
                if (Convert.ToChar(matrix[i, j]) <= Convert.ToChar(matrix[i, j + 1]))
                {
                    temp = matrix[i, j];
                }
                else
                {
                    temp += matrix[i, j];
                }

                if (temp.Length > max.Length)
                {
                    max = temp;
                }
                else if (temp.Length == max.Length)
                {
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (temp[k] < max[k])
                        {
                            max = temp; break;
                        }
                        if (temp[k] > max[k])
                        {
                            break;
                        }
                    }
                }
            }
        }

        //vertical checks
        for (int i = 0; i < n; i++)
        {
            //up-down
            temp = matrix[0, i];
            for (int j = 1; j < n; j++)
            {
                if (Convert.ToChar(matrix[j, i]) <= Convert.ToChar(matrix[j - 1, i]))
                {
                    temp = matrix[j, i];
                }
                else
                {
                    temp += matrix[j, i];
                }

                if (temp.Length > max.Length)
                {
                    max = temp;
                }
                else if (temp.Length == max.Length)
                {
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (temp[k] < max[k])
                        {
                            max = temp; break;
                        }
                        if (temp[k] > max[k])
                        {
                            break;
                        }
                    }
                }
            }
            //bottom-up
            temp = matrix[n - 1, i];
            for (int j = n - 2; j >= 0; j--)
            {
                if (Convert.ToChar(matrix[j, i]) <= Convert.ToChar(matrix[j + 1, i]))
                {
                    temp = matrix[j, i];
                }
                else
                {
                    temp += matrix[j, i];
                }

                if (temp.Length > max.Length)
                {
                    max = temp;
                }
                else if (temp.Length == max.Length)
                {
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (temp[k] < max[k])
                        {
                            max = temp; break;
                        }
                        if (temp[k] > max[k])
                        {
                            break;
                        }
                    }
                }
            }
        }
        Console.WriteLine(max);
    }
}