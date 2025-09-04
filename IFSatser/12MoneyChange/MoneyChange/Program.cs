// See https://aka.ms/new-console-template for more information
Console.WriteLine("Inbetalning i kronor:");
int amountToPay = Convert.ToInt32(Console.ReadLine());
int hundring;
int femhundring;
int enkronor;
if (amountToPay < 100)
{
    Console.WriteLine($"Du får {amountToPay} enkro");
}
else if (amountToPay >= 100 && amountToPay < 500)
{
    hundring = amountToPay / 100;
    enkronor = amountToPay % 100;
    Console.WriteLine($"Du får {hundring} hundringar och {enkronor} enkronor");
}
else if (amountToPay >= 500)
{
    femhundring = amountToPay / 500;
    hundring = (amountToPay % 500) / 100;
    enkronor = (amountToPay % 500) % 100;
    Console.WriteLine($"Du får {femhundring} femhundringar, {hundring} hundringar och {enkronor} enkronor");
}
