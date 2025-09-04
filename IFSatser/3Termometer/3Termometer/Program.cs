Console.WriteLine("Vilken temp visar termometern?");
double temp = Convert.ToDouble(Console.ReadLine());
if (temp > 37.8 && temp <= 39.5)
{
    Console.WriteLine("Du har feber");
}
else if (temp > 39.5)
{
    Console.WriteLine("Du bör uppsöka läkare");
}
else
{
    Console.WriteLine("Du har inte feber.");
}
