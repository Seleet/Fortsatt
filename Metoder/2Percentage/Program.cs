using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Mata in ett decimaltal mellan 0 och 1!");
        string input = Console.ReadLine();

        if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal value))
        {
            Console.WriteLine($"input blir {ToPercentage(value)}%");
        }
        else
        {
            Console.WriteLine("Ogiltig inmatning, försök igen.");
        }
    }

    static decimal ToPercentage(decimal talet)
    {
        decimal resultat = talet * 100;
        return resultat;
    }
}
