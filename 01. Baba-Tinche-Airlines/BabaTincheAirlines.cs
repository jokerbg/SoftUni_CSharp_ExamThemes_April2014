using System;
class BabaTincheAirlines
{
    static void Main()
    {
        string[] firstClass = Console.ReadLine().Split(' ');
        string[] businessClass = Console.ReadLine().Split(' ');
        string[] EconomyClass = Console.ReadLine().Split(' ');

        int f = int.Parse(firstClass[0]);
        int fFreq = int.Parse(firstClass[1]);
        int fMeal = int.Parse(firstClass[2]);

        int b = int.Parse(businessClass[0]);
        int bFreq = int.Parse(businessClass[1]);
        int bMeal = int.Parse(businessClass[2]);

        int e = int.Parse(EconomyClass[0]);
        int eFreq = int.Parse(EconomyClass[1]);
        int eMeal = int.Parse(EconomyClass[2]);

        double maxIncome = Math.Round((12 * 7000 + 28 * 3500 + 50 * 1000) * 1.005, 0);

        double revenue = 7000 * (f - 0.7 * fFreq + 0.005 * fMeal) + 3500 * (b - 0.7 * bFreq + 0.005 * bMeal) + 1000 * (e - 0.7 * eFreq + 0.005 * eMeal);

        Console.WriteLine("{0}\n{1}", (int)revenue, maxIncome - (int)revenue);
    }
}