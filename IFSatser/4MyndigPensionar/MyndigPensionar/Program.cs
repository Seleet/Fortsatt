Console.WriteLine("Hej, vad är din ålder?");
string? userAge = Console.ReadLine();

if (int.TryParse(userAge, out int age))
{
    if (age < 18)
    {
        Console.WriteLine("Du är inte myndig.");
    }
    else if (age >= 65)
    {
        Console.WriteLine($"Du är {age} år och pensionär.");
    }
    else
    {
        Console.WriteLine($"Du är {age} år och myndig men inte pensionär.");
    }
}
else
{
    Console.WriteLine("Ogiltig ålder angiven, försök igen.");
}
