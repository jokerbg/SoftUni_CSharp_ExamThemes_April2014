using System;
class WorkHours
{
    static void Main()
    {
        int hoursRequired = Int32.Parse(Console.ReadLine());
        int daysAvailable = Int32.Parse(Console.ReadLine());
        double productivity = double.Parse(Console.ReadLine()) / 100;

        double diff = Math.Floor(12 * daysAvailable * .9 * productivity) - hoursRequired;
        Console.WriteLine("{0}\n{1}", diff < 0 ? "No" : "Yes", diff);
    }
}