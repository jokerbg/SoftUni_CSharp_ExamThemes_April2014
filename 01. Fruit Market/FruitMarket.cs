using System;
class FruitMarket
{
    static void Main()
    {
        double total = 0;
        double priceBanana = 1.80;
        double priceCucumber = 2.75;
        double priceTomato = 3.20;
        double priceOrange = 1.60;
        double priceApple = 0.86;

        double quantBanana = 0;
        double quantCucumber = 0;
        double quantTomato = 0;
        double quantOrange = 0;
        double quantApple = 0;

        double discount = 0;
        double discVege = 0;
        double discFruit = 0;

        string day = Console.ReadLine();
        switch (day)
        {
            case "Thursday": priceBanana *= 0.7; break;
            case "Wednesday": discVege = 0.1; break;
            case "Tuesday": discFruit = 0.2; break;
            case "Sunday": discount = 0.05; break;
            case "Friday": discount = 0.1; break;
        }

        double quantOne = double.Parse(Console.ReadLine());
        string productOne = Console.ReadLine();
        switch (productOne)
        {
            case "banana": quantBanana += quantOne; break;
            case "cucumber": quantCucumber += quantOne; break;
            case "tomato": quantTomato += quantOne; break;
            case "orange": quantOrange += quantOne; break;
            case "apple": quantApple += quantOne; break;
        }

        double quantTwo = double.Parse(Console.ReadLine());
        string productTwo = Console.ReadLine();
        switch (productTwo)
        {
            case "banana": quantBanana += quantTwo; break;
            case "cucumber": quantCucumber += quantTwo; break;
            case "tomato": quantTomato += quantTwo; break;
            case "orange": quantOrange += quantTwo; break;
            case "apple": quantApple += quantTwo; break;
        }

        double quantThree = double.Parse(Console.ReadLine());
        string productThree = Console.ReadLine();
        switch (productThree)
        {
            case "banana": quantBanana += quantThree; break;
            case "cucumber": quantCucumber += quantThree; break;
            case "tomato": quantTomato += quantThree; break;
            case "orange": quantOrange += quantThree; break;
            case "apple": quantApple += quantThree; break;
        }

        total = ((priceBanana * quantBanana + priceApple * quantApple + priceOrange * quantOrange) * (1 - discFruit) + (priceCucumber * quantCucumber + priceTomato * quantTomato) * (1 - discVege)) * (1 - discount);

        Console.WriteLine("{0:F2}", total);
    }
}