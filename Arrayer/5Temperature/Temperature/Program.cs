Console.Write("Hur många mätningar ska registreras? ");
int antalMeasure = int.Parse(Console.ReadLine()!);

if (antalMeasure <= 0)
{
    Console.WriteLine("Inga mätningar att bearbeta.");
    return;
}

double[] temperaturer = new double[antalMeasure];

for (int i = 0; i < antalMeasure; i++)
{
    Console.Write($"Ange temperatur för mätning {i + 1}: ");
    temperaturer[i] = double.Parse(Console.ReadLine()!);
}

double maxtemp = temperaturer[0]; 
double sumtemp = 0;

for (int i = 0; i < temperaturer.Length; i++) 
{
    if (temperaturer[i] > maxtemp)
        maxtemp = temperaturer[i];

    sumtemp += temperaturer[i];
}

double medeltemp = sumtemp / antalMeasure;

foreach (var temp in temperaturer)
{
    Console.WriteLine($"Temperatur: {temp:F1}°C");
}

Console.WriteLine($"Högsta temperatur: {maxtemp:F1}°C");
Console.WriteLine($"Medeltemperatur: {medeltemp:F1}°C");
