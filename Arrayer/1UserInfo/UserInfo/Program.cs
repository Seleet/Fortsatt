Console.WriteLine("Hej, vänligen mata in följande!");
Console.Write("Förnamn: ");
string firstName = Console.ReadLine() ?? "";
Console.Write("Efternamn: ");
string lastName = Console.ReadLine() ?? "";
Console.Write("Adress: ");
string address = Console.ReadLine() ?? "";
Console.Write("Postort: ");
string postalCode = Console.ReadLine() ?? "";
Console.Write("Telefonnummer: ");
string phoneNumber = Console.ReadLine() ?? "";
Console.Write("Email: ");
string email = Console.ReadLine() ?? "";

string[] userInfo = { firstName, lastName, address, postalCode, phoneNumber, email };

Console.WriteLine("\nKontrollera att uppgifterna stämmer:");
Console.WriteLine($"Förnamn: {userInfo[0]}");
Console.WriteLine($"Efternamn: {userInfo[1]}");
Console.WriteLine($"Adress: {userInfo[2]}");
Console.WriteLine($"Postort: {userInfo[3]}");
Console.WriteLine($"Telefonnummer: {userInfo[4]}");
Console.WriteLine($"Email: {userInfo[5]}");