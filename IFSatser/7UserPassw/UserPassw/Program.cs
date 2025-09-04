
const string correctUsername = "admin";
const string correctPassword = "password123";

Console.WriteLine("Ange ditt användarnamn:");
string inputUsername = Console.ReadLine();
Console.WriteLine("Ange ditt lösenord:");
string inputPassword = Console.ReadLine();

if (inputUsername == correctUsername && inputPassword == correctPassword)
{
    Console.WriteLine("Du är inloggad.");
}
else
{
    Console.WriteLine("Felaktigt användarnamn eller lösenord.");
}