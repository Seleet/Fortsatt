Console.Write("Hur mycket pengar har du?: ");
var pengar = int.Parse(Console.ReadLine();
Console.WriteLine("Har du rabatt? (j/n): ");
bool rabatt = Console.ReadLine();.ToLower() == "j";
if (pengar < 26 && pengar > 14)
{
    Console.WriteLine("Du kan köpa en liten hamburgare");
    if (rabatt)
    {
        Console.WriteLine("Du kan köpa en liten hamburgare och en pommes frites");
    }
else if (pengar > 25 && pengar =< 50)
{
    Console.WriteLine("Du kan köpa en stor hamburgare");
    if (rabatt)
    {
        Console.WriteLine("Du kan köpa en stor hamburgare och en pommes frites");
    }
}
else if (pengar > 60 || pengar > 50 && rabatt)
{
    Console.WriteLine("Du kan köpa ett meal med dryck");
}