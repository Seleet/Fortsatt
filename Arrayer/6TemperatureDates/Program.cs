using System;

class Program
{
    static void Main()
    {
        Console.Write("Hur många mätningar ska registreras? ");
        int antal = int.Parse(Console.ReadLine()!);

        double[] temperaturer = new double[antal];
        DateTime[] datum = new DateTime[antal];

        // Läsa in värden
        for (int i = 0; i < antal; i++)
        {
            Console.Write($"Ange temperatur för mätning {i + 1}: ");
            temperaturer[i] = double.Parse(Console.ReadLine()!);

            Console.Write($"Ange datum (yyyy-mm-dd) för mätning {i + 1}: ");
            datum[i] = DateTime.Parse(Console.ReadLine()!);
        }

        // Skriva ut alla mätningar
        Console.WriteLine("\n--- Alla mätningar ---");
        for (int i = 0; i < antal; i++)
        {
            Console.WriteLine($"{datum[i]:yyyy-MM-dd}: {temperaturer[i]} °C");
        }

        // Beräkna max och medel
        double sum = 0;
        double max = temperaturer[0];
        int maxIndex = 0;

        for (int i = 0; i < antal; i++)
        {
            sum += temperaturer[i];
            if (temperaturer[i] > max)
            {
                max = temperaturer[i];
                maxIndex = i;
            }
        }

        double medel = sum / antal;

        // Resultat
        Console.WriteLine($"\nHögsta temperatur: {max} °C (på {datum[maxIndex]:yyyy-MM-dd})");
        Console.WriteLine($"Medeltemperatur: {medel:F1} °C");
    }
}
