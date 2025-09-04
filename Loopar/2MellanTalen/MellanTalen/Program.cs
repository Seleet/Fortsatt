Console.WriteLine("Skriv ett heltal:");
int tal1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Skriv ett annat heltal:");
int tal2 = Convert.ToInt32(Console.ReadLine());

if (tal1 < tal2)
{
    for (int i = tal1; i <= tal2; i++)
    {
        Console.WriteLine(i);
    }
}
else if (tal1 > tal2)
{
    for (int i = tal1; i >= tal2; i--)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Talen är lika: " + tal1);
}
