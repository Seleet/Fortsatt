
Console.Write("Mata in en summa: ");
int summa = int.Parse(Console.ReadLine()!);
int moms = (int)(summa * 0.25);
Console.WriteLine($"Summa inkl moms: {summa + moms}");