Console.Write("Mata in ditt födelsedatum (åååå-mm-dd): ");
DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

DateTime today = DateTime.Now;

int age = today.Year - birthDate.Year;

if (today.Month < birthDate.Month || 
   (today.Month == birthDate.Month && today.Day < birthDate.Day))
{
    age--;
}

Console.WriteLine(
    $"Du är {age} år gammal och ditt födelseår är {birthDate.Year} " +
    $"och månaden är {birthDate.Month} och dagen {birthDate.Day}."
);
