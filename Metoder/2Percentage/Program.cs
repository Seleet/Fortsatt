using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        decimal value;

        while (true) // loopa tills vi får rätt
        {
            Console.WriteLine("Mata in ett decimaltal mellan 0 och 1!");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, NumberStyles.Number, new CultureInfo("sv-SE"), out value)
                && value >= 0 && value <= 1)
            {
                break; // hoppa ur loopen när det är giltigt
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning, försök igen.\n");
            }
        }

        Console.WriteLine($"Input blir {ToPercentage(value)}%");
    }

    static decimal ToPercentage(decimal talet)
    {
        return talet * 100;
    }
}
