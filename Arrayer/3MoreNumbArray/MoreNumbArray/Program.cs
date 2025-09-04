Console.Write("Hur många tal vill du mata in? ");
int antal = Convert.ToInt32(Console.ReadLine());

int[] talArray = new int[antal];

for (int i = 0; i < antal; i++)
{
    Console.Write($"Mata in tal {i + 1}: ");
    talArray[i] = Convert.ToInt32(Console.ReadLine());
}

int storstaTal = talArray[0];

foreach (int tal in talArray)
{
    if (tal > storstaTal)
    {
        storstaTal = tal;
    }
}

Console.WriteLine($"Det största talet är: {storstaTal}");
