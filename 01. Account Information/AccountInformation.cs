using System;
class AccountInformation
{
    static void Main()
    {
        string first = (Console.ReadLine());
        string second = (Console.ReadLine());
        int clientId = Int32.Parse(Console.ReadLine());
        double balance = double.Parse(Console.ReadLine());

        Console.WriteLine("Hello, "+ first+ " " + second);
        Console.WriteLine("Client id: {0}", clientId);
        Console.WriteLine("Total balance: {0:F2}", balance);
        Console.WriteLine("Active: {0}", (balance>=0)?"yes": "no");
    }
}