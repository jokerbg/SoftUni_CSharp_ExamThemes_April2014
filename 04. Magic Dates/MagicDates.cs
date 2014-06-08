using System;
class MagicDates
{
    static void Main()
    {
        int start = Int32.Parse(Console.ReadLine());
        int end = Int32.Parse(Console.ReadLine());
        int magic = Int32.Parse(Console.ReadLine());

        DateTime startDate = new DateTime(start, 1, 1);
        DateTime endDate = new DateTime(end, 12, 31);
        DateTime tempoDate = startDate;

        int score = 0;
        int day, month, year, day1, day2, mon1, mon2, yea1, yea2, yea3, yea4;
        bool yesno = false;

        while (tempoDate != endDate)
        {
            day = (tempoDate.Day);
            month = (tempoDate.Month);
            year = (tempoDate.Year);

            day1 = day / 10;
            day2 = day % 10;

            mon1 = month / 10;
            mon2 = month % 10;

            yea1 = (year / 1000) % 10;
            yea2 = (year / 100) % 10;
            yea3 = (year / 10) % 10;
            yea4 = year % 10;

            score = day1 * (day2 + mon1 + mon2 + yea1 + yea2 + yea3 + yea4) + day2 * (mon1 + mon2 + yea1 + yea2 + yea3 + yea4) + mon1 * (mon2 + yea1 + yea2 + yea3 + yea4) + mon2 * (yea1 + yea2 + yea3 + yea4) + yea1 * (yea2 + yea3 + yea4) + yea2 * (yea3 + yea4) + yea3 * yea4;

            if (score == magic)
            {
                Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", day1, day2, mon1, mon2, yea1, yea2, yea3, yea4);
                yesno = true;
            }
            tempoDate = tempoDate.AddDays(1);
        }
        if (!yesno)
        {
            Console.WriteLine("No");
        }
    }
}