Console.Write("Mata in ett tal: ");
int tal1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Mata in ett tal till: ");
int tal2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Mata in ett tal till: ");
int tal3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Mata in ett tal till: ");
int tal4 = Convert.ToInt32(Console.ReadLine());

int[] talArray = new int[] { tal1, tal2, tal3, tal4 };
int storstaTal = talArray[0];

foreach (int tal in talArray)
{
    if (tal > storstaTal)
    {
        storstaTal = tal;
    }
}
Console.WriteLine($"Det största talet är: {storstaTal}");
