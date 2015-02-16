using System;
class BookOrders
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        double disco = 0;
        double totalPrice = 0;
        int totalAmount = 0;
        for (int i = 0; i < n; i++)
        {
            int bookPacks = Int32.Parse(Console.ReadLine());

            if (bookPacks >= 110)
            {
                disco = 0.15;
            }
            else if (bookPacks >= 100)
            {
                disco = 0.14;
            }
            else if (bookPacks >= 90)
            {
                disco = 0.13;
            }
            else if (bookPacks >= 80)
            {
                disco = 0.12;
            }
            else if (bookPacks >= 70)
            {
                disco = 0.11;
            }
            else if (bookPacks >= 60)
            {
                disco = 0.10;
            }
            else if (bookPacks >= 50)
            {
                disco = 0.09;
            }
            else if (bookPacks >= 40)
            {
                disco = 0.08;
            }
            else if (bookPacks >= 30)
            {
                disco = 0.07;
            }
            else if (bookPacks >= 20)
            {
                disco = 0.06;
            }
            else if (bookPacks >= 10)
            {
                disco = 0.05;
            }
            else
            {
                disco = 0;
            }

            int bookAmount = Int32.Parse(Console.ReadLine());
            double bookPrice = double.Parse(Console.ReadLine());
            totalPrice += bookPacks * bookAmount * bookPrice*(1 - disco);
            totalAmount += bookPacks * bookAmount;
        }
        Console.WriteLine(totalAmount);
        Console.WriteLine(String.Format("{0:0.00}", totalPrice));
    }
}