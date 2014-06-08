using System;
using System.Globalization;
class ExamSchedule
{
    static void Main()
    {
        ushort hourStart = ushort.Parse(Console.ReadLine());
        ushort minuteStart = ushort.Parse(Console.ReadLine());
        string noon = Console.ReadLine();
        ushort hourDuration = ushort.Parse(Console.ReadLine());
        ushort minuteDuration = ushort.Parse(Console.ReadLine());

        if (noon == "PM" && hourStart < 12)
        {
            hourStart += 12;
        }
        DateTime startTime = new DateTime(2014, 4, 12, hourStart, minuteStart, 0);

        TimeSpan duration = new TimeSpan(0, hourDuration, minuteDuration, 0);

        DateTime answer = startTime.Add(duration);

        Console.WriteLine("{0}", answer.ToString("hh:mm:tt", CultureInfo.InvariantCulture));
    }
}