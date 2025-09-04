// ?? = null-coalescing operator, ersätter null med tom sträng ("")
Console.Write("Skriv in ditt förnamn: ");
string firstName = Console.ReadLine() ?? "";
Console.Write("Skriv in ditt efternamn: ");
string lastName = Console.ReadLine() ?? "";
Console.WriteLine($"Hej {lastName}, {firstName}");
